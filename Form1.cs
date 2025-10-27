using System.Reflection.Metadata.Ecma335;

namespace Pass_mgr
{
    public partial class Form1 : Form
    {
        CreateWrite? dialog;
        PasswordCard? cntrl;
        SettingsForm? SettForm;
        HelpForm? helpForm;
        AuthorizationForm authForm;
        public PasswordSystem sys = new();
        public Form1()
        {
            InitializeComponent();
            bool choose = File.Exists(@"Data\service.dat");
            authForm = new(choose);
            authForm.ReadyMasterPass += CheckPass;
            authForm.CreateMassterPass += AuthService.SaveMasterPass;
            
            authForm.ShowDialog();

            

        }
        private void CheckPass(string input, AuthorizationForm sender)
        {
            if (AuthService.CheckMasterPass(input))
            {
                sender.Close();
                Load_PasswordData();
            }
            else
            {
                authForm.textBox1.Text = "";
                MessageBox.Show("Введен неверный мастер-пароль");
            }
                

            
        }
        private void CreateButt_Click(object sender, EventArgs e) //вызывается при нажатии кнопки создать в основной
        {
            if (dialog == null || dialog.IsDisposed)
            {
                dialog = new CreateWrite();
                dialog.Show();
                dialog.DataReady += CreatingNewWrite;
                dialog.CancelButt_Clc += CreateForm_destroy;
            }

        }
        private void CreatingNewWrite(string? name, string? login, string? password, string? site, string? note) //добавление карточки, вызывается из формы создания записи
        {
            cntrl = new PasswordCard(new PasswordRecords(name, login, site, password, note));
            sys.records.Add(cntrl.record);
            sys.SavePasswords();
            cntrl.Margin = new Padding(5);
            flowLayoutPanel1.Controls.Add(cntrl);
            cntrl.PasswordCardBodyClick += PassCardBodyClc;
            cntrl.PasswordDelete += PasswordCard_delete;
            cntrl.EditWrite += sys.UpdatePasswords;

            if (dialog != null) dialog.Close();
        }
        private void PassCardBodyClc(string? name, string? login, string? password, string? site, string? note) //когда тапаешь по карточке в списке
        {
            if (name != null) NameBox.Text = name;
            if (login != null) LoginBox.Text = login;
            if (password != null) PasswordBox.Text = password;
            if (site != null) SiteBox.Text = site;
            if (note != null) NoteBox.Text = note;

        }
        private void CreateForm_destroy(object? sender, EventArgs e) //удаление формы добавления 
        {
            if (dialog != null)
                dialog.Close();
        }
        private void PasswordCard_delete(PasswordCard obj) //удаляет элемент из списка
        {
            var mesbox = MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == mesbox)
            {
                flowLayoutPanel1.Controls.Remove(obj);
                NameBox.Text = "";
                LoginBox.Text = "";
                PasswordBox.Text = "";
                NoteBox.Text = "";
                SiteBox.Text = ""; //подтираем из панельки записи :)
                sys.DeletePassword(obj.record);
            }
        }

        private void SettingsButt_Click(object sender, EventArgs e)
        {
            SettForm = new();
            SettForm.Show(); //по мере дополнения впишем чото ещо
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            //помош еее I_I
            if (helpForm == null || helpForm.IsDisposed)
            {
                helpForm = new HelpForm();
                helpForm.Show();
                
            }
        }
        private void Load_PasswordData()
        {
            
            foreach (var record in sys.records)
            {
                cntrl = new(record);
                cntrl.Margin = new Padding(5);
                flowLayoutPanel1.Controls.Add(cntrl);
                cntrl.PasswordCardBodyClick += PassCardBodyClc;
                cntrl.PasswordDelete += PasswordCard_delete;
                cntrl.EditWrite += sys.UpdatePasswords;
            }
        }
        
    }
}
