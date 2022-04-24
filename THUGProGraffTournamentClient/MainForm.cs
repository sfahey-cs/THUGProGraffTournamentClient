using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Memory;
using System.Threading;
using System.Diagnostics;
using Google.Cloud.Firestore;

namespace THUGProGraffTournamentClient
{
    public partial class MainForm : Form
    {
        // Window dragging stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Mem m = new Mem();
        private SettingsForm settings;
        public ActiveUsersForm activeUsers;
        public FirestoreDb db;
        public string username;
        public Boolean loggedIn = false;

        public MainForm()
        {
            InitializeComponent();
            settings = new SettingsForm(this);
            activeUsers = new ActiveUsersForm(this);
        }

        bool procOpen = false;
        public int tagCount = 0;
        public int maxTags = 0;

        private async void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (!m.OpenProcess("THUGPro"))
                {
                    procOpen = false;
                    Thread.Sleep(1000);
                    bgWorker.ReportProgress(0);
                    continue;
                }
                IntPtr possibleMemAddress;
                possibleMemAddress = (IntPtr)m.ReadInt("006F0DCC")-28;
                string hexMemAddress = possibleMemAddress.ToInt32().ToString("X");
                int tempTagCount = m.ReadInt(hexMemAddress);
                if (tempTagCount != 0)
                {
                    tagCount = tempTagCount;
                }

                procOpen = true;
                Thread.Sleep(100);

                try
                {
                    bgWorker.ReportProgress(0);
                } catch (Exception exception)
                {
                    Debug.WriteLine("Caught exception" + exception.ToString());
                }
                
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            
            bgWorker.RunWorkerAsync();
            this.TopMost = false;
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (procOpen) { settings.ProcessStatusLabelText = "Found"; }
            else { settings.ProcessStatusLabelText = "N/A"; }
            label4.Text = tagCount.ToString();
            if (tagCount >  maxTags)
            {
                maxTags = tagCount;
                if (loggedIn) { updateMaxTags(); }
            }
            maxTagsCounter.Text = maxTags.ToString();
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void resetMaxTags_Click(object sender, EventArgs e)
        {
            maxTags = 0;
            tagCount = 0;
            if(loggedIn) { updateMaxTags(); }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Any_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.ContextMenu = new ContextMenu();
                this.ContextMenu.MenuItems.Add("Always on top", menu_item_top);
                this.ContextMenu.MenuItems.Add("Exit", menu_item_exit);
                this.ContextMenu.Show(this.Controls[0], e.Location);
            }
        }

        private void Any_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void menu_item_top(object sender, EventArgs e)
        {
            if (this.TopMost == true)
            {
                this.ContextMenu.MenuItems[0].Checked = false;
                this.TopMost = false;
                activeUsers.TopMost = false; 
            }
            else // TopMost == false
            {
                this.ContextMenu.MenuItems[0].Checked = true;
                this.TopMost = true;
                activeUsers.TopMost = true;
            }

        }
        private void menu_item_exit(object sender, EventArgs e)
        {
            Close();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            settings.Show();
        }

        private async void updateMaxTags()
        {
            DocumentReference docref = db.Collection("Users").Document(username);
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "MaxTags", maxTags }
            };

            DocumentSnapshot snap = await docref.GetSnapshotAsync();
            if (snap.Exists)
            {
                await docref.UpdateAsync(data);
            }
        }

        private void markUserInactive()
        {
            DocumentReference docref = db.Collection("Users").Document(username);
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "Active", false }
            };
            docref.UpdateAsync(data);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loggedIn) { markUserInactive(); }
        }
    }
}
