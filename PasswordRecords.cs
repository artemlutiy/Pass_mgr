using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

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
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Site { get; set; }
        public string Note { get; set; }
    }
    public class PasswordSystem //системный класс менеджера паролей, шифрование, сохранения и все вот это вот
    {
        public List<PasswordRecords> records = new();
        
        public PasswordSystem()
        {
            LoadPasswords();
        }
        public void SavePasswords()
        {
            try
            {
                
                string jsonstring = JsonSerializer.Serialize(records);
                File.WriteAllText("data.json", jsonstring);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadPasswords()
        {
            string jsonstring = File.ReadAllText("data.json");
            var Records = JsonSerializer.Deserialize<List<PasswordRecords>>(jsonstring);
            records = Records;
        }
        public void UpdatePasswords(PasswordRecords record, PasswordRecords updateRecord)
        {
            int index = records.IndexOf(record);
            records[index] = updateRecord;
            Debug.Print($"Индекс: {index}");
            SavePasswords();
        }
    }
}
