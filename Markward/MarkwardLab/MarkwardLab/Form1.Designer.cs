namespace MarkwardLab
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
            this.acctbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbFunc5 = new System.Windows.Forms.RadioButton();
            this.rbFunc4 = new System.Windows.Forms.RadioButton();
            this.rbFunc3 = new System.Windows.Forms.RadioButton();
            this.rbFunc2 = new System.Windows.Forms.RadioButton();
            this.rbFunc1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acctbutton
            // 
            this.acctbutton.Location = new System.Drawing.Point(325, 393);
            this.acctbutton.Name = "acctbutton";
            this.acctbutton.Size = new System.Drawing.Size(104, 45);
            this.acctbutton.TabIndex = 0;
            this.acctbutton.Text = "go";
            this.acctbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.acctbutton.UseVisualStyleBackColor = true;
            this.acctbutton.Click += new System.EventHandler(this.acctbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 426);
            this.textBox1.TabIndex = 1;
            // 
            // rbFunc5
            // 
            this.rbFunc5.AutoSize = true;
            this.rbFunc5.Image = global::MarkwardLab.Properties.Resources.func5;
            this.rbFunc5.Location = new System.Drawing.Point(913, 334);
            this.rbFunc5.Name = "rbFunc5";
            this.rbFunc5.Size = new System.Drawing.Size(591, 104);
            this.rbFunc5.TabIndex = 6;
            this.rbFunc5.TabStop = true;
            this.rbFunc5.UseVisualStyleBackColor = true;
            // 
            // rbFunc4
            // 
            this.rbFunc4.AutoSize = true;
            this.rbFunc4.Image = global::MarkwardLab.Properties.Resources.func4;
            this.rbFunc4.Location = new System.Drawing.Point(921, 206);
            this.rbFunc4.Name = "rbFunc4";
            this.rbFunc4.Size = new System.Drawing.Size(588, 91);
            this.rbFunc4.TabIndex = 5;
            this.rbFunc4.TabStop = true;
            this.rbFunc4.UseVisualStyleBackColor = true;
            this.rbFunc4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbFunc3
            // 
            this.rbFunc3.AutoSize = true;
            this.rbFunc3.Image = global::MarkwardLab.Properties.Resources.func3;
            this.rbFunc3.Location = new System.Drawing.Point(325, 246);
            this.rbFunc3.Name = "rbFunc3";
            this.rbFunc3.Size = new System.Drawing.Size(590, 124);
            this.rbFunc3.TabIndex = 4;
            this.rbFunc3.TabStop = true;
            this.rbFunc3.UseVisualStyleBackColor = true;
            // 
            // rbFunc2
            // 
            this.rbFunc2.AutoSize = true;
            this.rbFunc2.Image = global::MarkwardLab.Properties.Resources.func2;
            this.rbFunc2.Location = new System.Drawing.Point(915, 10);
            this.rbFunc2.Name = "rbFunc2";
            this.rbFunc2.Size = new System.Drawing.Size(589, 174);
            this.rbFunc2.TabIndex = 3;
            this.rbFunc2.TabStop = true;
            this.rbFunc2.UseVisualStyleBackColor = true;
            this.rbFunc2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbFunc1
            // 
            this.rbFunc1.AutoSize = true;
            this.rbFunc1.Image = global::MarkwardLab.Properties.Resources.Func1;
            this.rbFunc1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbFunc1.Location = new System.Drawing.Point(325, 70);
            this.rbFunc1.Name = "rbFunc1";
            this.rbFunc1.Size = new System.Drawing.Size(593, 170);
            this.rbFunc1.TabIndex = 2;
            this.rbFunc1.TabStop = true;
            this.rbFunc1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(322, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите тестовую функцию.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1513, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbFunc5);
            this.Controls.Add(this.rbFunc4);
            this.Controls.Add(this.rbFunc3);
            this.Controls.Add(this.rbFunc2);
            this.Controls.Add(this.rbFunc1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.acctbutton);
            this.Name = "Form1";
            this.Text = "Я люблю методы оптимизации";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acctbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbFunc1;
        private System.Windows.Forms.RadioButton rbFunc2;
        private System.Windows.Forms.RadioButton rbFunc3;
        private System.Windows.Forms.RadioButton rbFunc4;
        private System.Windows.Forms.RadioButton rbFunc5;
        private System.Windows.Forms.Label label1;
    }
}

