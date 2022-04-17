using System;
using System.Collections.Generic;
using System.Text;
using ZI_Prvi_Deo.Util;

namespace ZI_Prvi_Deo
{
    class CTR : ICryptoMode
    {
        private readonly ICryptoAlgorithm cryptoAlgorithm;
        private ulong counter;
        private readonly byte[] nonceAndCounter;
        public CTR(ICryptoAlgorithm cryptoAlgorithm, string noonce)
        {
            this.cryptoAlgorithm = cryptoAlgorithm;
            if (noonce.Length > 4) noonce = noonce.Substring(0, 4);
            counter = 0;
            nonceAndCounter = new byte[16];
            Array.Copy(Encoding.Unicode.GetBytes(noonce), nonceAndCounter, 8);
        }

        public byte[] Decrypt(byte[] bytesToDecrypt, string decryptionKey)
        {
            return ByteStuffer.RemoveStuffedBytes(Encrypt(bytesToDecrypt, decryptionKey), BitConverter.GetBytes((ushort)0xFFFF));
        }

        public byte[] Encrypt(byte[] bytesToEncrypt, string encryptionKey)
        {
            byte[] stufferBytesToEncrypt = ByteStuffer.FillMissingBytes(bytesToEncrypt, 16, BitConverter.GetBytes((ushort)0xFFFF));

            for (int j = 0; j < stufferBytesToEncrypt.Length; j += 16)
            {
                Array.Copy(BitConverter.GetBytes(counter), 0, nonceAndCounter, 8, 8);
                counter++;

                byte[] encryptedNonceAndCounter = cryptoAlgorithm.Encrypt(nonceAndCounter, encryptionKey);

                Array.Copy(BitConverter.GetBytes(BitConverter.ToUInt64(stufferBytesToEncrypt, j) ^ BitConverter.ToUInt64(encryptedNonceAndCounter, 0)),0, stufferBytesToEncrypt, j, 8);
                Array.Copy(BitConverter.GetBytes(BitConverter.ToUInt64(stufferBytesToEncrypt, j + 8) ^ BitConverter.ToUInt64(encryptedNonceAndCounter, 8)), 0, stufferBytesToEncrypt, j + 8, 8);
            }

            counter = 0;
            return stufferBytesToEncrypt;
        }
    }
}
