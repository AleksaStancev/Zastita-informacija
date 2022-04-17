using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZI_Prvi_Deo.Util;

namespace ZI_Prvi_Deo
{
    public class XTEA : ICryptoAlgorithm
    {
        private readonly uint rounds;
        private const uint delta = 0x9E3779B9;

        public XTEA(uint rounds = 32)
        {
            this.rounds = rounds;
        }
        public byte[] Decrypt(byte[] bytesToDecrypt, string decryptionKey)
        {
            byte[] decryptedBytes = (byte[])bytesToDecrypt.Clone();

            uint[] key = GenerateKey(decryptionKey);

            for (int j = 0; j < decryptedBytes.Length; j += 8)
            {
                uint v0 = BitConverter.ToUInt32(decryptedBytes, j);
                uint v1 = BitConverter.ToUInt32(decryptedBytes, j + 4);
                uint sum = delta * rounds;
                for (uint i = 0; i < rounds; i++)
                {
                    v1 -= (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3U]);
                    sum -= delta;
                    v0 -= (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3U]);
                }
                Array.Copy(BitConverter.GetBytes(v0), 0, decryptedBytes, j, 4);
                Array.Copy(BitConverter.GetBytes(v1), 0, decryptedBytes, j + 4, 4);
            }

            return ByteStuffer.RemoveStuffedBytes(decryptedBytes, BitConverter.GetBytes((ushort)0xFFFF));
        }

        public byte[] Encrypt(byte[] bytesToEncrypt, string encryptionKey)
        {
            byte[] encryptedBytes = ByteStuffer.FillMissingBytes(bytesToEncrypt, 8, BitConverter.GetBytes((ushort)0xFFFF));
            uint[] key = GenerateKey(encryptionKey);

            for (int j = 0; j < encryptedBytes.Length; j += 8)
            {
                uint v0 = BitConverter.ToUInt32(encryptedBytes, j);
                uint v1 = BitConverter.ToUInt32(encryptedBytes, j + 4);
                uint sum = 0;
                for (uint i = 0; i < rounds; i++)
                {
                    v0 += (((v1 << 4) ^ (v1 >> 5)) + v1) ^ (sum + key[sum & 3U]);
                    sum += delta;
                    v1 += (((v0 << 4) ^ (v0 >> 5)) + v0) ^ (sum + key[(sum >> 11) & 3U]);
                }
                Array.Copy(BitConverter.GetBytes(v0), 0, encryptedBytes, j, 4);
                Array.Copy(BitConverter.GetBytes(v1), 0, encryptedBytes, j + 4, 4);
            }

            return encryptedBytes;
        }

        

        private uint[] GenerateKey(string encryptionKey)
        {
            uint[] key = new uint[4];
            byte[] keyBytes = Encoding.Unicode.GetBytes(encryptionKey);

            for (int i = 0; i < 4; i++)
            {
                key[i] = BitConverter.ToUInt32(keyBytes, i * 4);
            }

            return key;
        }
    }
}
