using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography;
using System.Xml;
using System.ComponentModel;
using System.Data;


namespace Pass_mgr
{
    [Serializable]
    public class PasswordRecords //класс с данными о записях
    {
        public PasswordRecords(string name, string login, string site, string password, string note)
        {
            Name = name;
            Login = login;
            Password = password;
            Site = site;
            Note = note;
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Site { get; set; }
        public string Note { get; set; }
    }
    public class PasswordSystem //системный класс менеджера паролей, шифрование, сохранения и все вот это вот
    {
        public List<PasswordRecords> records = new();
        //private byte[] key;
        //private byte[] iv;
        
        public PasswordSystem()
        {
            LoadPasswords();
            /*using (Aes aes = Aes.Create())
            {
                key = aes.Key;
                iv = aes.IV;
            }
            SaveKey();*/
        }
        public void SavePasswords()
        {
            try
            {
                JsonSerializerOptions options = new()
                {
                    WriteIndented = true
                };
                Directory.CreateDirectory("Data");
                string jsonstring = JsonSerializer.Serialize(records, options);
                File.WriteAllText(@"Data\data.dat", jsonstring);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadPasswords()
        {
            if(!File.Exists(@"Data\data.dat"))
                    return;
            string jsonstring = File.ReadAllText(@"Data\data.dat");
            var Records = JsonSerializer.Deserialize<List<PasswordRecords>>(jsonstring);
            records = Records;
        }
        public void UpdatePasswords(PasswordRecords record, PasswordRecords updateRecord)
        {
            int index = records.FindIndex(r => r.Id == record.Id);
            if (index != -1)
            {
                records[index] = updateRecord;
                
                SavePasswords();
            }
            else
                MessageBox.Show("Эм ошибка:(");
        }
        public void DeletePassword(PasswordRecords record)
        {
            int index = records.FindIndex(r => r.Id == record.Id);
            if (index != -1)
            {
                records.RemoveAt(index);
                
                SavePasswords();
            }
        }
       
       /* private void SaveKey()
        {
            var keyData = new
            {
                Key = Convert.ToBase64String(key),
                IV = Convert.ToBase64String(iv)
            };
            string json = JsonSerializer.Serialize(keyData);
            File.WriteAllText(@"Data\encryption.key", json);
        }
        private byte[] EncryptToByte()
        {

        }*/
    }
}
