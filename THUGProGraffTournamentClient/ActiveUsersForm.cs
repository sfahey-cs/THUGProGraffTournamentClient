using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUGProGraffTournamentClient
{
    public partial class ActiveUsersForm : Form
    {
        // Window dragging stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        MainForm mainForm;

        public ActiveUsersForm(MainForm mainFrm)
        {
            InitializeComponent();
            this.mainForm = mainFrm;
        }

        public void queryActiveUsersList()
        {
            Query query = mainForm.db.Collection("Users").WhereEqualTo("Active", true);

            FirestoreChangeListener listener = query.Listen(snapshot =>
            {
                updateActiveUsersList(snapshot);
            });
        }

        public void updateActiveUsersList(QuerySnapshot snapshot)
        {
            ArrayList players = new ArrayList();

            foreach (DocumentSnapshot docsnap in snapshot.Documents)
            {
                if (docsnap.Exists)
                {
                    Player player = docsnap.ConvertTo<Player>();
                    players.Add(player);
                }
            }
            players.Sort(new PlayerComparer());
            this.Invoke(new MethodInvoker(delegate ()
            {
                userListBox.Items.Clear();
            }));
            foreach (Player player in players)
            {
                Debug.WriteLine(player.Username);
                Debug.WriteLine(player.MaxTags);
                try
                {
                   this.Invoke(new MethodInvoker(delegate ()
                   {
                       userListBox.Items.Add(player.Username + ": " + player.MaxTags);
                   }));
                } catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }
                
            }
        }

        public class PlayerComparer:IComparer
        {
            int IComparer.Compare(Object x, Object y)
            {
                if (x == null)
                    return (y == null) ? 0 : 1;
                if (y == null)
                    return -1;
                Player p1 = x as Player;
                Player p2 = y as Player;
                int test = p2.MaxTags.CompareTo(p1.MaxTags);
                return test;
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
    }
}
