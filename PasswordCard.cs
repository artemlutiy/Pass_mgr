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
        public PasswordCard(string writeName, string password, string site, string login, string note = "No data")
        {
            
            InitializeComponent();
            label1.Text = this.writeName;
            this.Click += CardBody_click;
            label1.Click += CardBody_click;
            this.writeName = writeName;
            this.password = password;
            this.site = site;
            this.login = login;
            this.note = note;

        }
        EditWriteForm editform;
        //stackOverflow бяка >:c
        private string _writeName;
        private string _password;
        private string _site;
        private string _login;
        private string _note;
        //свойства, надо нужно
        public string writeName
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
        }
        public delegate void Data(string? name, string? login, string? password, string? site, string? note);
        public delegate void Delete(PasswordCard obj);
        
        public event Delete PasswordDelete;
        public event Data? PasswordCardBodyClick;

        private void writeChangeButt_Click(object? sender, EventArgs e)
        {
            if (editform == null || editform.IsDisposed)
            {
                editform = new EditWriteForm(writeName, password, site, login, note);
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
            PasswordCardBodyClick?.Invoke(writeName, login, password, site, note);
        }
        private void ChangeInfo(string? name, string? login, string? password, string? site, string? note)
        {
            writeName = name;
            this.login = login;
            this.password = password;
            this.site = site;
            this.note = note;
            editform.Close();
        }
    }
}
