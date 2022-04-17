using System;
using System.Collections.Generic;
using System.Text;

namespace ZI_Prvi_Deo
{
    public class CryptoContext
    {
        private ICryptoStrategy strategy;
        public CryptoContext(ICryptoStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(ICryptoStrategy strategy)
        {
            this.strategy = strategy;
        }

        public byte[] Encrypt(byte[] bytesToEncrypt, string encryptionKey)
        {
            return strategy.Encrypt(bytesToEncrypt, encryptionKey);
        }

        public byte[] Decrypt(byte[] bytesToEncrypt, string encryptionKey)
        {
            return strategy.Decrypt(bytesToEncrypt, encryptionKey);
        }
    }
}
