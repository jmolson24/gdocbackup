namespace GDocBackup
{
    partial class ConfigForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.TbBackupDir = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSelectDir = new System.Windows.Forms.Button();
            this.cbDocFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPresFormat = new System.Windows.Forms.ComboBox();
            this.cbSprShFormat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.CbStorePassword = new System.Windows.Forms.CheckBox();
            this.panelProxy = new System.Windows.Forms.Panel();
            this.panelProxy2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.comboProxyHostSource = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelProxyUserPwd = new System.Windows.Forms.Panel();
            this.tbProxyLogin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbProxyPassword = new System.Windows.Forms.TextBox();
            this.comboProxyAuthType = new System.Windows.Forms.ComboBox();
            this.panelProxyHostPort = new System.Windows.Forms.Panel();
            this.tbProxyHost = new System.Windows.Forms.TextBox();
            this.LabelProxyAddress = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbProxyPort = new System.Windows.Forms.TextBox();
            this.cbDirectConnection = new System.Windows.Forms.CheckBox();
            this.cbSetProxy = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbDisableUpdateCheck = new System.Windows.Forms.CheckBox();
            this.panelProxy.SuspendLayout();
            this.panelProxy2.SuspendLayout();
            this.panelProxyUserPwd.SuspendLayout();
            this.panelProxyHostPort.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Backup directory:";
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(107, 17);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(98, 20);
            this.TbUsername.TabIndex = 1;
            // 
            // TbBackupDir
            // 
            this.TbBackupDir.Location = new System.Drawing.Point(107, 83);
            this.TbBackupDir.Name = "TbBackupDir";
            this.TbBackupDir.Size = new System.Drawing.Size(165, 20);
            this.TbBackupDir.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(109, 241);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(84, 29);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(199, 241);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 30);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSelectDir
            // 
            this.BtnSelectDir.Location = new System.Drawing.Point(278, 83);
            this.BtnSelectDir.Name = "BtnSelectDir";
            this.BtnSelectDir.Size = new System.Drawing.Size(31, 20);
            this.BtnSelectDir.TabIndex = 6;
            this.BtnSelectDir.Text = "-->";
            this.BtnSelectDir.UseVisualStyleBackColor = true;
            this.BtnSelectDir.Click += new System.EventHandler(this.BtnSelectDir_Click);
            // 
            // cbDocFormat
            // 
            this.cbDocFormat.FormattingEnabled = true;
            this.cbDocFormat.Location = new System.Drawing.Point(90, 19);
            this.cbDocFormat.Name = "cbDocFormat";
            this.cbDocFormat.Size = new System.Drawing.Size(90, 21);
            this.cbDocFormat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Document:";
            // 
            // cbPresFormat
            // 
            this.cbPresFormat.FormattingEnabled = true;
            this.cbPresFormat.Location = new System.Drawing.Point(90, 73);
            this.cbPresFormat.Name = "cbPresFormat";
            this.cbPresFormat.Size = new System.Drawing.Size(90, 21);
            this.cbPresFormat.TabIndex = 8;
            // 
            // cbSprShFormat
            // 
            this.cbSprShFormat.FormattingEnabled = true;
            this.cbSprShFormat.Location = new System.Drawing.Point(90, 46);
            this.cbSprShFormat.Name = "cbSprShFormat";
            this.cbSprShFormat.Size = new System.Drawing.Size(90, 21);
            this.cbSprShFormat.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Presentation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Spreadsheet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password:";
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(107, 43);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(98, 20);
            this.TbPassword.TabIndex = 2;
            // 
            // CbStorePassword
            // 
            this.CbStorePassword.AutoSize = true;
            this.CbStorePassword.Location = new System.Drawing.Point(211, 45);
            this.CbStorePassword.Name = "CbStorePassword";
            this.CbStorePassword.Size = new System.Drawing.Size(77, 17);
            this.CbStorePassword.TabIndex = 9;
            this.CbStorePassword.Text = "Remember";
            this.CbStorePassword.UseVisualStyleBackColor = true;
            this.CbStorePassword.CheckedChanged += new System.EventHandler(this.CbStorePassword_CheckedChanged);
            // 
            // panelProxy
            // 
            this.panelProxy.Controls.Add(this.panelProxy2);
            this.panelProxy.Controls.Add(this.cbDirectConnection);
            this.panelProxy.Enabled = false;
            this.panelProxy.Location = new System.Drawing.Point(0, 33);
            this.panelProxy.Name = "panelProxy";
            this.panelProxy.Size = new System.Drawing.Size(360, 161);
            this.panelProxy.TabIndex = 6;
            // 
            // panelProxy2
            // 
            this.panelProxy2.Controls.Add(this.label12);
            this.panelProxy2.Controls.Add(this.comboProxyHostSource);
            this.panelProxy2.Controls.Add(this.label7);
            this.panelProxy2.Controls.Add(this.panelProxyUserPwd);
            this.panelProxy2.Controls.Add(this.comboProxyAuthType);
            this.panelProxy2.Controls.Add(this.panelProxyHostPort);
            this.panelProxy2.Location = new System.Drawing.Point(3, 31);
            this.panelProxy2.Name = "panelProxy2";
            this.panelProxy2.Size = new System.Drawing.Size(354, 126);
            this.panelProxy2.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Proxy address:";
            // 
            // comboProxyHostSource
            // 
            this.comboProxyHostSource.FormattingEnabled = true;
            this.comboProxyHostSource.Location = new System.Drawing.Point(94, 8);
            this.comboProxyHostSource.Name = "comboProxyHostSource";
            this.comboProxyHostSource.Size = new System.Drawing.Size(155, 21);
            this.comboProxyHostSource.TabIndex = 8;
            this.comboProxyHostSource.SelectedIndexChanged += new System.EventHandler(this.comboProxyAddress_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Auth. type:";
            // 
            // panelProxyUserPwd
            // 
            this.panelProxyUserPwd.Controls.Add(this.tbProxyLogin);
            this.panelProxyUserPwd.Controls.Add(this.label9);
            this.panelProxyUserPwd.Controls.Add(this.label8);
            this.panelProxyUserPwd.Controls.Add(this.tbProxyPassword);
            this.panelProxyUserPwd.Location = new System.Drawing.Point(11, 95);
            this.panelProxyUserPwd.Name = "panelProxyUserPwd";
            this.panelProxyUserPwd.Size = new System.Drawing.Size(339, 27);
            this.panelProxyUserPwd.TabIndex = 7;
            // 
            // tbProxyLogin
            // 
            this.tbProxyLogin.Location = new System.Drawing.Point(67, 3);
            this.tbProxyLogin.Name = "tbProxyLogin";
            this.tbProxyLogin.Size = new System.Drawing.Size(92, 20);
            this.tbProxyLogin.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username:";
            // 
            // tbProxyPassword
            // 
            this.tbProxyPassword.Location = new System.Drawing.Point(239, 3);
            this.tbProxyPassword.Name = "tbProxyPassword";
            this.tbProxyPassword.PasswordChar = '*';
            this.tbProxyPassword.Size = new System.Drawing.Size(92, 20);
            this.tbProxyPassword.TabIndex = 4;
            // 
            // comboProxyAuthType
            // 
            this.comboProxyAuthType.FormattingEnabled = true;
            this.comboProxyAuthType.Location = new System.Drawing.Point(78, 70);
            this.comboProxyAuthType.Name = "comboProxyAuthType";
            this.comboProxyAuthType.Size = new System.Drawing.Size(133, 21);
            this.comboProxyAuthType.TabIndex = 3;
            this.comboProxyAuthType.SelectedIndexChanged += new System.EventHandler(this.comboProxyAuthType_SelectedIndexChanged);
            // 
            // panelProxyHostPort
            // 
            this.panelProxyHostPort.Controls.Add(this.tbProxyHost);
            this.panelProxyHostPort.Controls.Add(this.LabelProxyAddress);
            this.panelProxyHostPort.Controls.Add(this.label10);
            this.panelProxyHostPort.Controls.Add(this.tbProxyPort);
            this.panelProxyHostPort.Location = new System.Drawing.Point(11, 35);
            this.panelProxyHostPort.Name = "panelProxyHostPort";
            this.panelProxyHostPort.Size = new System.Drawing.Size(293, 27);
            this.panelProxyHostPort.TabIndex = 6;
            // 
            // tbProxyHost
            // 
            this.tbProxyHost.Location = new System.Drawing.Point(40, 3);
            this.tbProxyHost.Name = "tbProxyHost";
            this.tbProxyHost.Size = new System.Drawing.Size(141, 20);
            this.tbProxyHost.TabIndex = 2;
            // 
            // LabelProxyAddress
            // 
            this.LabelProxyAddress.AutoSize = true;
            this.LabelProxyAddress.Location = new System.Drawing.Point(2, 6);
            this.LabelProxyAddress.Name = "LabelProxyAddress";
            this.LabelProxyAddress.Size = new System.Drawing.Size(32, 13);
            this.LabelProxyAddress.TabIndex = 0;
            this.LabelProxyAddress.Text = "Host:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Port:";
            // 
            // tbProxyPort
            // 
            this.tbProxyPort.Location = new System.Drawing.Point(222, 3);
            this.tbProxyPort.Name = "tbProxyPort";
            this.tbProxyPort.Size = new System.Drawing.Size(59, 20);
            this.tbProxyPort.TabIndex = 2;
            // 
            // cbDirectConnection
            // 
            this.cbDirectConnection.AutoSize = true;
            this.cbDirectConnection.Location = new System.Drawing.Point(8, 8);
            this.cbDirectConnection.Name = "cbDirectConnection";
            this.cbDirectConnection.Size = new System.Drawing.Size(110, 17);
            this.cbDirectConnection.TabIndex = 8;
            this.cbDirectConnection.Text = "Direct connection";
            this.cbDirectConnection.UseVisualStyleBackColor = true;
            this.cbDirectConnection.CheckedChanged += new System.EventHandler(this.cbDirectConnection_CheckedChanged);
            // 
            // cbSetProxy
            // 
            this.cbSetProxy.AutoSize = true;
            this.cbSetProxy.Location = new System.Drawing.Point(3, 12);
            this.cbSetProxy.Name = "cbSetProxy";
            this.cbSetProxy.Size = new System.Drawing.Size(70, 17);
            this.cbSetProxy.TabIndex = 1;
            this.cbSetProxy.Text = "Set proxy";
            this.cbSetProxy.UseVisualStyleBackColor = true;
            this.cbSetProxy.CheckedChanged += new System.EventHandler(this.CbUseProxy_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(370, 223);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbDisableUpdateCheck);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CbStorePassword);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.TbUsername);
            this.tabPage1.Controls.Add(this.BtnSelectDir);
            this.tabPage1.Controls.Add(this.TbPassword);
            this.tabPage1.Controls.Add(this.TbBackupDir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(362, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbPresFormat);
            this.tabPage2.Controls.Add(this.cbSprShFormat);
            this.tabPage2.Controls.Add(this.cbDocFormat);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(362, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Export format";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelProxy);
            this.tabPage3.Controls.Add(this.cbSetProxy);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(362, 197);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Proxy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbDisableUpdateCheck
            // 
            this.cbDisableUpdateCheck.AutoSize = true;
            this.cbDisableUpdateCheck.Location = new System.Drawing.Point(14, 136);
            this.cbDisableUpdateCheck.Name = "cbDisableUpdateCheck";
            this.cbDisableUpdateCheck.Size = new System.Drawing.Size(130, 17);
            this.cbDisableUpdateCheck.TabIndex = 10;
            this.cbDisableUpdateCheck.Text = "Disable update check";
            this.cbDisableUpdateCheck.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 277);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Config";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.panelProxy.ResumeLayout(false);
            this.panelProxy.PerformLayout();
            this.panelProxy2.ResumeLayout(false);
            this.panelProxy2.PerformLayout();
            this.panelProxyUserPwd.ResumeLayout(false);
            this.panelProxyUserPwd.PerformLayout();
            this.panelProxyHostPort.ResumeLayout(false);
            this.panelProxyHostPort.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.TextBox TbBackupDir;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSelectDir;
        private System.Windows.Forms.ComboBox cbDocFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPresFormat;
        private System.Windows.Forms.ComboBox cbSprShFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.CheckBox CbStorePassword;
        private System.Windows.Forms.CheckBox cbSetProxy;
        private System.Windows.Forms.Label LabelProxyAddress;
        private System.Windows.Forms.TextBox tbProxyHost;
        private System.Windows.Forms.ComboBox comboProxyAuthType;
        private System.Windows.Forms.TextBox tbProxyPassword;
        private System.Windows.Forms.TextBox tbProxyLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProxyPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelProxy;
        private System.Windows.Forms.Panel panelProxyHostPort;
        private System.Windows.Forms.Panel panelProxyUserPwd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelProxy2;
        private System.Windows.Forms.CheckBox cbDirectConnection;
        private System.Windows.Forms.ComboBox comboProxyHostSource;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbDisableUpdateCheck;
    }
}