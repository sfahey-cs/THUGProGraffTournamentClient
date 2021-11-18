namespace THUGProGraffTournamentClient
{
    partial class SettingsForm
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
            this.Hide();
            /*if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);*/
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.UsenameTextBox = new System.Windows.Forms.TextBox();
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.ProcessStatusLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsenameTextBox
            // 
            this.UsenameTextBox.Location = new System.Drawing.Point(16, 85);
            this.UsenameTextBox.Name = "UsenameTextBox";
            this.UsenameTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsenameTextBox.TabIndex = 0;
            this.UsenameTextBox.TextChanged += new System.EventHandler(this.UsenameTextBox_TextChanged);
            this.UsenameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsenameTextBox_KeyDown);
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessLabel.Location = new System.Drawing.Point(12, 13);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(70, 20);
            this.ProcessLabel.TabIndex = 1;
            this.ProcessLabel.Text = "Process:";
            // 
            // ProcessStatusLabel
            // 
            this.ProcessStatusLabel.AutoSize = true;
            this.ProcessStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessStatusLabel.Location = new System.Drawing.Point(88, 13);
            this.ProcessStatusLabel.Name = "ProcessStatusLabel";
            this.ProcessStatusLabel.Size = new System.Drawing.Size(35, 20);
            this.ProcessStatusLabel.TabIndex = 2;
            this.ProcessStatusLabel.Text = "N/A";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(16, 66);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(41, 155);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.ProcessStatusLabel);
            this.Controls.Add(this.ProcessLabel);
            this.Controls.Add(this.UsenameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsenameTextBox;
        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.Label ProcessStatusLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button LoginButton;
    }
}