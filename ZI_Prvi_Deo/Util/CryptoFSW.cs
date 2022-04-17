using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ZI_Prvi_Deo
{
    public class CryptoFSW
    {
        private readonly FileSystemWatcher fsw;
        private readonly CryptoContext cryptoContext;
        private string destinationPath, encryptionKey, filePrefix;
        public bool FSWOn { get; private set; }

        public CryptoFSW(CryptoContext cryptoContext)
        {
            fsw = new FileSystemWatcher();
            fsw.Changed += Fsw_Changed;
            this.cryptoContext = cryptoContext;
        }

        public void StartFSW(string fswSourcePath, string fswDestinationPath, string encryptionKey, string filePrefix)
        {
            if (Directory.Exists(fswSourcePath) && Directory.Exists(fswDestinationPath))
            {
                fsw.Path = fswSourcePath;
                fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.LastAccess;
                destinationPath = fswDestinationPath;
                this.encryptionKey = encryptionKey;
                this.filePrefix = filePrefix;
                fsw.EnableRaisingEvents = true;
                FSWOn = true;
            }
            else MessageBox.Show("Please provide existing source and destination folders!");
        }

        private void Fsw_Changed(object sender, FileSystemEventArgs e)
        {
            var encryptedBytes = cryptoContext.Encrypt(Encoding.Unicode.GetBytes(File.ReadAllText(e.FullPath)), encryptionKey);
            FileManager.WriteToBinaryFile(destinationPath + "\\" + filePrefix + e.Name.Remove(e.Name.Length - 4), encryptedBytes);
        }

        public void StopFSW()
        {
            fsw.EnableRaisingEvents = false;
            FSWOn = false;
        }

    }
}
