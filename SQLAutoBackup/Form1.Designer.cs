
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectDb = new System.Windows.Forms.ComboBox();
            this.labelServerAddress = new System.Windows.Forms.Label();
            this.buttonConnectServer = new System.Windows.Forms.Button();
            this.textBoxServerAddress = new System.Windows.Forms.TextBox();
            this.selectDbLabel = new System.Windows.Forms.Label();
            this.labelServerUserID = new System.Windows.Forms.Label();
            this.textBoxServerUserID = new System.Windows.Forms.TextBox();
            this.labelServerUserPassword = new System.Windows.Forms.Label();
            this.textBoxServerUserPassword = new System.Windows.Forms.TextBox();
            this.btnActiveTimer = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.BackupTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectDb);
            this.panel1.Controls.Add(this.labelServerAddress);
            this.panel1.Controls.Add(this.buttonConnectServer);
            this.panel1.Controls.Add(this.textBoxServerAddress);
            this.panel1.Controls.Add(this.selectDbLabel);
            this.panel1.Controls.Add(this.labelServerUserID);
            this.panel1.Controls.Add(this.textBoxServerUserID);
            this.panel1.Controls.Add(this.labelServerUserPassword);
            this.panel1.Controls.Add(this.textBoxServerUserPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 182);
            this.panel1.TabIndex = 0;
            // 
            // selectDb
            // 
            this.selectDb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDb.Enabled = false;
            this.selectDb.FormattingEnabled = true;
            this.selectDb.Location = new System.Drawing.Point(15, 146);
            this.selectDb.Margin = new System.Windows.Forms.Padding(2);
            this.selectDb.Name = "selectDb";
            this.selectDb.Size = new System.Drawing.Size(100, 21);
            this.selectDb.TabIndex = 31;
            // 
            // labelServerAddress
            // 
            this.labelServerAddress.AutoSize = true;
            this.labelServerAddress.Location = new System.Drawing.Point(9, 11);
            this.labelServerAddress.Name = "labelServerAddress";
            this.labelServerAddress.Size = new System.Drawing.Size(38, 13);
            this.labelServerAddress.TabIndex = 25;
            this.labelServerAddress.Text = "Server";
            // 
            // buttonConnectServer
            // 
            this.buttonConnectServer.Location = new System.Drawing.Point(129, 146);
            this.buttonConnectServer.Name = "buttonConnectServer";
            this.buttonConnectServer.Size = new System.Drawing.Size(78, 23);
            this.buttonConnectServer.TabIndex = 30;
            this.buttonConnectServer.Text = "Connect";
            this.buttonConnectServer.UseVisualStyleBackColor = true;
            this.buttonConnectServer.Click += new System.EventHandler(this.buttonConnectServer_Click);
            // 
            // textBoxServerAddress
            // 
            this.textBoxServerAddress.Location = new System.Drawing.Point(53, 8);
            this.textBoxServerAddress.Name = "textBoxServerAddress";
            this.textBoxServerAddress.Size = new System.Drawing.Size(154, 20);
            this.textBoxServerAddress.TabIndex = 22;
            // 
            // selectDbLabel
            // 
            this.selectDbLabel.AutoSize = true;
            this.selectDbLabel.Enabled = false;
            this.selectDbLabel.Location = new System.Drawing.Point(12, 131);
            this.selectDbLabel.Name = "selectDbLabel";
            this.selectDbLabel.Size = new System.Drawing.Size(53, 13);
            this.selectDbLabel.TabIndex = 27;
            this.selectDbLabel.Text = "Database";
            // 
            // labelServerUserID
            // 
            this.labelServerUserID.AutoSize = true;
            this.labelServerUserID.Location = new System.Drawing.Point(12, 50);
            this.labelServerUserID.Name = "labelServerUserID";
            this.labelServerUserID.Size = new System.Drawing.Size(18, 13);
            this.labelServerUserID.TabIndex = 26;
            this.labelServerUserID.Text = "ID";
            // 
            // textBoxServerUserID
            // 
            this.textBoxServerUserID.Location = new System.Drawing.Point(53, 47);
            this.textBoxServerUserID.Name = "textBoxServerUserID";
            this.textBoxServerUserID.Size = new System.Drawing.Size(154, 20);
            this.textBoxServerUserID.TabIndex = 23;
            // 
            // labelServerUserPassword
            // 
            this.labelServerUserPassword.AutoSize = true;
            this.labelServerUserPassword.Location = new System.Drawing.Point(12, 93);
            this.labelServerUserPassword.Name = "labelServerUserPassword";
            this.labelServerUserPassword.Size = new System.Drawing.Size(30, 13);
            this.labelServerUserPassword.TabIndex = 28;
            this.labelServerUserPassword.Text = "Pass";
            // 
            // textBoxServerUserPassword
            // 
            this.textBoxServerUserPassword.Location = new System.Drawing.Point(53, 90);
            this.textBoxServerUserPassword.Name = "textBoxServerUserPassword";
            this.textBoxServerUserPassword.PasswordChar = '*';
            this.textBoxServerUserPassword.Size = new System.Drawing.Size(154, 20);
            this.textBoxServerUserPassword.TabIndex = 24;
            // 
            // btnActiveTimer
            // 
            this.btnActiveTimer.Enabled = false;
            this.btnActiveTimer.Location = new System.Drawing.Point(132, 232);
            this.btnActiveTimer.Name = "btnActiveTimer";
            this.btnActiveTimer.Size = new System.Drawing.Size(75, 23);
            this.btnActiveTimer.TabIndex = 1;
            this.btnActiveTimer.Text = "Active Timer";
            this.btnActiveTimer.UseVisualStyleBackColor = true;
            this.btnActiveTimer.Click += new System.EventHandler(this.btnActiveTimer_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 204);
            this.progressBar1.Maximum = 30000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(195, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 234);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(114, 20);
            this.txtPath.TabIndex = 3;
            // 
            // BackupTimer
            // 
            this.BackupTimer.Interval = 30000;
            this.BackupTimer.Tick += new System.EventHandler(this.BackupTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 276);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnActiveTimer);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActiveTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox selectDb;
        private System.Windows.Forms.Label labelServerAddress;
        private System.Windows.Forms.Button buttonConnectServer;
        private System.Windows.Forms.TextBox textBoxServerAddress;
        private System.Windows.Forms.Label selectDbLabel;
        private System.Windows.Forms.Label labelServerUserID;
        private System.Windows.Forms.TextBox textBoxServerUserID;
        private System.Windows.Forms.Label labelServerUserPassword;
        private System.Windows.Forms.TextBox textBoxServerUserPassword;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Timer BackupTimer;
    }
}

