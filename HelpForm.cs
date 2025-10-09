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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    richTextBox1.Text = @"В случае если при запуске программы данные сохраненные в прошлые разы не открываются проверьте что в каталоге \Data\ есть файл data.dat";
                    break;
            }
        }
    }
}
