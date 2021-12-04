
namespace BMICalculator
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Standard = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BMIht = new System.Windows.Forms.TextBox();
            this.BMIwt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalcBMI = new System.Windows.Forms.TextBox();
            this.Weight = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Standard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(27, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "CALCULATE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(437, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "RESET BMI";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(897, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "STORE BMI";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit.Location = new System.Drawing.Point(997, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 36);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(330, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(386, 36);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "BMI CALCULATOR";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Standard
            // 
            this.Standard.Controls.Add(this.tabPage1);
            this.Standard.Controls.Add(this.tabPage2);
            this.Standard.Location = new System.Drawing.Point(12, 45);
            this.Standard.Name = "Standard";
            this.Standard.SelectedIndex = 0;
            this.Standard.Size = new System.Drawing.Size(1060, 353);
            this.Standard.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BMIht);
            this.tabPage1.Controls.Add(this.BMIwt);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.checkedListBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BMIht
            // 
            this.BMIht.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BMIht.Location = new System.Drawing.Point(195, 155);
            this.BMIht.Multiline = true;
            this.BMIht.Name = "BMIht";
            this.BMIht.Size = new System.Drawing.Size(100, 23);
            this.BMIht.TabIndex = 23;
            this.BMIht.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BMIwt
            // 
            this.BMIwt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BMIwt.Location = new System.Drawing.Point(195, 197);
            this.BMIwt.Multiline = true;
            this.BMIwt.Name = "BMIwt";
            this.BMIwt.Size = new System.Drawing.Size(100, 23);
            this.BMIwt.TabIndex = 22;
            this.BMIwt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(195, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "CALCULATED BMI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "WEIGHT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "HEIGHT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(11, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "GENDER";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Prefer Not to Say"});
            this.checkedListBox2.Location = new System.Drawing.Point(195, 57);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 58);
            this.checkedListBox2.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.checkedListBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1052, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Metric";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(195, 142);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 31;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(195, 184);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 30;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox8.Location = new System.Drawing.Point(195, 230);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 29);
            this.textBox8.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "CALCULATED BMI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "WEIGHT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(11, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "HEIGHT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(11, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "GENDER";
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Prefer Not to Say"});
            this.checkedListBox3.Location = new System.Drawing.Point(195, 44);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(120, 58);
            this.checkedListBox3.TabIndex = 24;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Prefer Not to Say"});
            this.checkedListBox1.Location = new System.Drawing.Point(211, 126);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 58);
            this.checkedListBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "HEIGHT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "WEIGHT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "CALCULATED BMI";
            // 
            // CalcBMI
            // 
            this.CalcBMI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalcBMI.Location = new System.Drawing.Point(211, 312);
            this.CalcBMI.Name = "CalcBMI";
            this.CalcBMI.Size = new System.Drawing.Size(100, 29);
            this.CalcBMI.TabIndex = 13;
            // 
            // Weight
            // 
            this.Weight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Weight.Location = new System.Drawing.Point(211, 266);
            this.Weight.Multiline = true;
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(100, 23);
            this.Weight.TabIndex = 14;
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Height.Location = new System.Drawing.Point(211, 224);
            this.Height.Multiline = true;
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 23);
            this.Height.TabIndex = 15;
            this.Height.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Standard);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.CalcBMI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalc";
            this.Standard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabControl Standard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CalcBMI;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox BMIht;
        private System.Windows.Forms.TextBox BMIwt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

