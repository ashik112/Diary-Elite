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
   public class UserAccess
    {

       public bool checkDate(string Username, string Date)
       {
           string temp=" ";
           BaseDLL da = new BaseDLL();
           SqlCommand cmd = da.GetCommand("SELECT date from [Diary] where date='" + Date +
                "' and username='" + Username + "'");
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
           if(temp==Date)
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       public string loadData(string Username, string Date,ref byte[] Image)
       {
           string temp = null; 
           BaseDLL da = new BaseDLL();
           SqlCommand cmd = da.GetCommand("SELECT page from [Diary] where (username='"+Username+"' and date='"+Date+"')");
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
           
           cmd = da.GetCommand("SELECT image FROM [Diary] WHERE (username='" + Username + "' and date='" + Date + "')");
           cmd.Connection.Open();
           Image = (byte[])cmd.ExecuteScalar();
           cmd.Connection.Close();
           return Decrypt(temp);
       }
       public bool Insert(string Username, string Date, string Page, ref byte[] Image)
       {
           
               BaseDLL da = new BaseDLL();
               SqlCommand cmd = da.GetCommand("INSERT INTO [Diary] (username,date,page,image)" +
                    "VALUES (@Username, @Date, @Page, @Pic)");

               //  SqlParameter p = new SqlParameter("@ID", SqlDbType.Int);
               //  p.Value = obj.ID;

               SqlParameter p = new SqlParameter("@Username", SqlDbType.VarChar, 50);
               p.Value = Username;

               SqlParameter p1 = new SqlParameter("@Date", SqlDbType.VarChar, 50);
               p1.Value = Date;

               SqlParameter p2 = new SqlParameter("@Page", SqlDbType.Text);
               p2.Value = Encrypt(Page);
               try
               {
                   SqlParameter p3 = new SqlParameter("@Pic", SqlDbType.VarBinary, Image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, Image);
                   p3.Value = Image;

                   cmd.Parameters.Add(p3);
               }
               
               catch(Exception)
               {
                   Image = new byte[10];
                   SqlParameter p3 = new SqlParameter("@Pic", SqlDbType.VarBinary, Image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, Image);
                   p3.Value = Image;

                   cmd.Parameters.Add(p3);
               }
               


               cmd.Parameters.Add(p);
               cmd.Parameters.Add(p1);
               cmd.Parameters.Add(p2);
               

               cmd.Connection.Open();

               int val = cmd.ExecuteNonQuery();

               cmd.Connection.Close();
               return val > 0;          
           
       }

       public bool Update(string Username, string Date, string Page, byte[] Image)
       {
           BaseDLL da = new BaseDLL();
           SqlCommand cmd = da.GetCommand("UPDATE [Diary] SET page='" +Encrypt(Page) + "' where (username='" + Username + "' and date='" + Date + "')" );
           cmd.Connection.Open();

           int val = cmd.ExecuteNonQuery();
           cmd.Connection.Close();

           cmd = da.GetCommand("UPDATE [Diary] SET image=@pic WHERE (username='" + Username + "' and date='" + Date + "')");
           try
           {
               SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, Image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, Image);
               cmd.Parameters.Add(prm);
           }
           catch(Exception)
           {
               Image = new byte[10];
               SqlParameter prm = new SqlParameter("@pic", SqlDbType.VarBinary, Image.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, Image);
               cmd.Parameters.Add(prm);

           }
           cmd.Connection.Open();
           cmd.ExecuteNonQuery();
           cmd.Connection.Close();

           return val > 0;
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
    }
}
