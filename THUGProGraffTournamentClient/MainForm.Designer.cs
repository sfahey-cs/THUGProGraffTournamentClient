namespace THUGProGraffTournamentClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxTagsCounter = new System.Windows.Forms.Label();
            this.resetMaxTags = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(-6, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tag Count";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Any_MouseClick);
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Any_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(-1, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Any_MouseClick);
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Any_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(171, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "Max Tags";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Any_MouseClick);
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Any_MouseDown);
            // 
            // maxTagsCounter
            // 
            this.maxTagsCounter.AutoSize = true;
            this.maxTagsCounter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTagsCounter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.maxTagsCounter.Location = new System.Drawing.Point(178, 40);
            this.maxTagsCounter.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.maxTagsCounter.Name = "maxTagsCounter";
            this.maxTagsCounter.Size = new System.Drawing.Size(33, 37);
            this.maxTagsCounter.TabIndex = 9;
            this.maxTagsCounter.Text = "0";
            this.maxTagsCounter.Click += new System.EventHandler(this.maxTagsCounter_Click);
            this.maxTagsCounter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Any_MouseClick);
            this.maxTagsCounter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Any_MouseDown);
            // 
            // resetMaxTags
            // 
            this.resetMaxTags.Location = new System.Drawing.Point(185, 78);
            this.resetMaxTags.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.resetMaxTags.Name = "resetMaxTags";
            this.resetMaxTags.Size = new System.Drawing.Size(124, 44);
            this.resetMaxTags.TabIndex = 10;
            this.resetMaxTags.Text = "Reset";
            this.resetMaxTags.UseVisualStyleBackColor = true;
            this.resetMaxTags.Click += new System.EventHandler(this.resetMaxTags_Click);
            // 
            // Settings
            // 
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(2, 90);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(40, 41);
            this.Settings.TabIndex = 11;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(316, 131);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.resetMaxTags);
            this.Controls.Add(this.maxTagsCounter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Any_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Any_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label maxTagsCounter;
        private System.Windows.Forms.Button resetMaxTags;
        private System.Windows.Forms.PictureBox Settings;
    }
}

