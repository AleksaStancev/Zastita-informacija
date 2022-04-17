using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ZI_Prvi_Deo
{
    public partial class FSWForm : Form
    {
        private int minKeyLen;
        private readonly CryptoContext cryptoContext;
        private readonly CryptoFSW fsw;
        public FSWForm()
        {
            InitializeComponent();
            cryptoContext = new CryptoContext(new RC4(256));
            fsw = new CryptoFSW(cryptoContext);
            cb_CryptoAlhorithm.SelectedIndex = 0;
            cb_CryptoMode.SelectedIndex = 0;
            cb_HashAlgorithm.SelectedIndex = 0;
        }

        private void Btn_FileSystemWatcherSwitch_Click(object sender, EventArgs e)
        {
            if (fsw.FSWOn)
            {
                fsw.StopFSW();
                btn_FileSystemWatcherSwitch.Text = "Turn FSW on";
            }
            else
            {
                fsw.StartFSW(lb_FileWatcherSourcePath.Text, lb_FileWatcherDestinationPath.Text, tb_Key.Text, cb_CryptoAlhorithm.Text + "_encrypted_");
                btn_FileSystemWatcherSwitch.Text = "Turn FSW off";
            }

            tb_Key.Enabled = !fsw.FSWOn;
            btn_LoadKeyFromFIle.Enabled = !fsw.FSWOn;
            btn_SaveKeyToFile.Enabled = !fsw.FSWOn;
            btn_FileWatcherDestination.Enabled = !fsw.FSWOn;
            btn_FileWatcherSource.Enabled = !fsw.FSWOn;
            cb_CryptoAlhorithm.Enabled = !fsw.FSWOn;
            nud_Crypto_Settings.Enabled = !fsw.FSWOn;
        }

        private void Btn_LoadKeyFromFIle_Click(object sender, EventArgs e)
        {
            tb_Key.Text = FileManager.ReadFromTxtFile("Load key file", "");
        }

        private void Btn_SaveKeyToFile_Click(object sender, EventArgs e)
        {
            FileManager.SaveToTxtFile("Save key to file", "", tb_Key.Text);
        }

        private void Btn_FileWatcherDestination_Click(object sender, EventArgs e)
        {
            var selectedFolder = FileManager.SelectFolder();
            if (selectedFolder != lb_FileWatcherSourcePath.Text)
            {
                lb_FileWatcherDestinationPath.Text = selectedFolder;
                EnableDisableFileWatcherSwitch();
            }
        }

        private void Btn_FileWatcherSource_Click(object sender, EventArgs e)
        {
            var selectedFolder = FileManager.SelectFolder();
            if (selectedFolder != lb_FileWatcherDestinationPath.Text)
            {
                lb_FileWatcherSourcePath.Text = selectedFolder;
                EnableDisableFileWatcherSwitch();
            }
        }

        private void Cb_CryptoAlghoritm_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Key.Clear();
            switch (cb_CryptoAlhorithm.Text)
            {
                case "RC4":
                    tb_Key.MaxLength = 128;
                    nud_Crypto_Settings.Maximum = 256;
                    nud_Crypto_Settings.Minimum = 1;
                    minKeyLen = 1;
                    lb_Crypto_Settings.Text = "Key length:";
                    nud_Crypto_Settings.Value = 256;
                    break;
                case "XTEA":
                    tb_Key.MaxLength = 8;
                    nud_Crypto_Settings.Maximum = 100;
                    nud_Crypto_Settings.Minimum = 1;
                    minKeyLen = 8;
                    lb_Crypto_Settings.Text = "Rounds:";
                    nud_Crypto_Settings.Value = 32;
                    break;
                default:
                    break;
            }
        }

        private void EnableDisableFileWatcherSwitch()
        {
            var keyLength = tb_Key.Text.Length;
            btn_FileSystemWatcherSwitch.Enabled = lb_FileWatcherSourcePath.Text != "" && lb_FileWatcherDestinationPath.Text != "" && minKeyLen <= keyLength;
            if (cb_CryptoMode.SelectedIndex != 0) btn_FileSystemWatcherSwitch.Enabled = tb_Initialization_vector.Text.Length == 4;
        }

        private void Nud_Crypto_Settings_ValueChanged(object sender, EventArgs e)
        {
            switch (cb_CryptoAlhorithm.Text)
            {
                case "RC4":
                    cryptoContext.SetStrategy(new RC4((int)nud_Crypto_Settings.Value));
                    break;
                case "XTEA":
                    cryptoContext.SetStrategy(new XTEA((uint)nud_Crypto_Settings.Value));
                    break;
                default:
                    break;
            }
            EnableDisableFileWatcherSwitch();
        }

        private void Tb_Key_TextChanged(object sender, EventArgs e)
        {
            EnableDisableFileWatcherSwitch();
            btn_SaveKeyToFile.Enabled = tb_Key.Text.Length > 0;
        }

        private void FSWForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fsw.StopFSW();
        }

        private void Cb_CryptoMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_CryptoMode.SelectedIndex == 0)
            {
                tb_Initialization_vector.Visible = false;
                tb_Initialization_vector.Clear();
                lb_IV.Visible = false;
            }
            else if (!tb_Initialization_vector.Visible)
            {
                tb_Initialization_vector.Visible = true;
                lb_IV.Visible = true;
            }
        }
    }
}
