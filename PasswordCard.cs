using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_mgr
{
    public partial class PasswordCard : UserControl
    {
        public PasswordCard(PasswordRecords record)
        {
            
            InitializeComponent();
            label1.Text = record.Name;
            this.record = record;
            this.Click += CardBody_click;
            label1.Click += CardBody_click;
            

        }
        PasswordRecords record;
        EditWriteForm editform;
        //stackOverflow бяка >:c
       /* private string _writeName;
        private string _password;
        private string _site;
        private string _login;
        private string _note;*/
        //свойства, надо нужно
       /* public string writeName
        {
            get
            {
                return _writeName;
            }
            set
            {
                if (value == null) _writeName = "No Data";
                else
                {
                    _writeName = value;
                    label1.Text = _writeName;
                }
            }
        }
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value == null) _password = "No data";
                else
                    _password = value;
            }
        }
        public string site
        {
            get
            {
                return _site;
            }
            set
            {
                if (value == null) _site = "No data";
                else
                    _site = value;
            }
        }
        public string login
        {
            get
            {
                return _login;
            }
            set
            {
                if (value == null) _login = "No data";
                else
                    _login = value;
            }
        }
        public string note
        {
            get
            {
                return _note;
            }
            set
            {
                if (value == null) _note = "No data";
                else
                    _note = value;
            }
        }*/
        public delegate void Data(string? name, string? login, string? password, string? site, string? note);
        public delegate void Delete(PasswordCard obj);
        
        public event Delete PasswordDelete;
        public event Data? PasswordCardBodyClick;

        private void writeChangeButt_Click(object? sender, EventArgs e)
        {
            if (editform == null || editform.IsDisposed)
            {
                editform = new EditWriteForm(record);
                editform.Show();
                editform.Update += ChangeInfo;
            }
        }

        private void DeleteButt_Click(object? sender, EventArgs e)
        {
            PasswordDelete?.Invoke(this);
        }
        private void CardBody_click(object? sender, EventArgs e)
        {
            PasswordCardBodyClick?.Invoke(record.Name, record.Login, record.Password, record.Site, record.Note);
        }
        private void ChangeInfo(PasswordRecords pass)
        {
            record = pass;
            editform.Close();
        }
    }
}
