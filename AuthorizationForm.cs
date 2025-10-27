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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm(bool regStatus)
        {
            HasMasterPass = regStatus;
            InitializeComponent();
            if (regStatus == false) { button1.Text = "Подтвердить"; label1.Text = "Создайте мастер-пароль"; this.Text = "Регистрация"; }
        }
        public delegate void MasterPass(string pass, AuthorizationForm sender);
        public event MasterPass ReadyMasterPass;
        public event MasterPass CreateMassterPass;
        public bool HasMasterPass { get; set; }

        private void button1_Click(object sender, EventArgs e) //войти
        {
            if (HasMasterPass) ReadyMasterPass?.Invoke(textBox1.Text, this); 
            else CreateMassterPass?.Invoke(textBox1.Text, this); 
            

        }

        private void button2_Click(object sender, EventArgs e)//отмена
        {
            Application.Exit();
        }
    }
}
