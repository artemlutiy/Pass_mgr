using System.Reflection.Metadata.Ecma335;

namespace Pass_mgr
{
    public partial class Form1 : Form
    {
        CreateWrite? dialog;
        PasswordCard? cntrl;
        SettingsForm? SettForm;
        List<PasswordRecords?> records = new();
        PasswordSystem sys = new();
        public Form1()
        {
            InitializeComponent();
            Load_PasswordData(sys.LoadPasswords());

        }

        private void CreateButt_Click(object sender, EventArgs e) //вызываетс€ при нажатии кнопки создать в основной
        {
            if (dialog == null || dialog.IsDisposed)
            {
                dialog = new CreateWrite();
                dialog.Show();
                dialog.DataReady += CreatingNewWrite;
                dialog.CancelButt_Clc += CreateForm_destroy;
            }

        }
        private void CreatingNewWrite(string? name, string? login, string? password, string? site, string? note) //добавление карточки, вызываетс€ из формы создани€ записи
        {
            cntrl = new PasswordCard(new PasswordRecords(name, login, site, password, note));
            records.Add(new PasswordRecords(name, login, site, password, note));
            sys.SavePasswords(records);
            cntrl.Margin = new Padding(5);
            flowLayoutPanel1.Controls.Add(cntrl);
            cntrl.PasswordCardBodyClick += PassCardBodyClc;
            cntrl.PasswordDelete += PasswordCard_delete;

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
        private void CreateForm_destroy(object? sender, EventArgs e) //удаление формы добавлени€ 
        {
            if (dialog != null)
                dialog.Close();
        }
        private void PasswordCard_delete(PasswordCard obj) //удал€ет элемент из списка
        {
            var mesbox = MessageBox.Show("¬ы уверены?", "ѕодтверждение", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == mesbox)
            {
                flowLayoutPanel1.Controls.Remove(obj);
                NameBox.Text = "";
                LoginBox.Text = "";
                PasswordBox.Text = "";
                NoteBox.Text = "";
                SiteBox.Text = ""; //подтираем из панельки записи :)
            }
        }

        private void SettingsButt_Click(object sender, EventArgs e)
        {
            SettForm = new();
            SettForm.Show(); //по мере дополнени€ впишем чото ещо
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            //помош еее I_I
        }
        private void Load_PasswordData(List<PasswordRecords> records)
        {
            foreach (var record in records)
            {
                cntrl = new(record);
                cntrl.Margin = new Padding(5);
                flowLayoutPanel1.Controls.Add(cntrl);
                cntrl.PasswordCardBodyClick += PassCardBodyClc;
                cntrl.PasswordDelete += PasswordCard_delete;
            }
        }
    }
}
