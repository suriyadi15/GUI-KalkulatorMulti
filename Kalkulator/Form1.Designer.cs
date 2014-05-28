namespace Kalkulator
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Hitung = new System.Windows.Forms.ListBox();
            this.buttonSamadengan = new System.Windows.Forms.Button();
            this.textBox_Calc = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_Satuan_Hasil = new System.Windows.Forms.ListBox();
            this.textBox_Satuan_Input = new System.Windows.Forms.TextBox();
            this.comboBox_1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonData = new System.Windows.Forms.RadioButton();
            this.radioButtonBerat = new System.Windows.Forms.RadioButton();
            this.radioButton_Luas = new System.Windows.Forms.RadioButton();
            this.radioButton_Panjang = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hasil_bilangan = new System.Windows.Forms.Label();
            this.buttonSamaDengan_bilangan = new System.Windows.Forms.Button();
            this.input_bilangan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Hexadecimal2 = new System.Windows.Forms.RadioButton();
            this.Octal2 = new System.Windows.Forms.RadioButton();
            this.Decimal2 = new System.Windows.Forms.RadioButton();
            this.Binner2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Hexadecimal1 = new System.Windows.Forms.RadioButton();
            this.Octal1 = new System.Windows.Forms.RadioButton();
            this.Decimal1 = new System.Windows.Forms.RadioButton();
            this.Binner1 = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(439, 304);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBox_Hitung);
            this.tabPage1.Controls.Add(this.buttonSamadengan);
            this.tabPage1.Controls.Add(this.textBox_Calc);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hitung";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hitung";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox_Hitung
            // 
            this.listBox_Hitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Hitung.FormattingEnabled = true;
            this.listBox_Hitung.ItemHeight = 16;
            this.listBox_Hitung.Location = new System.Drawing.Point(6, 48);
            this.listBox_Hitung.Name = "listBox_Hitung";
            this.listBox_Hitung.ScrollAlwaysVisible = true;
            this.listBox_Hitung.Size = new System.Drawing.Size(419, 228);
            this.listBox_Hitung.TabIndex = 5;
            this.listBox_Hitung.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_Hitung_DrawItem);
            // 
            // buttonSamadengan
            // 
            this.buttonSamadengan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSamadengan.Location = new System.Drawing.Point(388, 16);
            this.buttonSamadengan.Name = "buttonSamadengan";
            this.buttonSamadengan.Size = new System.Drawing.Size(40, 26);
            this.buttonSamadengan.TabIndex = 2;
            this.buttonSamadengan.Text = "=";
            this.buttonSamadengan.UseVisualStyleBackColor = true;
            this.buttonSamadengan.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Calc
            // 
            this.textBox_Calc.BackColor = System.Drawing.Color.Azure;
            this.textBox_Calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Calc.Location = new System.Drawing.Point(63, 16);
            this.textBox_Calc.Name = "textBox_Calc";
            this.textBox_Calc.Size = new System.Drawing.Size(319, 26);
            this.textBox_Calc.TabIndex = 1;
            this.textBox_Calc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Calc_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listBox_Satuan_Hasil);
            this.tabPage2.Controls.Add(this.textBox_Satuan_Input);
            this.tabPage2.Controls.Add(this.comboBox_1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(431, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Konversi Satuan";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dari";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox_Satuan_Hasil
            // 
            this.listBox_Satuan_Hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Satuan_Hasil.FormattingEnabled = true;
            this.listBox_Satuan_Hasil.ItemHeight = 16;
            this.listBox_Satuan_Hasil.Location = new System.Drawing.Point(6, 89);
            this.listBox_Satuan_Hasil.Name = "listBox_Satuan_Hasil";
            this.listBox_Satuan_Hasil.ScrollAlwaysVisible = true;
            this.listBox_Satuan_Hasil.Size = new System.Drawing.Size(419, 180);
            this.listBox_Satuan_Hasil.TabIndex = 4;
            this.listBox_Satuan_Hasil.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_Satuan_Hasil_DrawItem);
            // 
            // textBox_Satuan_Input
            // 
            this.textBox_Satuan_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Satuan_Input.Location = new System.Drawing.Point(185, 54);
            this.textBox_Satuan_Input.Name = "textBox_Satuan_Input";
            this.textBox_Satuan_Input.Size = new System.Drawing.Size(190, 23);
            this.textBox_Satuan_Input.TabIndex = 2;
            this.textBox_Satuan_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Satuan_Input_KeyDown);
            // 
            // comboBox_1
            // 
            this.comboBox_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_1.FormattingEnabled = true;
            this.comboBox_1.Location = new System.Drawing.Point(60, 54);
            this.comboBox_1.Name = "comboBox_1";
            this.comboBox_1.Size = new System.Drawing.Size(115, 24);
            this.comboBox_1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.radioButtonData);
            this.groupBox3.Controls.Add(this.radioButtonBerat);
            this.groupBox3.Controls.Add(this.radioButton_Luas);
            this.groupBox3.Controls.Add(this.radioButton_Panjang);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 42);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satuan";
            // 
            // radioButtonData
            // 
            this.radioButtonData.AutoSize = true;
            this.radioButtonData.Location = new System.Drawing.Point(179, 19);
            this.radioButtonData.Name = "radioButtonData";
            this.radioButtonData.Size = new System.Drawing.Size(48, 17);
            this.radioButtonData.TabIndex = 4;
            this.radioButtonData.TabStop = true;
            this.radioButtonData.Text = "Data";
            this.radioButtonData.UseVisualStyleBackColor = true;
            this.radioButtonData.CheckedChanged += new System.EventHandler(this.radioButtonData_CheckedChanged);
            // 
            // radioButtonBerat
            // 
            this.radioButtonBerat.AutoSize = true;
            this.radioButtonBerat.Location = new System.Drawing.Point(130, 19);
            this.radioButtonBerat.Name = "radioButtonBerat";
            this.radioButtonBerat.Size = new System.Drawing.Size(50, 17);
            this.radioButtonBerat.TabIndex = 3;
            this.radioButtonBerat.TabStop = true;
            this.radioButtonBerat.Text = "Berat";
            this.radioButtonBerat.UseVisualStyleBackColor = true;
            this.radioButtonBerat.CheckedChanged += new System.EventHandler(this.radioButtonBerat_CheckedChanged);
            // 
            // radioButton_Luas
            // 
            this.radioButton_Luas.AutoSize = true;
            this.radioButton_Luas.Location = new System.Drawing.Point(77, 20);
            this.radioButton_Luas.Name = "radioButton_Luas";
            this.radioButton_Luas.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Luas.TabIndex = 1;
            this.radioButton_Luas.TabStop = true;
            this.radioButton_Luas.Text = "Area";
            this.radioButton_Luas.UseVisualStyleBackColor = true;
            this.radioButton_Luas.CheckedChanged += new System.EventHandler(this.radioButton_Luas_CheckedChanged);
            // 
            // radioButton_Panjang
            // 
            this.radioButton_Panjang.AutoSize = true;
            this.radioButton_Panjang.Location = new System.Drawing.Point(7, 20);
            this.radioButton_Panjang.Name = "radioButton_Panjang";
            this.radioButton_Panjang.Size = new System.Drawing.Size(64, 17);
            this.radioButton_Panjang.TabIndex = 0;
            this.radioButton_Panjang.TabStop = true;
            this.radioButton_Panjang.Text = "Panjang";
            this.radioButton_Panjang.UseVisualStyleBackColor = true;
            this.radioButton_Panjang.CheckedChanged += new System.EventHandler(this.radioButton_Panjang_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage3.Controls.Add(this.hasil_bilangan);
            this.tabPage3.Controls.Add(this.buttonSamaDengan_bilangan);
            this.tabPage3.Controls.Add(this.input_bilangan);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(431, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Konversi Bilangan";
            // 
            // hasil_bilangan
            // 
            this.hasil_bilangan.BackColor = System.Drawing.Color.White;
            this.hasil_bilangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil_bilangan.Location = new System.Drawing.Point(117, 96);
            this.hasil_bilangan.Name = "hasil_bilangan";
            this.hasil_bilangan.Size = new System.Drawing.Size(308, 169);
            this.hasil_bilangan.TabIndex = 4;
            // 
            // buttonSamaDengan_bilangan
            // 
            this.buttonSamaDengan_bilangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSamaDengan_bilangan.Location = new System.Drawing.Point(246, 58);
            this.buttonSamaDengan_bilangan.Name = "buttonSamaDengan_bilangan";
            this.buttonSamaDengan_bilangan.Size = new System.Drawing.Size(49, 23);
            this.buttonSamaDengan_bilangan.TabIndex = 3;
            this.buttonSamaDengan_bilangan.Text = "=";
            this.buttonSamaDengan_bilangan.UseVisualStyleBackColor = true;
            this.buttonSamaDengan_bilangan.Click += new System.EventHandler(this.buttonSamaDengan_bilangan_Click);
            // 
            // input_bilangan
            // 
            this.input_bilangan.Location = new System.Drawing.Point(120, 27);
            this.input_bilangan.Name = "input_bilangan";
            this.input_bilangan.Size = new System.Drawing.Size(305, 20);
            this.input_bilangan.TabIndex = 2;
            this.input_bilangan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_bilangan_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Hexadecimal2);
            this.groupBox2.Controls.Add(this.Octal2);
            this.groupBox2.Controls.Add(this.Decimal2);
            this.groupBox2.Controls.Add(this.Binner2);
            this.groupBox2.Location = new System.Drawing.Point(6, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert To";
            // 
            // Hexadecimal2
            // 
            this.Hexadecimal2.AutoSize = true;
            this.Hexadecimal2.Location = new System.Drawing.Point(7, 92);
            this.Hexadecimal2.Name = "Hexadecimal2";
            this.Hexadecimal2.Size = new System.Drawing.Size(86, 17);
            this.Hexadecimal2.TabIndex = 3;
            this.Hexadecimal2.TabStop = true;
            this.Hexadecimal2.Text = "Hexadecimal";
            this.Hexadecimal2.UseVisualStyleBackColor = true;
            // 
            // Octal2
            // 
            this.Octal2.AutoSize = true;
            this.Octal2.Location = new System.Drawing.Point(7, 68);
            this.Octal2.Name = "Octal2";
            this.Octal2.Size = new System.Drawing.Size(50, 17);
            this.Octal2.TabIndex = 2;
            this.Octal2.TabStop = true;
            this.Octal2.Text = "Octal";
            this.Octal2.UseVisualStyleBackColor = true;
            // 
            // Decimal2
            // 
            this.Decimal2.AutoSize = true;
            this.Decimal2.Location = new System.Drawing.Point(7, 44);
            this.Decimal2.Name = "Decimal2";
            this.Decimal2.Size = new System.Drawing.Size(63, 17);
            this.Decimal2.TabIndex = 1;
            this.Decimal2.TabStop = true;
            this.Decimal2.Text = "Decimal";
            this.Decimal2.UseVisualStyleBackColor = true;
            // 
            // Binner2
            // 
            this.Binner2.AutoSize = true;
            this.Binner2.Checked = true;
            this.Binner2.Location = new System.Drawing.Point(7, 20);
            this.Binner2.Name = "Binner2";
            this.Binner2.Size = new System.Drawing.Size(55, 17);
            this.Binner2.TabIndex = 0;
            this.Binner2.TabStop = true;
            this.Binner2.Text = "Binner";
            this.Binner2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.Hexadecimal1);
            this.groupBox1.Controls.Add(this.Octal1);
            this.groupBox1.Controls.Add(this.Decimal1);
            this.groupBox1.Controls.Add(this.Binner1);
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert From";
            // 
            // Hexadecimal1
            // 
            this.Hexadecimal1.AutoSize = true;
            this.Hexadecimal1.Location = new System.Drawing.Point(7, 92);
            this.Hexadecimal1.Name = "Hexadecimal1";
            this.Hexadecimal1.Size = new System.Drawing.Size(86, 17);
            this.Hexadecimal1.TabIndex = 3;
            this.Hexadecimal1.TabStop = true;
            this.Hexadecimal1.Text = "Hexadecimal";
            this.Hexadecimal1.UseVisualStyleBackColor = true;
            // 
            // Octal1
            // 
            this.Octal1.AutoSize = true;
            this.Octal1.Location = new System.Drawing.Point(7, 68);
            this.Octal1.Name = "Octal1";
            this.Octal1.Size = new System.Drawing.Size(50, 17);
            this.Octal1.TabIndex = 2;
            this.Octal1.TabStop = true;
            this.Octal1.Text = "Octal";
            this.Octal1.UseVisualStyleBackColor = true;
            // 
            // Decimal1
            // 
            this.Decimal1.AutoSize = true;
            this.Decimal1.Location = new System.Drawing.Point(7, 44);
            this.Decimal1.Name = "Decimal1";
            this.Decimal1.Size = new System.Drawing.Size(63, 17);
            this.Decimal1.TabIndex = 1;
            this.Decimal1.TabStop = true;
            this.Decimal1.Text = "Decimal";
            this.Decimal1.UseVisualStyleBackColor = true;
            // 
            // Binner1
            // 
            this.Binner1.AutoSize = true;
            this.Binner1.Checked = true;
            this.Binner1.Location = new System.Drawing.Point(7, 20);
            this.Binner1.Name = "Binner1";
            this.Binner1.Size = new System.Drawing.Size(55, 17);
            this.Binner1.TabIndex = 0;
            this.Binner1.TabStop = true;
            this.Binner1.Text = "Binner";
            this.Binner1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 324);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator Multi";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonSamadengan;
        private System.Windows.Forms.TextBox textBox_Calc;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Hexadecimal1;
        private System.Windows.Forms.RadioButton Octal1;
        private System.Windows.Forms.RadioButton Decimal1;
        private System.Windows.Forms.RadioButton Binner1;
        private System.Windows.Forms.TextBox input_bilangan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Hexadecimal2;
        private System.Windows.Forms.RadioButton Octal2;
        private System.Windows.Forms.RadioButton Decimal2;
        private System.Windows.Forms.RadioButton Binner2;
        private System.Windows.Forms.Button buttonSamaDengan_bilangan;
        private System.Windows.Forms.Label hasil_bilangan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonBerat;
        private System.Windows.Forms.RadioButton radioButton_Luas;
        private System.Windows.Forms.RadioButton radioButton_Panjang;
        private System.Windows.Forms.TextBox textBox_Satuan_Input;
        private System.Windows.Forms.ComboBox comboBox_1;
        private System.Windows.Forms.ListBox listBox_Hitung;
        private System.Windows.Forms.ListBox listBox_Satuan_Hasil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonData;



    }
}

