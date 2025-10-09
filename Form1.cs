using System.Reflection.Metadata.Ecma335;

namespace Pass_mgr
{
    public partial class Form1 : Form
    {
        CreateWrite? dialog;
        PasswordCard? cntrl;
        SettingsForm? SettForm;
        HelpForm? helpForm;
        public PasswordSystem sys = new();
        public Form1()
        {
            InitializeComponent();
            Load_PasswordData();

        }

        private void CreateButt_Click(object sender, EventArgs e) //���������� ��� ������� ������ ������� � ��������
        {
            if (dialog == null || dialog.IsDisposed)
            {
                dialog = new CreateWrite();
                dialog.Show();
                dialog.DataReady += CreatingNewWrite;
                dialog.CancelButt_Clc += CreateForm_destroy;
            }

        }
        private void CreatingNewWrite(string? name, string? login, string? password, string? site, string? note) //���������� ��������, ���������� �� ����� �������� ������
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
        private void PassCardBodyClc(string? name, string? login, string? password, string? site, string? note) //����� ������� �� �������� � ������
        {
            if (name != null) NameBox.Text = name;
            if (login != null) LoginBox.Text = login;
            if (password != null) PasswordBox.Text = password;
            if (site != null) SiteBox.Text = site;
            if (note != null) NoteBox.Text = note;

        }
        private void CreateForm_destroy(object? sender, EventArgs e) //�������� ����� ���������� 
        {
            if (dialog != null)
                dialog.Close();
        }
        private void PasswordCard_delete(PasswordCard obj) //������� ������� �� ������
        {
            var mesbox = MessageBox.Show("�� �������?", "�������������", MessageBoxButtons.YesNo);

            if (DialogResult.Yes == mesbox)
            {
                flowLayoutPanel1.Controls.Remove(obj);
                NameBox.Text = "";
                LoginBox.Text = "";
                PasswordBox.Text = "";
                NoteBox.Text = "";
                SiteBox.Text = ""; //��������� �� �������� ������ :)
                sys.DeletePassword(obj.record);
            }
        }

        private void SettingsButt_Click(object sender, EventArgs e)
        {
            SettForm = new();
            SettForm.Show(); //�� ���� ���������� ������ ���� ���
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            //����� ��� I_I
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
