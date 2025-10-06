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
        PasswordRecords record;
        public EditWriteForm(PasswordRecords record)
        {
            InitializeComponent();
            WriteNameBox.Text = record.Name;
            WritePasswordBox.Text = record.Password;
            WriteLoginBox.Text = record.Login;
            WriteSiteBox.Text = record.Site;
            WriteNoteBox.Text = record.Note;
            this.record = record;
        }
        public delegate void DataUpdate(PasswordRecords pass);
        public event DataUpdate Update;

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            record.Name = WriteNameBox.Text;
            record.Login = WriteLoginBox.Text;
            record.Password = WritePasswordBox.Text;
            record.Site = WriteSiteBox.Text;
            record.Note = WriteNoteBox.Text;
            Update?.Invoke(record);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
