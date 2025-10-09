namespace Pass_mgr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateButt = new Button();
            SettingsButt = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            NoteBox = new TextBox();
            PasswordBox = new TextBox();
            SiteBox = new TextBox();
            LoginBox = new TextBox();
            NameBox = new TextBox();
            NoteLabel = new Label();
            SiteLabel = new Label();
            PasswordLabel = new Label();
            LoginLabel = new Label();
            NameLabel = new Label();
            HelpButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CreateButt
            // 
            CreateButt.Location = new Point(524, 324);
            CreateButt.Name = "CreateButt";
            CreateButt.Size = new Size(188, 34);
            CreateButt.TabIndex = 0;
            CreateButt.Text = "Создать запись";
            CreateButt.UseVisualStyleBackColor = true;
            CreateButt.Click += CreateButt_Click;
            // 
            // SettingsButt
            // 
            SettingsButt.Location = new Point(524, 404);
            SettingsButt.Name = "SettingsButt";
            SettingsButt.Size = new Size(188, 34);
            SettingsButt.TabIndex = 1;
            SettingsButt.Text = "Настройки";
            SettingsButt.UseVisualStyleBackColor = true;
            SettingsButt.Click += SettingsButt_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 426);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(NoteBox);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(SiteBox);
            panel1.Controls.Add(LoginBox);
            panel1.Controls.Add(NameBox);
            panel1.Controls.Add(NoteLabel);
            panel1.Controls.Add(SiteLabel);
            panel1.Controls.Add(PasswordLabel);
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(NameLabel);
            panel1.Location = new Point(492, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 219);
            panel1.TabIndex = 3;
            // 
            // NoteBox
            // 
            NoteBox.BorderStyle = BorderStyle.None;
            NoteBox.Location = new Point(17, 186);
            NoteBox.Name = "NoteBox";
            NoteBox.ReadOnly = true;
            NoteBox.Size = new Size(202, 16);
            NoteBox.TabIndex = 14;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Location = new Point(17, 111);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.ReadOnly = true;
            PasswordBox.Size = new Size(202, 16);
            PasswordBox.TabIndex = 13;
            // 
            // SiteBox
            // 
            SiteBox.BorderStyle = BorderStyle.None;
            SiteBox.Location = new Point(17, 149);
            SiteBox.Name = "SiteBox";
            SiteBox.ReadOnly = true;
            SiteBox.Size = new Size(202, 16);
            SiteBox.TabIndex = 12;
            // 
            // LoginBox
            // 
            LoginBox.BorderStyle = BorderStyle.None;
            LoginBox.Location = new Point(17, 73);
            LoginBox.Name = "LoginBox";
            LoginBox.ReadOnly = true;
            LoginBox.Size = new Size(202, 16);
            LoginBox.TabIndex = 11;
            // 
            // NameBox
            // 
            NameBox.BorderStyle = BorderStyle.None;
            NameBox.Location = new Point(17, 35);
            NameBox.Name = "NameBox";
            NameBox.ReadOnly = true;
            NameBox.Size = new Size(202, 16);
            NameBox.TabIndex = 10;
            // 
            // NoteLabel
            // 
            NoteLabel.AutoSize = true;
            NoteLabel.Location = new Point(17, 168);
            NoteLabel.Name = "NoteLabel";
            NoteLabel.Size = new Size(55, 15);
            NoteLabel.TabIndex = 4;
            NoteLabel.Text = "Заметка:";
            // 
            // SiteLabel
            // 
            SiteLabel.AutoSize = true;
            SiteLabel.Location = new Point(17, 130);
            SiteLabel.Name = "SiteLabel";
            SiteLabel.Size = new Size(95, 15);
            SiteLabel.TabIndex = 3;
            SiteLabel.Text = "Ссылка на сайт:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(17, 92);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(52, 15);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Пароль:";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(17, 54);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(44, 15);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Логин:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(17, 16);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(103, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Название записи:";
            // 
            // HelpButton
            // 
            HelpButton.Location = new Point(524, 364);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(188, 34);
            HelpButton.TabIndex = 4;
            HelpButton.Text = "Помощь";
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(HelpButton);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SettingsButt);
            Controls.Add(CreateButt);
            MinimumSize = new Size(757, 489);
            Name = "Form1";
            Text = "Менеджер паролей";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button CreateButt;
        private Button SettingsButt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label NameLabel;
        private Label NoteLabel;
        private Label SiteLabel;
        private Label PasswordLabel;
        private Label LoginLabel;
        private Button HelpButton;
        private TextBox NoteBox;
        private TextBox PasswordBox;
        private TextBox SiteBox;
        private TextBox LoginBox;
        private TextBox NameBox;
    }
}
