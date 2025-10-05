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
    public partial class EditWriteForm : Form
    {
        public EditWriteForm(string writeName, string password, string site, string login, string note = "No data")
        {
            InitializeComponent();
            WriteNameBox.Text = writeName;
            WritePasswordBox.Text = password;
            WriteLoginBox.Text = login;
            WriteSiteBox.Text = site;
            WriteNoteBox.Text = note;
        }
        public delegate void DataUpdate(string writeName, string password, string site, string login, string note);
        public event DataUpdate Update;

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            Update?.Invoke(WriteNameBox.Text, WritePasswordBox.Text, WriteSiteBox.Text, WriteLoginBox.Text, WriteNoteBox.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
