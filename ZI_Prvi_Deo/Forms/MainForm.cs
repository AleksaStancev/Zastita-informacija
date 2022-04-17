using System;
using System.Text;
using System.Windows.Forms;
using ZI_Prvi_Deo.CryptoStrategies.HashAlgorithms;

namespace ZI_Prvi_Deo
{
    public partial class MainForm : Form
    {
        private int minKeyLen;
        private readonly CryptoContext cryptoContext;

        public MainForm() 
        {
            InitializeComponent();
            cryptoContext = new CryptoContext(new RC4(256));
            cb_CryptoAlgorithm.SelectedIndex = 0;
            cb_CryptoMode.SelectedIndex = 0;
            cb_HashAlgorithm.SelectedIndex = 0;
            var a = new TigerHash();
            var g = a.Hash(Encoding.Unicode.GetBytes("PERAR"));
            tb_PlainText.Text = Encoding.Unicode.GetString(g);
        }
        private void Tb_PlainText_TextChanged(object sender, EventArgs e)
        {
            btn_SavePlainTextToFile.Enabled = tb_PlainText.Text.Length > 0;
            EnableDisableEncryptDecryptButton();
        }

        private void Btn_EncryptDecrypt_Click(object sender, EventArgs e)
        {
            if (rb_Encrypt.Checked)
            {
                var encryptedBytes = cryptoContext.Encrypt(Encoding.Unicode.GetBytes(tb_PlainText.Text), tb_Key.Text);
                FileManager.WriteToBinaryFile(lb_EncryptedFileFolderOrPath.Text + "\\" + tb_EncryptedFileName.Text, encryptedBytes);
                tb_PlainText.Clear();
                tb_EncryptedFileName.Clear();
                MessageBox.Show("File encrypted!");
            }
            else
            {
                var encryptedBytes = FileManager.ReadFromBinaryFile(lb_EncryptedFileFolderOrPath.Text);
                if (encryptedBytes != null)
                {
                    tb_PlainText.Text = Encoding.Unicode.GetString(cryptoContext.Decrypt(encryptedBytes, tb_Key.Text));
                    MessageBox.Show("File decrypted!");
                }
                else MessageBox.Show("File is empty!");
            }
        }
        private void Btn_LoadKeyFromFIle_Click(object sender, EventArgs e)
        {
            this.tb_Key.Text = FileManager.ReadFromTxtFile("Load key file","");          
        }

        private void Btn_LoadPlainTextFromFile_Click(object sender, EventArgs e)
        {
            this.tb_PlainText.Text = FileManager.ReadFromTxtFile("Load plain text file", "");
        }

        private void EnableDisableEncryptDecryptButton()
        {
            var keyLength = tb_Key.Text.Length;
            if (rb_Encrypt.Checked) btn_EncryptDecrypt.Enabled = tb_PlainText.Text.Length > 0 && minKeyLen <= keyLength && tb_EncryptedFileName.Text.TrimStart().TrimEnd().Length > 0 && lb_EncryptedFileFolderOrPath.Text != "" && (cb_CryptoMode.SelectedIndex == 0 || tb_Initialization_vector.Text.Length == 4);
            else btn_EncryptDecrypt.Enabled = minKeyLen <= keyLength && lb_EncryptedFileFolderOrPath.Text != "" && (cb_CryptoMode.SelectedIndex == 0 || tb_Initialization_vector.Text.Length == 4);
        }

        private void Tb_Key_TextChanged(object sender, EventArgs e)
        {
            EnableDisableEncryptDecryptButton();
            btn_SaveKeyToFile.Enabled = tb_Key.Text.Length > 0;
        }

        private void Btn_SavePlainTextToFile_Click(object sender, EventArgs e)
        {
            FileManager.SaveToTxtFile("Save plain text to file", "", tb_PlainText.Text);
        }

        private void Btn_StoreKeyToFile_Click(object sender, EventArgs e)
        {
            FileManager.SaveToTxtFile("Save key to file","", tb_Key.Text);
        }

