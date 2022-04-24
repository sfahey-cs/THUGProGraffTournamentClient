namespace THUGProGraffTournamentClient
{
    partial class ActiveUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.userListBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.userListBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.userListBox.ItemHeight = 37;
            this.userListBox.Location = new System.Drawing.Point(12, 12);
            this.userListBox.Name = "userListBox";
            this.userListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.userListBox.Size = new System.Drawing.Size(233, 411);
            this.userListBox.TabIndex = 0;
            this.userListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userListBox_KeyDown);
            this.userListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Any_MouseDown);
            // 
            // ActiveUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(257, 436);
            this.Controls.Add(this.userListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActiveUsersForm";
            this.Text = "ActiveUsersForm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Any_MouseDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Any_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox;
    }
}