
namespace ZI_Prvi_Deo
{
    partial class FSWForm
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_FileWatcherDestinationPath = new System.Windows.Forms.Label();
            this.lb_FileWatcherSourcePath = new System.Windows.Forms.Label();
            this.lb_FileWatcherDestionation = new System.Windows.Forms.Label();
            this.lb_FileWatcherSource = new System.Windows.Forms.Label();
            this.btn_FileWatcherDestination = new System.Windows.Forms.Button();
            this.btn_FileWatcherSource = new System.Windows.Forms.Button();
            this.btn_SaveKeyToFile = new System.Windows.Forms.Button();
            this.btn_LoadKeyFromFIle = new System.Windows.Forms.Button();
            this.tb_Key = new System.Windows.Forms.TextBox();
            this.lb_Key = new System.Windows.Forms.Label();
            this.btn_FileSystemWatcherSwitch = new System.Windows.Forms.Button();
            this.lb_SelectAlgorithm = new System.Windows.Forms.Label();
            this.cb_CryptoAlhorithm = new System.Windows.Forms.ComboBox();
            this.lb_Crypto_Settings = new System.Windows.Forms.Label();
            this.nud_Crypto_Settings = new System.Windows.Forms.NumericUpDown();
            this.cb_HashAlgorithm = new System.Windows.Forms.ComboBox();
            this.lb_HashAlgorithm = new System.Windows.Forms.Label();
            this.cb_CryptoMode = new System.Windows.Forms.ComboBox();
            this.lb_CryptoMode = new System.Windows.Forms.Label();
            this.tb_Initialization_vector = new System.Windows.Forms.TextBox();
            this.lb_IV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Crypto_Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_FileWatcherDestinationPath
            // 
            this.lb_FileWatcherDestinationPath.AutoSize = true;
            this.lb_FileWatcherDestinationPath.Location = new System.Drawing.Point(18, 191);
            this.lb_FileWatcherDestinationPath.Name = "lb_FileWatcherDestinationPath";
            this.lb_FileWatcherDestinationPath.Size = new System.Drawing.Size(0, 20);
            this.lb_FileWatcherDestinationPath.TabIndex = 28;
            // 
            // lb_FileWatcherSourcePath
            // 
            this.lb_FileWatcherSourcePath.AutoSize = true;
            this.lb_FileWatcherSourcePath.Location = new System.Drawing.Point(23, 75);
            this.lb_FileWatcherSourcePath.Name = "lb_FileWatcherSourcePath";
            this.lb_FileWatcherSourcePath.Size = new System.Drawing.Size(0, 20);
            this.lb_FileWatcherSourcePath.TabIndex = 27;
            // 
            // lb_FileWatcherDestionation
            // 
            this.lb_FileWatcherDestionation.AutoSize = true;
            this.lb_FileWatcherDestionation.Location = new System.Drawing.Point(12, 107);
            this.lb_FileWatcherDestionation.Name = "lb_FileWatcherDestionation";
            this.lb_FileWatcherDestionation.Size = new System.Drawing.Size(121, 20);
            this.lb_FileWatcherDestionation.TabIndex = 26;
            this.lb_FileWatcherDestionation.Text = "FSW Destination:";
            // 
            // lb_FileWatcherSource
            // 
            this.lb_FileWatcherSource.AutoSize = true;
            this.lb_FileWatcherSource.Location = new System.Drawing.Point(12, 55);
            this.lb_FileWatcherSource.Name = "lb_FileWatcherSource";
            this.lb_FileWatcherSource.Size = new System.Drawing.Size(90, 20);
            this.lb_FileWatcherSource.TabIndex = 25;
            this.lb_FileWatcherSource.Text = "FSW Source:";
            // 
            // btn_FileWatcherDestination
            // 
            this.btn_FileWatcherDestination.Location = new System.Drawing.Point(139, 97);
            this.btn_FileWatcherDestination.Name = "btn_FileWatcherDestination";
            this.btn_FileWatcherDestination.Size = new System.Drawing.Size(125, 30);
            this.btn_FileWatcherDestination.TabIndex = 24;
            this.btn_FileWatcherDestination.Text = "Select";
            this.btn_FileWatcherDestination.UseVisualStyleBackColor = true;
            this.btn_FileWatcherDestination.Click += new System.EventHandler(this.Btn_FileWatcherDestination_Click);
            // 
            // btn_FileWatcherSource
            // 
            this.btn_FileWatcherSource.Location = new System.Drawing.Point(138, 45);
            this.btn_FileWatcherSource.Name = "btn_FileWatcherSource";
            this.btn_FileWatcherSource.Size = new System.Drawing.Size(125, 30);
            this.btn_FileWatcherSource.TabIndex = 22;
            this.btn_FileWatcherSource.Text = "Select";
            this.btn_FileWatcherSource.UseVisualStyleBackColor = true;
            this.btn_FileWatcherSource.Click += new System.EventHandler(this.Btn_FileWatcherSource_Click);
            // 
            // btn_SaveKeyToFile
            // 
            this.btn_SaveKeyToFile.Enabled = false;
            this.btn_SaveKeyToFile.Location = new System.Drawing.Point(433, 270);
            this.btn_SaveKeyToFile.Name = "btn_SaveKeyToFile";
            this.btn_SaveKeyToFile.Size = new System.Drawing.Size(350, 30);
            this.btn_SaveKeyToFile.TabIndex = 32;
            this.btn_SaveKeyToFile.Text = "Save key to file";
            this.btn_SaveKeyToFile.UseVisualStyleBackColor = true;
            this.btn_SaveKeyToFile.Click += new System.EventHandler(this.Btn_SaveKeyToFile_Click);
            // 
            // btn_LoadKeyFromFIle
            // 
            this.btn_LoadKeyFromFIle.Location = new System.Drawing.Point(55, 271);
            this.btn_LoadKeyFromFIle.Name = "btn_LoadKeyFromFIle";
            this.btn_LoadKeyFromFIle.Size = new System.Drawing.Size(350, 30);
            this.btn_LoadKeyFromFIle.TabIndex = 31;
            this.btn_LoadKeyFromFIle.Text = "Load key from file";
            this.btn_LoadKeyFromFIle.UseVisualStyleBackColor = true;
            this.btn_LoadKeyFromFIle.Click += new System.EventHandler(this.Btn_LoadKeyFromFIle_Click);
            // 
            // tb_Key
            // 
            this.tb_Key.Location = new System.Drawing.Point(55, 229);
            this.tb_Key.MaxLength = 256;
            this.tb_Key.Name = "tb_Key";
            this.tb_Key.Size = new System.Drawing.Size(728, 27);
            this.tb_Key.TabIndex = 30;
            this.tb_Key.TextChanged += new System.EventHandler(this.Tb_Key_TextChanged);
            // 
            // lb_Key
            // 
            this.lb_Key.AutoSize = true;
            this.lb_Key.Location = new System.Drawing.Point(7, 232);
            this.lb_Key.Name = "lb_Key";
            this.lb_Key.Size = new System.Drawing.Size(36, 20);
            this.lb_Key.TabIndex = 29;
            this.lb_Key.Text = "Key:";
            // 
            // btn_FileSystemWatcherSwitch
            // 
            this.btn_FileSystemWatcherSwitch.Enabled = false;
            this.btn_FileSystemWatcherSwitch.Location = new System.Drawing.Point(329, 325);
            this.btn_FileSystemWatcherSwitch.Name = "btn_FileSystemWatcherSwitch";
            this.btn_FileSystemWatcherSwitch.Size = new System.Drawing.Size(170, 29);
            this.btn_FileSystemWatcherSwitch.TabIndex = 33;
            this.btn_FileSystemWatcherSwitch.Text = "Turn FSW on";
            this.btn_FileSystemWatcherSwitch.UseVisualStyleBackColor = true;
            this.btn_FileSystemWatcherSwitch.Click += new System.EventHandler(this.Btn_FileSystemWatcherSwitch_Click);
            // 
            // lb_SelectAlgorithm
            // 
            this.lb_SelectAlgorithm.AutoSize = true;
            this.lb_SelectAlgorithm.Location = new System.Drawing.Point(334, 9);
            this.lb_SelectAlgorithm.Name = "lb_SelectAlgorithm";
            this.lb_SelectAlgorithm.Size = new System.Drawing.Size(121, 20);
            this.lb_SelectAlgorithm.TabIndex = 35;
            this.lb_SelectAlgorithm.Text = "Select algorithm:";
            // 
            // cb_CryptoAlhorithm
            // 
            this.cb_CryptoAlhorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CryptoAlhorithm.FormattingEnabled = true;
            this.cb_CryptoAlhorithm.Items.AddRange(new object[] {
            "RC4",
            "XTEA"});
            this.cb_CryptoAlhorithm.Location = new System.Drawing.Point(303, 32);
            this.cb_CryptoAlhorithm.Name = "cb_CryptoAlhorithm";
            this.cb_CryptoAlhorithm.Size = new System.Drawing.Size(196, 28);
            this.cb_CryptoAlhorithm.TabIndex = 34;
            this.cb_CryptoAlhorithm.SelectedIndexChanged += new System.EventHandler(this.Cb_CryptoAlghoritm_SelectedIndexChanged);
            // 
            // lb_Crypto_Settings
            // 
            this.lb_Crypto_Settings.AutoSize = true;
            this.lb_Crypto_Settings.Location = new System.Drawing.Point(277, 199);
            this.lb_Crypto_Settings.Name = "lb_Crypto_Settings";
            this.lb_Crypto_Settings.Size = new System.Drawing.Size(82, 20);
            this.lb_Crypto_Settings.TabIndex = 37;
            this.lb_Crypto_Settings.Text = "Key length:";
            // 
            // nud_Crypto_Settings
            // 
            this.nud_Crypto_Settings.Location = new System.Drawing.Point(365, 197);
            this.nud_Crypto_Settings.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nud_Crypto_Settings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Crypto_Settings.Name = "nud_Crypto_Settings";
            this.nud_Crypto_Settings.Size = new System.Drawing.Size(150, 27);
            this.nud_Crypto_Settings.TabIndex = 36;
            this.nud_Crypto_Settings.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nud_Crypto_Settings.ValueChanged += new System.EventHandler(this.Nud_Crypto_Settings_ValueChanged);
            // 
            // cb_HashAlgorithm
            // 
            this.cb_HashAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_HashAlgorithm.FormattingEnabled = true;
            this.cb_HashAlgorithm.Items.AddRange(new object[] {
            "None",
            "Tiger"});
            this.cb_HashAlgorithm.Location = new System.Drawing.Point(303, 140);
            this.cb_HashAlgorithm.Name = "cb_HashAlgorithm";
            this.cb_HashAlgorithm.Size = new System.Drawing.Size(196, 28);
            this.cb_HashAlgorithm.TabIndex = 42;
            // 
            // lb_HashAlgorithm
            // 
            this.lb_HashAlgorithm.AutoSize = true;
            this.lb_HashAlgorithm.Location = new System.Drawing.Point(322, 117);
            this.lb_HashAlgorithm.Name = "lb_HashAlgorithm";
            this.lb_HashAlgorithm.Size = new System.Drawing.Size(155, 20);
            this.lb_HashAlgorithm.TabIndex = 41;
            this.lb_HashAlgorithm.Text = "Select hash algorithm:";
            // 
            // cb_CryptoMode
            // 
            this.cb_CryptoMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CryptoMode.FormattingEnabled = true;
            this.cb_CryptoMode.Items.AddRange(new object[] {
            "None",
            "CTR"});
            this.cb_CryptoMode.Location = new System.Drawing.Point(303, 86);
            this.cb_CryptoMode.Name = "cb_CryptoMode";
            this.cb_CryptoMode.Size = new System.Drawing.Size(196, 28);
            this.cb_CryptoMode.TabIndex = 40;
            this.cb_CryptoMode.SelectedIndexChanged += new System.EventHandler(this.Cb_CryptoMode_SelectedIndexChanged);
            // 
            // lb_CryptoMode
            // 
            this.lb_CryptoMode.AutoSize = true;
            this.lb_CryptoMode.Location = new System.Drawing.Point(339, 63);
            this.lb_CryptoMode.Name = "lb_CryptoMode";
            this.lb_CryptoMode.Size = new System.Drawing.Size(138, 20);
            this.lb_CryptoMode.TabIndex = 39;
            this.lb_CryptoMode.Text = "Mode of operation:";
            // 
            // tb_Initialization_vector
            // 
            this.tb_Initialization_vector.Location = new System.Drawing.Point(522, 87);
            this.tb_Initialization_vector.MaxLength = 4;
            this.tb_Initialization_vector.Name = "tb_Initialization_vector";
            this.tb_Initialization_vector.Size = new System.Drawing.Size(139, 27);
            this.tb_Initialization_vector.TabIndex = 44;
            this.tb_Initialization_vector.Visible = false;
            // 
            // lb_IV
            // 
            this.lb_IV.AutoSize = true;
            this.lb_IV.Location = new System.Drawing.Point(522, 63);
            this.lb_IV.Name = "lb_IV";
            this.lb_IV.Size = new System.Drawing.Size(139, 20);
            this.lb_IV.TabIndex = 43;
            this.lb_IV.Text = "Initialization vector:";
            this.lb_IV.Visible = false;
            // 
            // FSWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.tb_Initialization_vector);
            this.Controls.Add(this.lb_IV);
            this.Controls.Add(this.cb_HashAlgorithm);
            this.Controls.Add(this.lb_HashAlgorithm);
            this.Controls.Add(this.cb_CryptoMode);
            this.Controls.Add(this.lb_CryptoMode);
            this.Controls.Add(this.lb_Crypto_Settings);
            this.Controls.Add(this.nud_Crypto_Settings);
            this.Controls.Add(this.lb_SelectAlgorithm);
            this.Controls.Add(this.cb_CryptoAlhorithm);
            this.Controls.Add(this.btn_FileSystemWatcherSwitch);
            this.Controls.Add(this.btn_SaveKeyToFile);
            this.Controls.Add(this.btn_LoadKeyFromFIle);
            this.Controls.Add(this.tb_Key);
            this.Controls.Add(this.lb_Key);
            this.Controls.Add(this.lb_FileWatcherDestinationPath);
            this.Controls.Add(this.lb_FileWatcherSourcePath);
            this.Controls.Add(this.lb_FileWatcherDestionation);
            this.Controls.Add(this.lb_FileWatcherSource);
            this.Controls.Add(this.btn_FileWatcherDestination);
            this.Controls.Add(this.btn_FileWatcherSource);
            this.Enabled = false;
            this.Name = "FSWForm";
            this.Text = "FileSystemWatcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FSWForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Crypto_Settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_FileWatcherDestinationPath;
        private System.Windows.Forms.Label lb_FileWatcherSourcePath;
        private System.Windows.Forms.Label lb_FileWatcherDestionation;
        private System.Windows.Forms.Label lb_FileWatcherSource;
        private System.Windows.Forms.Button btn_FileWatcherDestination;
        private System.Windows.Forms.Button btn_FileWatcherSource;
        private System.Windows.Forms.Button btn_SaveKeyToFile;
        private System.Windows.Forms.Button btn_LoadKeyFromFIle;
        private System.Windows.Forms.TextBox tb_Key;
        private System.Windows.Forms.Label lb_Key;
        private System.Windows.Forms.Button btn_FileSystemWatcherSwitch;
        private System.Windows.Forms.Label lb_SelectAlgorithm;
        private System.Windows.Forms.ComboBox cb_CryptoAlhorithm;
        private System.Windows.Forms.Label lb_Crypto_Settings;
        private System.Windows.Forms.NumericUpDown nud_Crypto_Settings;
        private System.Windows.Forms.ComboBox cb_HashAlgorithm;
        private System.Windows.Forms.Label lb_HashAlgorithm;
        private System.Windows.Forms.ComboBox cb_CryptoMode;
        private System.Windows.Forms.Label lb_CryptoMode;
        private System.Windows.Forms.TextBox tb_Initialization_vector;
        private System.Windows.Forms.Label lb_IV;
    }
}