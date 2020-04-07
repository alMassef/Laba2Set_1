namespace WindowsFormsApp11
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
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.textSetF = new System.Windows.Forms.TextBox();
            this.textSetS = new System.Windows.Forms.TextBox();
            this.textRes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "Объединение",
            "Пересечение",
            "Разность",
            "Добавление элемента",
            "Удаление элемента"});
            this.cmbOperation.Location = new System.Drawing.Point(12, 88);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(173, 21);
            this.cmbOperation.TabIndex = 0;
            this.cmbOperation.Text = "Объединение";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // textSetF
            // 
            this.textSetF.Location = new System.Drawing.Point(213, 39);
            this.textSetF.Name = "textSetF";
            this.textSetF.Size = new System.Drawing.Size(183, 20);
            this.textSetF.TabIndex = 1;
            // 
            // textSetS
            // 
            this.textSetS.Location = new System.Drawing.Point(213, 88);
            this.textSetS.Name = "textSetS";
            this.textSetS.Size = new System.Drawing.Size(183, 20);
            this.textSetS.TabIndex = 2;
            // 
            // textRes
            // 
            this.textRes.Location = new System.Drawing.Point(213, 145);
            this.textRes.Name = "textRes";
            this.textRes.Size = new System.Drawing.Size(183, 20);
            this.textRes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выбрать операцию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Множество А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Множество В (число)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат";
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(12, 142);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(161, 30);
            this.buttonRes.TabIndex = 8;
            this.buttonRes.Text = "Вычислить";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 240);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRes);
            this.Controls.Add(this.textSetS);
            this.Controls.Add(this.textSetF);
            this.Controls.Add(this.cmbOperation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.TextBox textSetF;
        private System.Windows.Forms.TextBox textSetS;
        private System.Windows.Forms.TextBox textRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRes;
    }
}

