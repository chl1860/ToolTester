using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    public class Encryption
    {
        public Encryption()
        {
            
        }

        public void Encode(Stream myManagedStream)
        {
            using (var rijndaelManaged = new RijndaelManaged())
            {
                // assumes that the key and initialization vectors are already configured
                //var cryptoStream = new CryptoStream(myManagedStream, rijndaelManaged, CreateEncryptor(),CryptoStreamMode.Write);
            }
        }

        public void Decode(Stream myManagedStream)
        {
            using (var rijndaelManaged = new RijndaelManaged())
            {
                // assumes that the key and initialization vectors are already configured
                var crypoStream = new CryptoStream(myManagedStream, rijndaelManaged.
                CreateDecryptor(), CryptoStreamMode.Read);
            };
        }

        public byte[] RsaEncrypt(byte[] dataToEncrypted, RSAParameters rsaKeyInfo)
        {
            byte[] encryptedData;
            
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(rsaKeyInfo);
                encryptedData = rsa.Encrypt(dataToEncrypted, true);
            }
            return encryptedData;
        }

        public byte[] RsaDecript(byte[] encryptedData, RSAParameters rsaKeyInfo)
        {
            byte[] decryptedData;
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(rsaKeyInfo);
                decryptedData = rsa.Encrypt(encryptedData, true);
            }
            return decryptedData;
        }

        #region Data signature

        public byte[] GetDataSignature(string txt)
        {
            var sha = SHA1.Create();
            var buffer = Encoding.Default.GetBytes(txt);
            var memory = new MemoryStream(buffer);
            var hashCode = sha.ComputeHash(memory);

            var dsa = DSA.Create();
            return dsa.CreateSignature(hashCode);
        }

        public bool VerifyDataSignature(string txt,byte[] dataSignature)
        {
            var sha = SHA1.Create();
            var buffer = Encoding.Default.GetBytes(txt);
            var hashCode = sha.ComputeHash(buffer);
            var dsa = DSA.Create();
            return dsa.VerifySignature(hashCode, dataSignature);
        }

        #endregion
    }
}
