using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using diary.Entities;
using diary.BLL;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.IO;

namespace diary.DAL
{
    public class BaseAccess
    {
        public bool Insert(UserInfo obj)
        {
               BaseDLL da = new BaseDLL();

                SqlCommand cmd = da.GetCommand("INSERT INTO [User] (username,password,name,question,answer)" +
                     "VALUES (@Username, @Password, @Name, @Question, @Answer)");

                cmd.Connection.Open();

                SqlParameter p = new SqlParameter("@Username", SqlDbType.VarChar, 50);
                p.Value = obj.Username;

                SqlParameter p1 = new SqlParameter("@Password", SqlDbType.VarChar, 50);
                p1.Value = Encrypt(obj.Password);

                SqlParameter p2 = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                p2.Value = obj.Name;

                SqlParameter p3 = new SqlParameter("@Question", SqlDbType.VarChar, 50);
                p3.Value = obj.Question;

                SqlParameter p4 = new SqlParameter("@Answer", SqlDbType.VarChar, 50);
                p4.Value = Encrypt(obj.Answer);
                

                cmd.Parameters.Add(p);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);

                

                cmd.ExecuteNonQuery();

                cmd.Connection.Close();
                return true;
           
        }
        public bool compare(string username, string password)
        {
            try
            {
                BaseDLL da = new BaseDLL();
                SqlCommand cmd = da.GetCommand("SELECT * FROM [User] WHERE username ='"
    + username + "'");
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                UserInfo obj = new UserInfo();
                using (reader)
                {
                    while (reader.Read())
                    {
                        obj.Username = reader.GetString(0);
                        obj.Password = reader.GetString(1);
                    }
                    reader.Close();
                }
                cmd.Connection.Close();
                if (username == obj.Username && password == Decrypt(obj.Password))
                {
                    return true;
                }
                else return false;
            }
            catch (Exception) { return false; }
        }
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        public bool checkUsername(string username)
        {
            try
            {
                BaseDLL da = new BaseDLL();
                SqlCommand cmd = da.GetCommand("SELECT username FROM [User] WHERE username ='"
    + username + "'");
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                UserInfo obj = new UserInfo();
                using (reader)
                {
                    while (reader.Read())
                    {
                        obj.Username = reader.GetString(0);
                    }
                    reader.Close();
                }
                cmd.Connection.Close();
                if (username == obj.Username)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception) { return false; }
        }
        public string getSecurityQuestion(string username)
        {            
            try
            {
                string Question = null; ;
                BaseDLL da = new BaseDLL();
                SqlCommand cmd = da.GetCommand("SELECT question FROM [User] WHERE username ='"
    + username + "'");
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Question = reader.GetString(0);
                    }
                    reader.Close();
                }
                cmd.Connection.Close();

                return Question;
            }
            catch (Exception) { return null; }
        }
        public bool checkAnswer(string Username, string Answer)
        {
            try
            {
                string temp = null; ;
                BaseDLL da = new BaseDLL();
                SqlCommand cmd = da.GetCommand("SELECT answer FROM [User] WHERE username ='"
    + Username + "'");
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        temp = reader.GetString(0);
                    }
                    reader.Close();
                }
                cmd.Connection.Close();
                if(temp==Encrypt(Answer))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception) { return false; }
        }
        public void updatePassword(string Username, string Password)
        {   
            BaseDLL da = new BaseDLL();
            SqlCommand cmd = da.GetCommand("UPDATE [dbo].[User] SET password='" + Encrypt(Password) + "'WHERE username='"
                + Username +"'");
            cmd.Connection.Open();
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }
    }
}
