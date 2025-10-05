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
    public partial class CreateWrite : Form
    {
        public event EventHandler? CancelButt_Clc;
        public delegate void Data(string? name, string? login, string? password, string? site = "No data", string? note = "No data");
        public event Data? DataReady;
        public CreateWrite()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DataReady?.Invoke(WriteNameBox.Text, WriteLoginBox.Text, WritePasswordBox.Text, WriteSiteBox.Text, WriteNoteBox.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            CancelButt_Clc?.Invoke(this, EventArgs.Empty);
        }
    }
}
