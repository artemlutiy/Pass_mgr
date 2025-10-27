namespace Pass_mgr
{
    partial class CreateWrite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WriteNameBox = new TextBox();
            WriteLoginBox = new TextBox();
            WritePasswordBox = new TextBox();
            WriteSiteBox = new TextBox();
            WriteNoteBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            AcceptButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // WriteNameBox
            // 
            WriteNameBox.Location = new Point(114, 12);
            WriteNameBox.Name = "WriteNameBox";
            WriteNameBox.Size = new Size(255, 23);
            WriteNameBox.TabIndex = 0;
            // 
            // WriteLoginBox
            // 
            WriteLoginBox.Location = new Point(114, 41);
            WriteLoginBox.Name = "WriteLoginBox";
            WriteLoginBox.Size = new Size(255, 23);
            WriteLoginBox.TabIndex = 1;
            // 
            // WritePasswordBox
            // 
            WritePasswordBox.Location = new Point(114, 70);
            WritePasswordBox.Name = "WritePasswordBox";
            WritePasswordBox.Size = new Size(255, 23);
            WritePasswordBox.TabIndex = 2;
            // 
            // WriteSiteBox
            // 
            WriteSiteBox.Location = new Point(114, 99);
            WriteSiteBox.Name = "WriteSiteBox";
            WriteSiteBox.Size = new Size(255, 23);
            WriteSiteBox.TabIndex = 3;
            // 
            // WriteNoteBox
            // 
            WriteNoteBox.Location = new Point(114, 128);
            WriteNoteBox.Name = "WriteNoteBox";
            WriteNoteBox.Size = new Size(255, 23);
            WriteNoteBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 5;
            label1.Text = "Название записи";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 44);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 6;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 73);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 102);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 8;
            label4.Text = "Ссылка на сайт";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 131);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 9;
            label5.Text = "Примечания";
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(375, 127);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(112, 23);
            AcceptButton.TabIndex = 10;
            AcceptButton.Text = "Создать";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(375, 98);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 23);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateWrite
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(489, 161);
            ControlBox = false;
            Controls.Add(CancelButton);
            Controls.Add(AcceptButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(WriteNoteBox);
            Controls.Add(WriteSiteBox);
            Controls.Add(WritePasswordBox);
            Controls.Add(WriteLoginBox);
            Controls.Add(WriteNameBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CreateWrite";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Создать запись";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox WriteNameBox;
        private TextBox WriteLoginBox;
        private TextBox WritePasswordBox;
        private TextBox WriteSiteBox;
        private TextBox WriteNoteBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button AcceptButton;
        private Button CancelButton;
    }
}