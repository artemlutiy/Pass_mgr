namespace Pass_mgr
{
    partial class PasswordCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            writeChangeButt = new Button();
            DeleteButt = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // writeChangeButt
            // 
            writeChangeButt.BackColor = SystemColors.ControlDarkDark;
            writeChangeButt.Location = new Point(324, 3);
            writeChangeButt.Name = "writeChangeButt";
            writeChangeButt.Size = new Size(120, 35);
            writeChangeButt.TabIndex = 0;
            writeChangeButt.Text = "Редактировать";
            writeChangeButt.UseVisualStyleBackColor = false;
            writeChangeButt.Click += writeChangeButt_Click;
            // 
            // DeleteButt
            // 
            DeleteButt.BackColor = SystemColors.ControlDarkDark;
            DeleteButt.Location = new Point(198, 3);
            DeleteButt.Name = "DeleteButt";
            DeleteButt.Size = new Size(120, 35);
            DeleteButt.TabIndex = 1;
            DeleteButt.Text = "Удалить";
            DeleteButt.UseVisualStyleBackColor = false;
            DeleteButt.Click += DeleteButt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // PasswordCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);
            Controls.Add(DeleteButt);
            Controls.Add(writeChangeButt);
            Name = "PasswordCard";
            Size = new Size(444, 39);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button writeChangeButt;
        private Button DeleteButt;
        private Label label1;
    }
}
