using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUGProGraffTournamentClient
{
    public partial class SettingsForm : Form
    {
        MainForm mainForm;

        public SettingsForm(MainForm mainFrm)
        {
            InitializeComponent();
            this.mainForm = mainFrm;
        }

        public string ProcessStatusLabelText
        {
            get
            {
                return this.ProcessStatusLabel.Text;
            }
            set
            {
                this.ProcessStatusLabel.Text = value;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginButton.Enabled = false;
            UsenameTextBox.Enabled = false;
            this.mainForm.db = InitializeProjectId("graffitiserver");
            SetPlayerToActive();
            LoginButton.Enabled = true;
            UsenameTextBox.Enabled = true;
        }

        public static FirestoreDb InitializeProjectId(string project)
        {
            string encryptedText = File.ReadAllText("encrypted.dat");
            byte[] key = File.ReadAllBytes("key.dat");
            string jsonString = AESGCM.SimpleDecrypt(encryptedText, key);
            FirestoreDb db = FirestoreDb.Create(project, new FirestoreClientBuilder { JsonCredentials = jsonString }.Build());
            return db;
        }
        
        public void SetPlayerToActive()
        {
            //perform a get for the username and password
            //if user exists set to active = true
            //else create new user
            DocumentReference doc = this.mainForm.db.Collection("Users").Document(this.mainForm.username);
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "Username", this.mainForm.username },
                { "Password", "hunter1" },
                { "MaxTags", 0 },
                { "Active", true }
            };
            doc.SetAsync(data);
            this.mainForm.loggedIn = true;
            this.mainForm.activeUsers.queryActiveUsersList();
            this.mainForm.activeUsers.Show();
            this.Hide();
        }

        private void UsenameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.mainForm.username = UsenameTextBox.Text;
        }

        private void UsenameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoginButton_Click(this, new EventArgs());
            }
        }

    }
}
