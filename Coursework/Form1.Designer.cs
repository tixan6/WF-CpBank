namespace Coursework
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.BelBank = new System.Windows.Forms.Button();
            this.Dabrabit = new System.Windows.Forms.Button();
            this.BTB = new System.Windows.Forms.Button();
            this.belweb = new System.Windows.Forms.Button();
            this.Alfa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(112)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.BelBank);
            this.panel1.Controls.Add(this.Dabrabit);
            this.panel1.Controls.Add(this.BTB);
            this.panel1.Controls.Add(this.belweb);
            this.panel1.Controls.Add(this.Alfa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 491);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 434);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 36);
            this.button6.TabIndex = 5;
            this.button6.Text = "Расчеты";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // BelBank
            // 
            this.BelBank.Location = new System.Drawing.Point(22, 228);
            this.BelBank.Name = "BelBank";
            this.BelBank.Size = new System.Drawing.Size(141, 36);
            this.BelBank.TabIndex = 4;
            this.BelBank.Text = "Беларусбанк";
            this.BelBank.UseVisualStyleBackColor = true;
            this.BelBank.Click += new System.EventHandler(this.button5_Click);
            // 
            // Dabrabit
            // 
            this.Dabrabit.Location = new System.Drawing.Point(22, 176);
            this.Dabrabit.Name = "Dabrabit";
            this.Dabrabit.Size = new System.Drawing.Size(141, 36);
            this.Dabrabit.TabIndex = 3;
            this.Dabrabit.Text = "Банк Дабрабыт";
            this.Dabrabit.UseVisualStyleBackColor = true;
            this.Dabrabit.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTB
            // 
            this.BTB.Location = new System.Drawing.Point(22, 125);
            this.BTB.Name = "BTB";
            this.BTB.Size = new System.Drawing.Size(141, 36);
            this.BTB.TabIndex = 2;
            this.BTB.Text = "ВТБ";
            this.BTB.UseVisualStyleBackColor = true;
            this.BTB.Click += new System.EventHandler(this.button3_Click);
            // 
            // belweb
            // 
            this.belweb.Location = new System.Drawing.Point(22, 74);
            this.belweb.Name = "belweb";
            this.belweb.Size = new System.Drawing.Size(141, 36);
            this.belweb.TabIndex = 1;
            this.belweb.Text = "БелВЭБ";
            this.belweb.UseVisualStyleBackColor = true;
            this.belweb.Click += new System.EventHandler(this.button2_Click);
            // 
            // Alfa
            // 
            this.Alfa.Location = new System.Drawing.Point(22, 21);
            this.Alfa.Name = "Alfa";
            this.Alfa.Size = new System.Drawing.Size(141, 36);
            this.Alfa.TabIndex = 0;
            this.Alfa.Text = "Альфа-Банк";
            this.Alfa.UseVisualStyleBackColor = true;
            this.Alfa.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(221, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 467);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(172, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите банк для дальнейших действий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(150, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1160, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button belweb;
        private System.Windows.Forms.Button Alfa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BelBank;
        private System.Windows.Forms.Button Dabrabit;
        private System.Windows.Forms.Button BTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

