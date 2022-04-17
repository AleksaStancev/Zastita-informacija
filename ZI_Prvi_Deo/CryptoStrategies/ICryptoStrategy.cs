using System;
using System.Collections.Generic;
using System.Text;

namespace ZI_Prvi_Deo
{
    public interface ICryptoStrategy
    {
        byte[] Encrypt(byte[] bytesToEncrypt, string encryptionKey);
        byte[] Decrypt(byte[] bytesToDecrypt, string decryptionKey);
    }
}
