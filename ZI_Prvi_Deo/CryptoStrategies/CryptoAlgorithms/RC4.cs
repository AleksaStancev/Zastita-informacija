using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ZI_Prvi_Deo
{
    public class RC4 : ICryptoAlgorithm
    {
        private byte[] Key;
        private int keyLen;
        public RC4(int keyLen = 5)
        {
            SetKeyLen(keyLen);
        }

        public byte[] Encrypt(byte[] bytesToEncrypt, string encryptionKey)
        {
            KSA(encryptionKey);
            int j = 0;
            byte[] encryptedBytes = (byte[])bytesToEncrypt.Clone();
            foreach (byte keyByte in PRGA())
            {
                encryptedBytes[j] = (byte)(encryptedBytes[j] ^ keyByte);
                if (++j == encryptedBytes.Length) return encryptedBytes;
            }            
            
            return null;
        }

        public byte[] Decrypt(byte[] bytesToEncrypt, string decryptionKey)
        {
            return Encrypt(bytesToEncrypt, decryptionKey);
        }

        private void KSA(string encriptionKey)
        {
            byte[] encriptionKeyBytes = Encoding.UTF8.GetBytes(encriptionKey);
            int j = 0; 
           
            for (int i = 0; i < keyLen; i++)
            {
                Key[i] = (byte)i;
            }

            for (int i = 0; i < keyLen; i++)
            {
                j = (j + Key[i] + encriptionKeyBytes[i % encriptionKeyBytes.Length]) % keyLen;
                SwapKeyElements(i, j);
            }
        }

        private void SwapKeyElements(int i, int j)
        {
            byte temp = Key[i];
            Key[i] = Key[j];
            Key[j] = temp;
        }

        private IEnumerable<byte> PRGA()
        {
            int i = 0, j = 0;
            while(true)  
            {
                i = (i + 1) % keyLen;
                j = (j + Key[i]) % keyLen;
                SwapKeyElements(i, j);
                int temp = (Key[i] + Key[j]) % keyLen;
                yield return Key[temp];
            }
        }

        public void SetKeyLen(int keyLen)
        {
            if (keyLen < 5) keyLen = 5;
            else if (keyLen > 256) keyLen = 256;
            this.keyLen = keyLen;
            Key = new byte[keyLen];
        }
    }
}
