namespace LogOfHomeWorkResults
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.buttonMiddleMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.BackColor = System.Drawing.Color.White;
            this.comboBoxDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDate.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Items.AddRange(new object[] {
            "9.11.2022",
            "11.11.2022",
            "14.11.2022 ",
            "16.11.2022 ",
            "18.11.2022 ",
            "21.11.2022 ",
            "25.11.2022 ",
            "28.11.2022 ",
            "30.11.2022 ",
            "2.12.2022 ",
            "5.12.2022",
            "9.12.2022 ",
            "14.12.2022 ",
            "18.12.2022 ",
            "19.12.2022",
            "21.12.2022 ",
            "23.12.2022 ",
            "26.12.2022",
            "9.01.2022",
            "11.01.2022",
            "16.01.2022",
            "18.01.2022",
            "20.01.2022",
            "23.01.2022"});
            this.comboBoxDate.Location = new System.Drawing.Point(12, 12);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(371, 27);
            this.comboBoxDate.TabIndex = 3;
            this.comboBoxDate.Text = "Выбрать дату домашнего задания:";
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
            // 
            // textBoxMark
            // 
            this.textBoxMark.BackColor = System.Drawing.Color.White;
            this.textBoxMark.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMark.Location = new System.Drawing.Point(408, 12);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.ReadOnly = true;
            this.textBoxMark.Size = new System.Drawing.Size(81, 27);
            this.textBoxMark.TabIndex = 4;
            this.textBoxMark.Text = "Оценка";
            this.textBoxMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonMiddleMark
            // 
            this.buttonMiddleMark.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMiddleMark.Location = new System.Drawing.Point(12, 64);
            this.buttonMiddleMark.Name = "buttonMiddleMark";
            this.buttonMiddleMark.Size = new System.Drawing.Size(477, 32);
            this.buttonMiddleMark.TabIndex = 7;
            this.buttonMiddleMark.Text = "Средний балл за курс \"Введение в WF и WPF\"=";
            this.buttonMiddleMark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMiddleMark.UseVisualStyleBackColor = true;
            this.buttonMiddleMark.Click += new System.EventHandler(this.buttonMiddleMark_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 115);
            this.Controls.Add(this.buttonMiddleMark);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.comboBoxDate);
            this.MaximumSize = new System.Drawing.Size(524, 162);
            this.MinimumSize = new System.Drawing.Size(524, 162);
            this.Name = "Form1";
            this.Text = "Проверка успеваемости";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Button buttonMiddleMark;
    }
}