        private void Btn_FileSystemWatcher_Click(object sender, EventArgs e)
        {
            FSWForm fswForm = new FSWForm()
            {
                Enabled = true
            };
            fswForm.ShowDialog();
        }

        private void Rb_Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Encrypt.Checked)
            {
                btn_EncryptDecrypt.Text = "Encrypt";
                btn_EncryptDecrypt.Enabled = false;
                tb_EncryptedFileName.Visible = true;
                lb_EncryptedFileName.Visible = true;
                lb_EncryptedFileSourceOrDestination.Text = "Encrypted file destination:";
                lb_EncryptedFileFolderOrPath.Text = "";
                btn_LoadPlainTextFromFile.Enabled = true;
                tb_PlainText.ReadOnly = false;
            }
        }

        private void Rb_Decryption_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Decryption.Checked)
            {
                btn_EncryptDecrypt.Text = "Decrypt";
                btn_EncryptDecrypt.Enabled = false;
                tb_EncryptedFileName.Visible = false;
                lb_EncryptedFileName.Visible = false;
                lb_EncryptedFileSourceOrDestination.Text = "Encrypted file source:";
                lb_EncryptedFileFolderOrPath.Text = "";
                btn_LoadPlainTextFromFile.Enabled = false;
                tb_PlainText.Clear();
                tb_PlainText.ReadOnly = true;
            }
        }

        private void Btn_SelectEncryptedFileFolderOrPath_Click(object sender, EventArgs e)
        {
            if(rb_Encrypt.Checked)
            {
                lb_EncryptedFileFolderOrPath.Text = FileManager.SelectFolder();
            }
            else
            {
                lb_EncryptedFileFolderOrPath.Text = FileManager.SelectFile("Select file to decrypt", "binary files (*.bin)|*.bin", 0, "", "bin");
            }
            EnableDisableEncryptDecryptButton();
        }

        private void SetCryptoAlgorithmStrategy()
        {
            if (tb_Initialization_vector.Text.Length == 4)
            {
                switch (cb_CryptoAlgorithm.SelectedIndex)
                {
                    case 0:
                        SetCryptoModeStrategy(new RC4((int)nud_Crypto_Settings.Value));
                        break;
                    case 1:
                        SetCryptoModeStrategy(new XTEA((uint)nud_Crypto_Settings.Value));
                        break;
                    default:
                        break;
                }
            }
        }

        private void Nud_Crypto_Settings_ValueChanged(object sender, EventArgs e)
        {
            SetCryptoAlgorithmStrategy();
            EnableDisableEncryptDecryptButton();
        }

        private void Cb_CryptoAlghoritm_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Key.Clear();
            switch (cb_CryptoAlgorithm.SelectedIndex)
            {
                case 0:
                    tb_Key.MaxLength = 128;
                    nud_Crypto_Settings.Maximum = 256;
                    nud_Crypto_Settings.Minimum = 1;
                    minKeyLen = 1;
                    lb_Crypto_Settings.Text = "Key length:";
                    nud_Crypto_Settings.Value = 256;
                    break;
                case 1:
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

        private void SetCryptoModeStrategy(ICryptoAlgorithm cryptoAlgorithm)
        {
            switch(cb_CryptoMode.SelectedIndex)
            {
                case 0:
                    cryptoContext.SetStrategy(cryptoAlgorithm);
                    break;
                case 1:
                    cryptoContext.SetStrategy(new CTR(cryptoAlgorithm, tb_Initialization_vector.Text));
                    break;
                default:
                    break;
            }
        }

        private void Tb_EncryptedFileName_TextChanged(object sender, EventArgs e)
        {
            EnableDisableEncryptDecryptButton();
        }

        private void Tb_Initialization_vector_TextChanged(object sender, EventArgs e)
        {
            EnableDisableEncryptDecryptButton();
            SetCryptoAlgorithmStrategy();
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
            EnableDisableEncryptDecryptButton();
        }

        private void Cb_HashAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
