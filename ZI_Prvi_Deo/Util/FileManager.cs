using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ZI_Prvi_Deo
{
    public static class FileManager
    {

        public static string SelectFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return "";
        }

        public static void SaveToTxtFile(string dialogTitle,
                                  string dialogFileName,
                                  string fileContent)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = dialogTitle,
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 0,
                FileName = dialogFileName,
                DefaultExt = "txt"
            };

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName != "")
            {
                using StreamWriter writer = new StreamWriter(sfd.OpenFile());
                writer.Write(fileContent);
            }
        }

        public static void WriteToBinaryFile(string filePath,
                                      byte[] fileContent)
        {
            File.WriteAllBytes(filePath + ".bin", fileContent);
        }

        public static string ReadFromTxtFile(string dialogTitle,
                                      string dialogFileName)
        {
            var fileContent = "";
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = dialogTitle,
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 0,
                FileName = dialogFileName
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using StreamReader reader = new StreamReader(ofd.OpenFile());
                fileContent = reader.ReadToEnd();

            }

            return fileContent;
        }

        public static byte[] ReadFromBinaryFile(string filePath)
        {

            if (File.Exists(filePath))
            {
                return File.ReadAllBytes(filePath);
            }

            return null;
        }

        public static string SelectFile(string dialogTitle,
                                 string dialogFilters,
                                 int dialogFilterIndex,
                                 string dialogFileName,
                                 string dialogDefaultExt)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = dialogTitle,
                Filter = dialogFilters,
                FilterIndex = dialogFilterIndex,
                FileName = dialogFileName,
                DefaultExt = dialogDefaultExt
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }

            return "";
        }
    }
}
