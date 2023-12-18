namespace DataBases
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
            this.label1 = new System.Windows.Forms.Label();
            this.Kbe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textD1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.TextBox();
            this.choose = new System.Windows.Forms.ComboBox();
            this.tk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.TextBox();
            this.tol = new System.Windows.Forms.ComboBox();
            this.nat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.answerR = new System.Windows.Forms.Label();
            this.answerQ0 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 30;
            // 
            // Kbe
            // 
            this.Kbe.Location = new System.Drawing.Point(0, 0);
            this.Kbe.Name = "Kbe";
            this.Kbe.Size = new System.Drawing.Size(100, 20);
            this.Kbe.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textD1
            // 
            this.textD1.AutoSize = true;
            this.textD1.Location = new System.Drawing.Point(28, 43);
            this.textD1.Name = "textD1";
            this.textD1.Size = new System.Drawing.Size(61, 13);
            this.textD1.TabIndex = 33;
            this.textD1.Text = "Тип ремня";
            this.textD1.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Значение ToI";
            this.label4.Click += new System.EventHandler(this.label4_Click_3);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Значение Sh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Значение F";
            // 
            // f
            // 
            this.f.Location = new System.Drawing.Point(227, 149);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(90, 20);
            this.f.TabIndex = 46;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(28, 183);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(84, 13);
            this.a.TabIndex = 49;
            this.a.Text = "Значение alpha";
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(226, 183);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(90, 20);
            this.alpha.TabIndex = 48;
            // 
            // choose
            // 
            this.choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose.FormattingEnabled = true;
            this.choose.Items.AddRange(new object[] {
            "прорезиненный ремень малое постоянное межосевое расстояние",
            "прорезиненный ремень постоянное достаточное",
            "прорезиненный ремень периодически регулируемое",
            "синтетический ремень периодически регулируемое",
            "прорезиненный ремень автоматически регулируемое постоянное натяжение",
            "прорезиненный ремень автомат. рег. переменное",
            "синтетический ремень авт. рег. пост.",
            "синтетический ремень авт. рег. пер."});
            this.choose.Location = new System.Drawing.Point(227, 41);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(457, 21);
            this.choose.TabIndex = 57;
            // 
            // tk
            // 
            this.tk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tk.FormattingEnabled = true;
            this.tk.Items.AddRange(new object[] {
            "прорезиненная ",
            "синтетическая 1 тип ",
            "синтетическая 2 тип"});
            this.tk.Location = new System.Drawing.Point(226, 219);
            this.tk.Name = "tk";
            this.tk.Size = new System.Drawing.Size(457, 21);
            this.tk.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Тип ремня Tk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Значение v";
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(227, 260);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(90, 20);
            this.v.TabIndex = 60;
            // 
            // tol
            // 
            this.tol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tol.FormattingEnabled = true;
            this.tol.Items.AddRange(new object[] {
            "0.4",
            "0.5",
            "0.6",
            "1.0",
            "1.1",
            "1.2",
            "3.0",
            "3.6",
            "3.75",
            "4.0",
            "4.5",
            "4.8",
            "5.0",
            "6.0",
            "6.25",
            "7.2",
            "7.5",
            "9.0"});
            this.tol.Location = new System.Drawing.Point(227, 75);
            this.tol.Name = "tol";
            this.tol.Size = new System.Drawing.Size(457, 21);
            this.tol.TabIndex = 62;
            this.tol.SelectedIndexChanged += new System.EventHandler(this.tol_SelectedIndexChanged);
            // 
            // nat
            // 
            this.nat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nat.FormattingEnabled = true;
            this.nat.Items.AddRange(new object[] {
            "автоматическое ",
            "неавтоматическое"});
            this.nat.Location = new System.Drawing.Point(226, 296);
            this.nat.Name = "nat";
            this.nat.Size = new System.Drawing.Size(457, 21);
            this.nat.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Тип натяжения";
            // 
            // sh
            // 
            this.sh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sh.FormattingEnabled = true;
            this.sh.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "60",
            "80",
            "100",
            "112",
            "250"});
            this.sh.Location = new System.Drawing.Point(226, 111);
            this.sh.Name = "sh";
            this.sh.Size = new System.Drawing.Size(457, 21);
            this.sh.TabIndex = 65;
            this.sh.SelectedIndexChanged += new System.EventHandler(this.sh_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Результаты";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.answerQ0);
            this.groupBox1.Controls.Add(this.answerR);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(332, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 109);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 67;
            this.label10.Text = "R:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Q0:";
            // 
            // answerR
            // 
            this.answerR.AutoSize = true;
            this.answerR.Location = new System.Drawing.Point(70, 40);
            this.answerR.Name = "answerR";
            this.answerR.Size = new System.Drawing.Size(0, 13);
            this.answerR.TabIndex = 69;
            this.answerR.Click += new System.EventHandler(this.label12_Click);
            // 
            // answerQ0
            // 
            this.answerQ0.AutoSize = true;
            this.answerQ0.Location = new System.Drawing.Point(70, 66);
            this.answerQ0.Name = "answerQ0";
            this.answerQ0.Size = new System.Drawing.Size(0, 13);
            this.answerQ0.TabIndex = 71;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(209, 16);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 72;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(744, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sh);
            this.Controls.Add(this.nat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.v);
            this.Controls.Add(this.tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.a);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.f);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textD1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Kbe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kbe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textD1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox f;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox alpha;
        private System.Windows.Forms.ComboBox choose;
        private System.Windows.Forms.ComboBox tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox v;
        private System.Windows.Forms.ComboBox tol;
        private System.Windows.Forms.ComboBox nat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label answerR;
        private System.Windows.Forms.Label answerQ0;
        private System.Windows.Forms.Label result;
    }
}

