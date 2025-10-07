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
        PasswordRecords updateRecord;
        public EditWriteForm(PasswordRecords record)
        {
            InitializeComponent();
            this.record = record;
            WriteNameBox.Text = record.Name;
            WritePasswordBox.Text = record.Password;
            WriteLoginBox.Text = record.Login;
            WriteSiteBox.Text = record.Site;
            WriteNoteBox.Text = record.Note;
        }
        public delegate void DataUpdate(PasswordRecords oldpass, PasswordRecords newpass);
        public event DataUpdate Update;

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            updateRecord = new(WriteNameBox.Text, WriteLoginBox.Text, WriteSiteBox.Text, WritePasswordBox.Text, WriteNoteBox.Text);
            updateRecord.Id = record.Id;
            /*updateRecord.Name = WriteNameBox.Text;
            updateRecord.Login = WriteLoginBox.Text;
            updateRecord.Password = WritePasswordBox.Text;
            updateRecord.Site = WriteSiteBox.Text;
            updateRecord.Note = WriteNoteBox.Text;*/
            Update?.Invoke(record, updateRecord);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
