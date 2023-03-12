using System.IO;
using System.Security.Cryptography;
using System.Text;
using System;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;

namespace MOYO_Website.Technical_Services
{
    public class UtilityClass
    {
        private static readonly SHA1Managed Hasher = new SHA1Managed();
        private static SqlConnection moyoConnection;

        public static SqlConnection getmoyoConnectionString()
        {
            var jsonSource = new JsonConfigurationSource()
            {
                Path = "appsettings.json"
            };
            var builder = new ConfigurationBuilder().Add(jsonSource);
            var cfg = builder.Build();
            string dbConnectionString = cfg.GetSection("ConnectionStrings:MoyoConnectionString").Value;
            //moyoConnection = new SqlConnection()
            //{
            //    ConnectionString = dbConnectionString
            //};
            moyoConnection = new SqlConnection()
            {
                ConnectionString = "Data Source=dev1.baist.ca;Initial Catalog=MOYO_DB;User ID=mojewunmi1;Password=ADEdamola123!"
            };

            return moyoConnection;
        }


        public static string HashToken(string token)
        {

            // convert password to byte array
            byte[] passwordBytes = System.Text.Encoding.ASCII.GetBytes(token);
            // generate hash from byte array of password
            byte[] passwordHash = Hasher.ComputeHash(passwordBytes);
            // convert hash to string
            return Convert.ToBase64String(passwordHash, 0, passwordHash.Length);
        }
        public static string Encrypt(string input, string password)
        {
            string result = string.Empty;
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            bytesToBeEncrypted = SHA256.Create().ComputeHash(bytesToBeEncrypted);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
            byte[] encryptedBytes = null;
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 128;
                    AES.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Padding = PaddingMode.PKCS7;

                    AES.Mode = CipherMode.ECB;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            result = Convert.ToBase64String(encryptedBytes);
            return result;
        }

        public static string EncryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            bytesToBeEncrypted = SHA256.Create().ComputeHash(bytesToBeEncrypted);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }

        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 256;
                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Padding = PaddingMode.PKCS7;

                    AES.Mode = CipherMode.ECB;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

      
    }
}
