namespace Pass_mgr
{
    partial class EditWriteForm
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
            CancelButton = new Button();
            AcceptButton = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            WriteNoteBox = new TextBox();
            WriteSiteBox = new TextBox();
            WritePasswordBox = new TextBox();
            WriteLoginBox = new TextBox();
            WriteNameBox = new TextBox();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(372, 94);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(112, 23);
            CancelButton.TabIndex = 23;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(372, 123);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(112, 23);
            AcceptButton.TabIndex = 22;
            AcceptButton.Text = "Изменить";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 127);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 21;
            label5.Text = "Примечания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 98);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 20;
            label4.Text = "Ссылка на сайт";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 69);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 19;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 40);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 18;
            label2.Text = "Логин";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 17;
            label1.Text = "Название записи";
            // 
            // WriteNoteBox
            // 
            WriteNoteBox.Location = new Point(111, 124);
            WriteNoteBox.Name = "WriteNoteBox";
            WriteNoteBox.Size = new Size(255, 23);
            WriteNoteBox.TabIndex = 16;
            // 
            // WriteSiteBox
            // 
            WriteSiteBox.Location = new Point(111, 95);
            WriteSiteBox.Name = "WriteSiteBox";
            WriteSiteBox.Size = new Size(255, 23);
            WriteSiteBox.TabIndex = 15;
            // 
            // WritePasswordBox
            // 
            WritePasswordBox.Location = new Point(111, 66);
            WritePasswordBox.Name = "WritePasswordBox";
            WritePasswordBox.Size = new Size(255, 23);
            WritePasswordBox.TabIndex = 14;
            // 
            // WriteLoginBox
            // 
            WriteLoginBox.Location = new Point(111, 37);
            WriteLoginBox.Name = "WriteLoginBox";
            WriteLoginBox.Size = new Size(255, 23);
            WriteLoginBox.TabIndex = 13;
            // 
            // WriteNameBox
            // 
            WriteNameBox.Location = new Point(111, 8);
            WriteNameBox.Name = "WriteNameBox";
            WriteNameBox.Size = new Size(255, 23);
            WriteNameBox.TabIndex = 12;
            // 
            // EditWriteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 154);
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
            Name = "EditWriteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button AcceptButton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox WriteNoteBox;
        private TextBox WriteSiteBox;
        private TextBox WritePasswordBox;
        private TextBox WriteLoginBox;
        private TextBox WriteNameBox;
    }
}