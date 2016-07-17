using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Diablo_III_ladder_analytics.Classes;

namespace Diablo_III_ladder_analytics
{
    static class AccountController
    {
        static bool CheckAccountsFileExists()
        {
            string filePath = AppSettings.accountsFilePath;

            if (File.Exists(filePath))
            {
                return true;
            }
            return false;
        }

        static void CreateFile()
        {
            File.Create(AppSettings.accountsFilePath).Close();
        }

        static void InsertRecord(string record)
        {
            using (StreamWriter accountsFile = new StreamWriter(AppSettings.accountsFilePath, true))
            {
                accountsFile.WriteLine(record);
            }
        }

        static string ReadFile()
        {
            string output = "";

            try
            {
                output = File.ReadAllText(AppSettings.accountsFilePath);
            }
            catch (FileNotFoundException ex)
            {
                return output;
            }

            return output;
        }

        public static bool AddAccount(string username, string clientId, string clientSecretId)
        {
            var newAcc = new Account();
            newAcc.Username = username;
            newAcc.ClientId = Encryptor.Encrypt(clientId);
            newAcc.ClientSecretId = Encryptor.Encrypt(clientSecretId);



            if (!CheckAccountsFileExists()) { CreateFile();}
            InsertRecord(newAcc.ToString());

            return true;
        }

        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            string rawText = ReadFile();
            accounts = ParseAccountsText(rawText);

            foreach (var account in accounts)
            {
                account.Username = account.Username;
                account.ClientId = Encryptor.Decrypt(account.ClientId);
                account.ClientSecretId = Encryptor.Decrypt(account.ClientSecretId);
            }

            return accounts;
        }

        static List<Account> ParseAccountsText(string rawText)
        {
            string accountPattern = @"(?<=\r\n)(.*?)(?=\r\n)|(username)(.*?)(?=\r\n)";
            string usernamePattern = @"(?<=username=)[^.|]+";
            string clientIdPattern = @"(?<=client_id=)[^.|]+";
            string clientSercretIdPattern = @"(?<=clientsecretid=)[^.|]+";

            List<Account> parsedAccounts = new List<Account>();

            try
            {
                MatchCollection matchList = Regex.Matches(rawText, accountPattern);

                foreach (var match in matchList)
                {
                    var username = Regex.Match(match.ToString(), usernamePattern).ToString();
                    var clientId = Regex.Match(match.ToString(), clientIdPattern).ToString();
                    var clientSecretId = Regex.Match(match.ToString(), clientSercretIdPattern).ToString();

                    var account = new Account();
                    account.Username = username;
                    account.ClientId = clientId;
                    account.ClientSecretId = clientSecretId;

                    parsedAccounts.Add(account);
                }
            } catch (Exception) { throw new System.FormatException(); }

            return parsedAccounts;
        }
    }

    class Account
    {
        public string Username { get; set; }
        public string ClientId { get; set; }
        public string ClientSecretId { get; set; }

        public override string ToString()
        {
            return "username="+Username+
                   "|client_id="+ClientId+
                   "|clientsecretid="+ClientSecretId;
        }
    }

    static class Encryptor
    {
        private const int KeySize = 128;
        private const string Key = "7his1sak3yl0lpwn";
        private const string Salt = "4ndth1si2th3sal7"; //this is intentional, I don't want to store salts yet.

        /*private static byte[] GenerateSalt(int saltSize)
        {
            byte[] salt = new byte[saltSize];

            Random random = new Random();

            for (int i = 0 ; i< salt.Length; i++)
            {
                salt[i] = (byte)random.Next(byte.MinValue, byte.MaxValue);
            }

            return salt;
        }*/

        public static string Encrypt(string input)
        {
            byte[] saltBytes = Encoding.UTF8.GetBytes(Salt);
            byte[] keyBytes = Encoding.UTF8.GetBytes(Key);

            var aesAlg = new RijndaelManaged();
            aesAlg.Key = keyBytes;
            aesAlg.IV = saltBytes;

            var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            var msEncrypt = new MemoryStream();
            using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            using (var swEncrypt = new StreamWriter(csEncrypt))
            {
                swEncrypt.Write(input);
            }

            return Convert.ToBase64String(msEncrypt.ToArray());
        }

        public static string Decrypt(string input)
        {
            string output = "";
            byte[] saltBytes = Encoding.UTF8.GetBytes(Salt);
            byte[] keyBytes = Encoding.UTF8.GetBytes(Key);

            var aesAlg = new RijndaelManaged();
            aesAlg.Key = keyBytes;
            aesAlg.IV = saltBytes;
            var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            var cipher = Convert.FromBase64String(input);

            using (var msDecrypt = new MemoryStream(cipher))
            {
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        output = srDecrypt.ReadToEnd();
                    }
                }
            }
            return output;
        }
    }
}
