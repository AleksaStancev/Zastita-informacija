
using System;

namespace ZI_Prvi_Deo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_PlainText = new System.Windows.Forms.TextBox();
            this.lb_PlainText = new System.Windows.Forms.Label();
            this.lb_EncryptedFileSourceOrDestination = new System.Windows.Forms.Label();
            this.lb_Key = new System.Windows.Forms.Label();
            this.tb_Key = new System.Windows.Forms.TextBox();
            this.btn_LoadPlainTextFromFile = new System.Windows.Forms.Button();
            this.btn_SavePlainTextToFile = new System.Windows.Forms.Button();
            this.btn_LoadKeyFromFIle = new System.Windows.Forms.Button();
            this.btn_SaveKeyToFile = new System.Windows.Forms.Button();
            this.btn_EncryptDecrypt = new System.Windows.Forms.Button();
            this.rb_Encrypt = new System.Windows.Forms.RadioButton();
            this.rb_Decryption = new System.Windows.Forms.RadioButton();
            this.btn_FileSystemWatcher = new System.Windows.Forms.Button();
            this.lb_EncryptedFileFolderOrPath = new System.Windows.Forms.Label();
            this.btn_SelectEncryptedFileFolderOrPath = new System.Windows.Forms.Button();
            this.tb_EncryptedFileName = new System.Windows.Forms.TextBox();
            this.lb_EncryptedFileName = new System.Windows.Forms.Label();
            this.cb_CryptoAlgorithm = new System.Windows.Forms.ComboBox();
            this.lb_SelectAlgorithm = new System.Windows.Forms.Label();
            this.nud_Crypto_Settings = new System.Windows.Forms.NumericUpDown();
            this.lb_Crypto_Settings = new System.Windows.Forms.Label();
            this.lb_CryptoMode = new System.Windows.Forms.Label();
            this.cb_CryptoMode = new System.Windows.Forms.ComboBox();
            this.lb_HashAlgorithm = new System.Windows.Forms.Label();
            this.cb_HashAlgorithm = new System.Windows.Forms.ComboBox();
            this.lb_IV = new System.Windows.Forms.Label();
            this.tb_Initialization_vector = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Crypto_Settings)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_PlainText
            // 
            this.tb_PlainText.Location = new System.Drawing.Point(15, 224);
            this.tb_PlainText.Multiline = true;
            this.tb_PlainText.Name = "tb_PlainText";
            this.tb_PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_PlainText.Size = new System.Drawing.Size(776, 400);
            this.tb_PlainText.TabIndex = 1;
            this.tb_PlainText.TextChanged += new System.EventHandler(this.Tb_PlainText_TextChanged);
            // 
            // lb_PlainText
            // 
            this.lb_PlainText.AutoSize = true;
            this.lb_PlainText.Location = new System.Drawing.Point(366, 201);
            this.lb_PlainText.Name = "lb_PlainText";
            this.lb_PlainText.Size = new System.Drawing.Size(73, 20);
            this.lb_PlainText.TabIndex = 3;
            this.lb_PlainText.Text = "Plain text:";
            // 
            // lb_EncryptedFileSourceOrDestination
            // 
            this.lb_EncryptedFileSourceOrDestination.AutoSize = true;
            this.lb_EncryptedFileSourceOrDestination.Location = new System.Drawing.Point(65, 767);
            this.lb_EncryptedFileSourceOrDestination.Name = "lb_EncryptedFileSourceOrDestination";
            this.lb_EncryptedFileSourceOrDestination.Size = new System.Drawing.Size(181, 20);
            this.lb_EncryptedFileSourceOrDestination.TabIndex = 4;
            this.lb_EncryptedFileSourceOrDestination.Text = "Encrypted file destination:";
            // 
            // lb_Key
            // 
            this.lb_Key.AutoSize = true;
            this.lb_Key.Location = new System.Drawing.Point(17, 679);
            this.lb_Key.Name = "lb_Key";
            this.lb_Key.Size = new System.Drawing.Size(36, 20);
            this.lb_Key.TabIndex = 7;
            this.lb_Key.Text = "Key:";
            // 
            // tb_Key
            // 
            this.tb_Key.Location = new System.Drawing.Point(65, 676);
            this.tb_Key.MaxLength = 256;
            this.tb_Key.Name = "tb_Key";
            this.tb_Key.Size = new System.Drawing.Size(728, 27);
            this.tb_Key.TabIndex = 8;
            this.tb_Key.TextChanged += new System.EventHandler(this.Tb_Key_TextChanged);
            // 
            // btn_LoadPlainTextFromFile
            // 
            this.btn_LoadPlainTextFromFile.Location = new System.Drawing.Point(15, 171);
            this.btn_LoadPlainTextFromFile.Name = "btn_LoadPlainTextFromFile";
            this.btn_LoadPlainTextFromFile.Size = new System.Drawing.Size(140, 50);
            this.btn_LoadPlainTextFromFile.TabIndex = 9;
            this.btn_LoadPlainTextFromFile.Text = "Load plain text from file";
            this.btn_LoadPlainTextFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadPlainTextFromFile.Click += new System.EventHandler(this.Btn_LoadPlainTextFromFile_Click);
            // 
            // btn_SavePlainTextToFile
            // 
            this.btn_SavePlainTextToFile.Enabled = false;
            this.btn_SavePlainTextToFile.Location = new System.Drawing.Point(651, 168);
            this.btn_SavePlainTextToFile.Name = "btn_SavePlainTextToFile";
            this.btn_SavePlainTextToFile.Size = new System.Drawing.Size(140, 50);
            this.btn_SavePlainTextToFile.TabIndex = 10;
            this.btn_SavePlainTextToFile.Text = "Save plain text to file";
            this.btn_SavePlainTextToFile.UseVisualStyleBackColor = true;
            this.btn_SavePlainTextToFile.Click += new System.EventHandler(this.Btn_SavePlainTextToFile_Click);
            // 
            // btn_LoadKeyFromFIle
            // 
            this.btn_LoadKeyFromFIle.Location = new System.Drawing.Point(65, 718);
            this.btn_LoadKeyFromFIle.Name = "btn_LoadKeyFromFIle";
            this.btn_LoadKeyFromFIle.Size = new System.Drawing.Size(350, 30);
            this.btn_LoadKeyFromFIle.TabIndex = 13;
            this.btn_LoadKeyFromFIle.Text = "Load key from file";
            this.btn_LoadKeyFromFIle.UseVisualStyleBackColor = true;
            this.btn_LoadKeyFromFIle.Click += new System.EventHandler(this.Btn_LoadKeyFromFIle_Click);
            // 
            // btn_SaveKeyToFile
            // 
            this.btn_SaveKeyToFile.Location = new System.Drawing.Point(443, 717);
            this.btn_SaveKeyToFile.Name = "btn_SaveKeyToFile";
            this.btn_SaveKeyToFile.Size = new System.Drawing.Size(350, 30);
            this.btn_SaveKeyToFile.TabIndex = 14;
            this.btn_SaveKeyToFile.Text = "Save key to file";
            this.btn_SaveKeyToFile.UseVisualStyleBackColor = true;
            this.btn_SaveKeyToFile.Click += new System.EventHandler(this.Btn_StoreKeyToFile_Click);
            // 
            // btn_EncryptDecrypt
            // 
            this.btn_EncryptDecrypt.Enabled = false;
            this.btn_EncryptDecrypt.Location = new System.Drawing.Point(290, 830);
            this.btn_EncryptDecrypt.Name = "btn_EncryptDecrypt";
            this.btn_EncryptDecrypt.Size = new System.Drawing.Size(240, 70);
            this.btn_EncryptDecrypt.TabIndex = 15;
            this.btn_EncryptDecrypt.Text = "Encrypt";
            this.btn_EncryptDecrypt.UseVisualStyleBackColor = true;
            this.btn_EncryptDecrypt.Click += new System.EventHandler(this.Btn_EncryptDecrypt_Click);
            // 
            // rb_Encrypt
            // 
            this.rb_Encrypt.AutoSize = true;
            this.rb_Encrypt.Checked = true;
            this.rb_Encrypt.Location = new System.Drawing.Point(182, 63);
            this.rb_Encrypt.Name = "rb_Encrypt";
            this.rb_Encrypt.Size = new System.Drawing.Size(100, 24);
            this.rb_Encrypt.TabIndex = 17;
            this.rb_Encrypt.TabStop = true;
            this.rb_Encrypt.Text = "Encryption";
            this.rb_Encrypt.UseVisualStyleBackColor = true;
            this.rb_Encrypt.CheckedChanged += new System.EventHandler(this.Rb_Encrypt_CheckedChanged);
            // 
            // rb_Decryption
            // 
            this.rb_Decryption.AutoSize = true;
            this.rb_Decryption.Location = new System.Drawing.Point(526, 63);
            this.rb_Decryption.Name = "rb_Decryption";
            this.rb_Decryption.Size = new System.Drawing.Size(103, 24);
            this.rb_Decryption.TabIndex = 18;
            this.rb_Decryption.Text = "Decryption";
            this.rb_Decryption.UseVisualStyleBackColor = true;
            this.rb_Decryption.CheckedChanged += new System.EventHandler(this.Rb_Decryption_CheckedChanged);
            // 
            // btn_FileSystemWatcher
            // 
            this.btn_FileSystemWatcher.Location = new System.Drawing.Point(309, 4);
            this.btn_FileSystemWatcher.Name = "btn_FileSystemWatcher";
            this.btn_FileSystemWatcher.Size = new System.Drawing.Size(194, 32);
            this.btn_FileSystemWatcher.TabIndex = 19;
            this.btn_FileSystemWatcher.Text = "FileSystemWatcher";
            this.btn_FileSystemWatcher.UseVisualStyleBackColor = true;
            this.btn_FileSystemWatcher.Click += new System.EventHandler(this.Btn_FileSystemWatcher_Click);
            // 
            // lb_EncryptedFileFolderOrPath
            // 
            this.lb_EncryptedFileFolderOrPath.AutoSize = true;
            this.lb_EncryptedFileFolderOrPath.Location = new System.Drawing.Point(80, 800);
            this.lb_EncryptedFileFolderOrPath.Name = "lb_EncryptedFileFolderOrPath";
            this.lb_EncryptedFileFolderOrPath.Size = new System.Drawing.Size(0, 20);
            this.lb_EncryptedFileFolderOrPath.TabIndex = 20;
            // 
            // btn_SelectEncryptedFileFolderOrPath
            // 
            this.btn_SelectEncryptedFileFolderOrPath.Location = new System.Drawing.Point(264, 761);
            this.btn_SelectEncryptedFileFolderOrPath.Name = "btn_SelectEncryptedFileFolderOrPath";
            this.btn_SelectEncryptedFileFolderOrPath.Size = new System.Drawing.Size(108, 32);
            this.btn_SelectEncryptedFileFolderOrPath.TabIndex = 21;
            this.btn_SelectEncryptedFileFolderOrPath.Text = "Select";
            this.btn_SelectEncryptedFileFolderOrPath.UseVisualStyleBackColor = true;
            this.btn_SelectEncryptedFileFolderOrPath.Click += new System.EventHandler(this.Btn_SelectEncryptedFileFolderOrPath_Click);
            // 
            // tb_EncryptedFileName
            // 
            this.tb_EncryptedFileName.Location = new System.Drawing.Point(593, 761);
            this.tb_EncryptedFileName.MaxLength = 15;
            this.tb_EncryptedFileName.Name = "tb_EncryptedFileName";
            this.tb_EncryptedFileName.Size = new System.Drawing.Size(200, 27);
            this.tb_EncryptedFileName.TabIndex = 22;
            this.tb_EncryptedFileName.TextChanged += new System.EventHandler(this.Tb_EncryptedFileName_TextChanged);
            // 
            // lb_EncryptedFileName
            // 
            this.lb_EncryptedFileName.AutoSize = true;
            this.lb_EncryptedFileName.Location = new System.Drawing.Point(443, 767);
            this.lb_EncryptedFileName.Name = "lb_EncryptedFileName";
            this.lb_EncryptedFileName.Size = new System.Drawing.Size(144, 20);
            this.lb_EncryptedFileName.TabIndex = 23;
            this.lb_EncryptedFileName.Text = "Encrypted file name:";
            // 
            // cb_CryptoAlgorithm
            // 
            this.cb_CryptoAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CryptoAlgorithm.FormattingEnabled = true;
            this.cb_CryptoAlgorithm.Items.AddRange(new object[] {
            "RC4",
            "XTEA"});
            this.cb_CryptoAlgorithm.Location = new System.Drawing.Point(309, 62);
            this.cb_CryptoAlgorithm.Name = "cb_CryptoAlgorithm";
            this.cb_CryptoAlgorithm.Size = new System.Drawing.Size(196, 28);
            this.cb_CryptoAlgorithm.TabIndex = 24;
            this.cb_CryptoAlgorithm.SelectedIndexChanged += new System.EventHandler(this.Cb_CryptoAlghoritm_SelectedIndexChanged);
            // 
            // lb_SelectAlgorithm
            // 
            this.lb_SelectAlgorithm.AutoSize = true;
            this.lb_SelectAlgorithm.Location = new System.Drawing.Point(327, 39);
            this.lb_SelectAlgorithm.Name = "lb_SelectAlgorithm";
            this.lb_SelectAlgorithm.Size = new System.Drawing.Size(167, 20);
            this.lb_SelectAlgorithm.TabIndex = 25;
            this.lb_SelectAlgorithm.Text = "Select crypto algorithm:";
            // 
            // nud_Crypto_Settings
            // 
            this.nud_Crypto_Settings.Location = new System.Drawing.Point(353, 636);
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
            this.nud_Crypto_Settings.TabIndex = 26;
            this.nud_Crypto_Settings.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nud_Crypto_Settings.ValueChanged += new System.EventHandler(this.Nud_Crypto_Settings_ValueChanged);
            // 
            // lb_Crypto_Settings
            // 
            this.lb_Crypto_Settings.AutoSize = true;
            this.lb_Crypto_Settings.Location = new System.Drawing.Point(264, 638);
            this.lb_Crypto_Settings.Name = "lb_Crypto_Settings";
            this.lb_Crypto_Settings.Size = new System.Drawing.Size(82, 20);
            this.lb_Crypto_Settings.TabIndex = 27;
            this.lb_Crypto_Settings.Text = "Key length:";
            // 
            // lb_CryptoMode
            // 
            this.lb_CryptoMode.AutoSize = true;
            this.lb_CryptoMode.Location = new System.Drawing.Point(345, 93);
            this.lb_CryptoMode.Name = "lb_CryptoMode";
            this.lb_CryptoMode.Size = new System.Drawing.Size(138, 20);
            this.lb_CryptoMode.TabIndex = 28;
            this.lb_CryptoMode.Text = "Mode of operation:";
            // 
            // cb_CryptoMode
            // 
            this.cb_CryptoMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CryptoMode.FormattingEnabled = true;
            this.cb_CryptoMode.Items.AddRange(new object[] {
            "None",
            "CTR"});
            this.cb_CryptoMode.Location = new System.Drawing.Point(309, 116);
            this.cb_CryptoMode.Name = "cb_CryptoMode";
            this.cb_CryptoMode.Size = new System.Drawing.Size(196, 28);
            this.cb_CryptoMode.TabIndex = 29;
            this.cb_CryptoMode.SelectedIndexChanged += new System.EventHandler(this.Cb_CryptoMode_SelectedIndexChanged);
            // 
            // lb_HashAlgorithm
            // 
            this.lb_HashAlgorithm.AutoSize = true;
            this.lb_HashAlgorithm.Location = new System.Drawing.Point(328, 147);
            this.lb_HashAlgorithm.Name = "lb_HashAlgorithm";
            this.lb_HashAlgorithm.Size = new System.Drawing.Size(155, 20);
            this.lb_HashAlgorithm.TabIndex = 30;
            this.lb_HashAlgorithm.Text = "Select hash algorithm:";
            // 
            // cb_HashAlgorithm
            // 
            this.cb_HashAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_HashAlgorithm.FormattingEnabled = true;
            this.cb_HashAlgorithm.Items.AddRange(new object[] {
            "None",
            "Tiger"});
            this.cb_HashAlgorithm.Location = new System.Drawing.Point(309, 170);
            this.cb_HashAlgorithm.Name = "cb_HashAlgorithm";
            this.cb_HashAlgorithm.Size = new System.Drawing.Size(196, 28);
            this.cb_HashAlgorithm.TabIndex = 31;
            this.cb_HashAlgorithm.SelectedIndexChanged += new System.EventHandler(this.Cb_HashAlgorithm_SelectedIndexChanged);
            // 
            // lb_IV
            // 
            this.lb_IV.AutoSize = true;
            this.lb_IV.Location = new System.Drawing.Point(526, 93);
            this.lb_IV.Name = "lb_IV";
            this.lb_IV.Size = new System.Drawing.Size(139, 20);
            this.lb_IV.TabIndex = 32;
            this.lb_IV.Text = "Initialization vector:";
            this.lb_IV.Visible = false;
            // 
            // tb_Initialization_vector
            // 
            this.tb_Initialization_vector.Location = new System.Drawing.Point(526, 117);
            this.tb_Initialization_vector.MaxLength = 4;
            this.tb_Initialization_vector.Name = "tb_Initialization_vector";
            this.tb_Initialization_vector.Size = new System.Drawing.Size(139, 27);
            this.tb_Initialization_vector.TabIndex = 33;
            this.tb_Initialization_vector.Visible = false;
            this.tb_Initialization_vector.TextChanged += new System.EventHandler(this.Tb_Initialization_vector_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 913);
            this.Controls.Add(this.tb_Initialization_vector);
            this.Controls.Add(this.lb_IV);
            this.Controls.Add(this.cb_HashAlgorithm);
            this.Controls.Add(this.lb_HashAlgorithm);
            this.Controls.Add(this.cb_CryptoMode);
            this.Controls.Add(this.lb_CryptoMode);
            this.Controls.Add(this.lb_Crypto_Settings);
            this.Controls.Add(this.nud_Crypto_Settings);
            this.Controls.Add(this.lb_SelectAlgorithm);
            this.Controls.Add(this.cb_CryptoAlgorithm);
            this.Controls.Add(this.lb_EncryptedFileName);
            this.Controls.Add(this.tb_EncryptedFileName);
            this.Controls.Add(this.btn_SelectEncryptedFileFolderOrPath);
            this.Controls.Add(this.lb_EncryptedFileFolderOrPath);
            this.Controls.Add(this.btn_FileSystemWatcher);
            this.Controls.Add(this.rb_Decryption);
            this.Controls.Add(this.rb_Encrypt);
            this.Controls.Add(this.btn_EncryptDecrypt);
            this.Controls.Add(this.btn_SaveKeyToFile);
            this.Controls.Add(this.btn_LoadKeyFromFIle);
            this.Controls.Add(this.btn_SavePlainTextToFile);
            this.Controls.Add(this.btn_LoadPlainTextFromFile);
            this.Controls.Add(this.tb_Key);
            this.Controls.Add(this.lb_Key);
            this.Controls.Add(this.lb_EncryptedFileSourceOrDestination);
            this.Controls.Add(this.lb_PlainText);
            this.Controls.Add(this.tb_PlainText);
            this.Name = "MainForm";
            this.Text = "ZI";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Crypto_Settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_PlainText;
        private System.Windows.Forms.Label lb_EncryptedFileSourceOrDestination;
        private System.Windows.Forms.Label lb_PlainText;
        private System.Windows.Forms.Label lb_Key;
        private System.Windows.Forms.TextBox tb_Key;
        private System.Windows.Forms.Button btn_LoadPlainTextFromFile;
        private System.Windows.Forms.Button btn_SavePlainTextToFile;
        private System.Windows.Forms.Button btn_LoadKeyFromFIle;
        private System.Windows.Forms.Button btn_SaveKeyToFile;
        private System.Windows.Forms.Button btn_EncryptDecrypt;
        private System.Windows.Forms.RadioButton rb_Decryption;
        private System.Windows.Forms.RadioButton rb_Encrypt;
        private System.Windows.Forms.Button btn_FileSystemWatcher;
        private System.Windows.Forms.Label lb_EncryptedFileFolderOrPath;
        private System.Windows.Forms.Label lb_EncryptedFileName;
        private System.Windows.Forms.TextBox tb_EncryptedFileName;
        private System.Windows.Forms.Button btn_SelectEncryptedFileFolderOrPath;
        private System.Windows.Forms.ComboBox cb_CryptoAlgorithm;
        private System.Windows.Forms.Label lb_SelectAlgorithm;
        private System.Windows.Forms.NumericUpDown nud_Crypto_Settings;
        private System.Windows.Forms.Label lb_Crypto_Settings;
        private System.Windows.Forms.Label lb_CryptoMode;
        private System.Windows.Forms.ComboBox cb_CryptoMode;
        private System.Windows.Forms.Label lb_HashAlgorithm;
        private System.Windows.Forms.ComboBox cb_HashAlgorithm;
        private System.Windows.Forms.Label lb_IV;
        private System.Windows.Forms.TextBox tb_Initialization_vector;
    }
}

