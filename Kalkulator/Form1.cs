using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox_Hitung.HorizontalScrollbar = true;
                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_Hitung.DrawMode = DrawMode.OwnerDrawFixed;
            string input = textBox_Calc.Text;
            string[] hasil;
            Calculator calc=new Calculator(input);
            calc.validasi();
            listBox_Hitung.Items.Clear();
            if (calc.cekError == true)
            {
                calc.convert();
                if (calc.cekError == true)
                {
                    hasil = calc.aritmatika();
                    listBox_Hitung.Items.AddRange(hasil);
                }
                else
                    MessageBox.Show("Input False");
            }
            else
                MessageBox.Show("Input False");
        }

        private void textBox_Calc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                listBox_Hitung.DrawMode = DrawMode.OwnerDrawFixed;
                string input = textBox_Calc.Text;
                string[] hasil;
                Calculator calc = new Calculator(input);
                calc.validasi();
                listBox_Hitung.Items.Clear();
                if (calc.cekError == true)
                {
                    calc.convert();
                    if (calc.cekError == true)
                    {
                        hasil = calc.aritmatika();
                        listBox_Hitung.Items.AddRange(hasil);
                    }
                    else
                        MessageBox.Show("Input False");
                }
                else
                    MessageBox.Show("Input False");
            }
        }

        public bool cekSatuanInput(int basisDari,string input)
        {
            if (basisDari == 2)
            {
                foreach (char i in input)
                    if (i != '0' && i != '1')
                        return false;
                return true;
            }
            else if (basisDari == 8)
            {
                foreach (char i in input)
                    if (i < '0' || i > '7')
                        return false;
                return true;
            }
            else if (basisDari == 10)
            {
                foreach (char i in input)
                    if (!char.IsDigit(i))
                        return false;
                return true;
            }
            else
            {
                foreach (char i in input)
                    if (!char.IsDigit(i) && (i != 'A' && i != 'B' && i != 'C' && i != 'D' && i != 'E' && i != 'F'))
                        return false;
                return true;
            }
        }
        private void buttonSamaDengan_bilangan_Click(object sender, EventArgs e)
        {
            string tmpnilai = input_bilangan.Text;
            string nilai = "";
            for (int i = 0; i < tmpnilai.Length; i++) //Lower to Upper
            {
                if (Char.IsLower(tmpnilai[i]))
                    nilai += char.ToUpper(tmpnilai[i]);
                else
                    nilai += tmpnilai[i];
            }
            int basisDari = 0;
            int basisKe = 0;
            if (Binner1.Checked)
                basisDari = 2;
            else if (Decimal1.Checked)
                basisDari = 10;
            else if(Octal1.Checked)
                basisDari = 8;
            else if (Hexadecimal1.Checked)
                basisDari = 16;

            if (Binner2.Checked)
                basisKe = 2;
            else if (Octal2.Checked)
                basisKe = 8;
            else if(Decimal2.Checked)
                basisKe = 10;
            else if (Hexadecimal2.Checked)
                basisKe = 16;

            if (cekSatuanInput(basisDari, nilai))
            {
                ConversiBilangan bil = new ConversiBilangan(basisDari, basisKe, nilai);
                hasil_bilangan.Text = bil.hitung();
            }
            else
                MessageBox.Show("Input False");
        }

        private void input_bilangan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                string tmpnilai = input_bilangan.Text;
                string nilai = "";
                for (int i = 0; i < tmpnilai.Length; i++) //Lower to Upper
                {
                    if (Char.IsLower(tmpnilai[i]))
                        nilai += char.ToUpper(tmpnilai[i]);
                    else
                        nilai += tmpnilai[i];
                }
                int basisDari = 0;
                int basisKe = 0;
                if (Binner1.Checked)
                    basisDari = 2;
                else if (Decimal1.Checked)
                    basisDari = 10;
                else if (Octal1.Checked)
                    basisDari = 8;
                else if (Hexadecimal1.Checked)
                    basisDari = 16;

                if (Binner2.Checked)
                    basisKe = 2;
                else if (Octal2.Checked)
                    basisKe = 8;
                else if (Decimal2.Checked)
                    basisKe = 10;
                else if (Hexadecimal2.Checked)
                    basisKe = 16;

                if (cekSatuanInput(basisDari, nilai))
                {
                    ConversiBilangan bil = new ConversiBilangan(basisDari, basisKe, nilai);
                    hasil_bilangan.Text = bil.hitung();
                }
                else
                    MessageBox.Show("Input False");
            }
        }

        private int Konversi_Satuan = 0;
        private void radioButton_Panjang_CheckedChanged(object sender, EventArgs e)
        {
            Konversi_Satuan = 1;
            comboBox_1.Items.Clear();
            comboBox_1.Text = "";
            string[] item ={
                        "Kilometer",
                        "Hektometer",
                        "Dekameter",
                        "Meter",
                        "Desimeter",
                        "Sentimeter",
                        "Milimeter",
                        "Mikrometer",
                        "Nanometer",
                        "Inci",
                        "Kaki",
                        "Mil",
                        "Yard",
                        "Mil Laut",
            };
            comboBox_1.Items.AddRange(item);
        }

        private void radioButton_Luas_CheckedChanged(object sender, EventArgs e)
        {
            Konversi_Satuan = 2;
            comboBox_1.Items.Clear();
            comboBox_1.Text = "";
            string[] item ={
                                "Kilometer persegi",
                                "Hektar",
                                "Meter persegi",
                                "Sentimeter persegi",
                                "Milimeter persegi",
                                "Mil persegi",
                                "Acre",
                                "Yard persegi",
                                "Kaki persegi",
                                "Inci persegi",
                           };
            comboBox_1.Items.AddRange(item);
        }
        private void radioButtonBerat_CheckedChanged(object sender, EventArgs e)
        {
            Konversi_Satuan = 3;
            comboBox_1.Items.Clear();
            comboBox_1.Text = "";
            string[] item ={
                            "Ton",
                            "Kilogram",
                            "Hektogram",
                            "Dekagram",
                            "Gram",
                            "Desigram",
                            "Karat",
                            "Centigram",
                            "Miligram",
                           };
            comboBox_1.Items.AddRange(item);
        }
        private void radioButtonData_CheckedChanged(object sender, EventArgs e)
        {
            Konversi_Satuan = 4;
            comboBox_1.Items.Clear();
            comboBox_1.Text = "";
            string[] item ={
                            "Bit","Byte","Kilobit","Kilobyte","Megabit","Megabyte","Gigabit","Gigabyte","Terabit","Terabyte","Petabit","Petabyte"
                           };
            comboBox_1.Items.AddRange(item);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Konversi_Satuan == 0 || comboBox_1.SelectedIndex==-1)
            {
                MessageBox.Show("Pilih Satuan Yang akan Di konversi...");
            }
            else if (Konversi_Satuan == 1)
            {
                listBox_Satuan_Hasil.DrawMode = DrawMode.OwnerDrawFixed;
                listBox_Satuan_Hasil.Items.Clear();
                int konversi_Dari = comboBox_1.SelectedIndex;
                string dari = comboBox_1.Text.Trim();
                bool cek = true;
                foreach (char i in textBox_Satuan_Input.Text)
                    if(i=='.')
                    {
                        MessageBox.Show("Input False");
                        cek = false;
                        break;
                    }
                if(cek==true)
                    for (int i = 0; i < comboBox_1.Items.Count; i++)
                    {
                        try
                        {
                            KonversiSatuan konv = new KonversiSatuan(dari, comboBox_1.Items[i].ToString().Trim(), Convert.ToDouble(textBox_Satuan_Input.Text));
                            listBox_Satuan_Hasil.Items.Add(comboBox_1.Items[i].ToString().PadRight(15) + " = " + konv.Panjang());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Input False");
                            break;
                        }
                    
                    }
            }
            else if (Konversi_Satuan == 2)
            {
                listBox_Satuan_Hasil.DrawMode = DrawMode.OwnerDrawFixed;
                listBox_Satuan_Hasil.Items.Clear();
                int konversi_Dari = comboBox_1.SelectedIndex;
                string dari = comboBox_1.Text.Trim();
                bool cek = true;
                foreach (char i in textBox_Satuan_Input.Text)
                if (i == '.')
                {
                    MessageBox.Show("Input False");
                    cek = false;
                    break;
                }
                if (cek == true)
                    for (int i = 0; i < comboBox_1.Items.Count; i++)
                    {
                        try
                        {
                            KonversiSatuan konv = new KonversiSatuan(dari, comboBox_1.Items[i].ToString().Trim(), Convert.ToDouble(textBox_Satuan_Input.Text));
                            listBox_Satuan_Hasil.Items.Add(comboBox_1.Items[i] + "= " + konv.Area());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Input False");
                            break;
                        }
                    }
            }
            else if (Konversi_Satuan == 3)
            {
                listBox_Satuan_Hasil.DrawMode = DrawMode.OwnerDrawFixed;
                listBox_Satuan_Hasil.Items.Clear();
                int konversi_Dari = comboBox_1.SelectedIndex;
                string dari = comboBox_1.Text.Trim();
                bool cek = true;
                foreach (char i in textBox_Satuan_Input.Text)
                if (i == '.')
                {
                    MessageBox.Show("Input False");
                    cek = false;
                    break;
                }
                if (cek == true)
                    for (int i = 0; i < comboBox_1.Items.Count; i++)
                    {
                        try { 
                        KonversiSatuan konv = new KonversiSatuan(dari, comboBox_1.Items[i].ToString().Trim(), Convert.ToDouble(textBox_Satuan_Input.Text));
                        listBox_Satuan_Hasil.Items.Add(comboBox_1.Items[i] + "= " + konv.Berat());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Input False");
                            break;
                        }
                    }
            }
            else if (Konversi_Satuan == 4)
            {
                listBox_Satuan_Hasil.DrawMode = DrawMode.OwnerDrawFixed;
                listBox_Satuan_Hasil.Items.Clear();
                int konversi_Dari = comboBox_1.SelectedIndex;
                string dari = comboBox_1.Text.Trim();
                bool cek = true;
                foreach (char i in textBox_Satuan_Input.Text)
                if (i == '.')
                {
                    MessageBox.Show("Input False");
                    cek = false;
                    break;
                }
                if (cek == true)
                    for (int i = 0; i < comboBox_1.Items.Count; i++)
                    {
                        try { 
                        KonversiSatuan konv = new KonversiSatuan(dari, comboBox_1.Items[i].ToString().Trim(), Convert.ToDouble(textBox_Satuan_Input.Text));
                        listBox_Satuan_Hasil.Items.Add(comboBox_1.Items[i] + "= " + konv.Data());
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Input False");
                            break;
                        }
                    }
            }
        }
        private void listBox_Hitung_DrawItem(object sender, DrawItemEventArgs e)
        {
               
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            SolidBrush backgroundColorBrush;
            if (e.Index % 2 == 0)
            {
                myBrush = Brushes.Black;
                backgroundColorBrush = new SolidBrush(Color.White);
            }
            else
            {
                myBrush = Brushes.White;
                backgroundColorBrush = new SolidBrush(Color.BlueViolet);
            }
            e.Graphics.FillRectangle(backgroundColorBrush, e.Bounds);
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            
            //e.DrawFocusRectangle();
        }
        private void listBox_Satuan_Hasil_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            SolidBrush backgroundColorBrush;
            if (e.Index % 2 == 0)
            {
                myBrush = Brushes.Black;
                backgroundColorBrush = new SolidBrush(Color.White);
            }
            else
            {
                myBrush = Brushes.White;
                backgroundColorBrush = new SolidBrush(Color.BlueViolet);
            }
            e.Graphics.FillRectangle(backgroundColorBrush, e.Bounds);
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
        }
        private void textBox_Satuan_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Enter))
            {
                if (Konversi_Satuan == 0 || comboBox_1.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih Satuan Yang akan Di konversi...");
                }
                else if (Konversi_Satuan == 1)
                {
                    listBox_Satuan_Hasil.DrawMode = DrawMode.OwnerDrawFixed;
                    listBox_Satuan_Hasil.Items.Clear();
                    int konversi_Dari = comboBox_1.SelectedIndex;
                    string dari = comboBox_1.Text.Trim();
                    bool cek = true;
                    foreach (char i in textBox_Satuan_Input.Text)
                        if (i == '.')
                        {
                            MessageBox.Show("Input False");
                            cek = false;
                            break;
                        }
                    if (cek == true)
                        for (int i = 0; i < comboBox_1.Items.Count; i++)
                        {
                            try
                            {
                                KonversiSatuan konv = new KonversiSatuan(dari, comboBox_1.Items[i].ToString().Trim(), Convert.ToDouble(textBox_Satuan_Input.Text));
                                listBox_Satuan_Hasil.Items.Add(comboBox_1.Items[i].ToString().PadRight(15) + " = " + konv.Panjang());
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Input False");
                                break;
                            }

                        }
                }
                else if (Konversi_Satuan == 2)
                {
                    listBox_Satuan_Hasil.DrawMode = DrawMode.OwnerDrawFixed;
                    listBox_Satuan_Hasil.Items.Clear();
                    int konversi_Dari = comboBox_1.SelectedIndex;
                    string dari = comboBox_1.Text.Trim();
                    bool cek = true;
                    foreach (char i in textBox_Satuan_Input.Text)
                        if (i == '.')
                        {
                            MessageBox.Show("Input False");
                            cek = false;
                            break;
                        }
                    if (cek == true)
                        for (int i = 0; i < comboBox_1.Items.Count; i++)
                        {
                            try
                            {
                                KonversiSatuan konv = new KonversiSatuan(dari, comboBox_1.Items[i].ToString().Trim(), Convert.ToDouble(textBox_Satuan_Input.Text));
                                listBox_Satuan_Hasil.Items.Add(comboBox_1.Items[i] + "= " + konv.Area());
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Input False");
                                break;
                            }
                        }
                }
                else if (Konversi_Satuan == 3)
                {
                    listBox_Satuan_Hasil.DrawMode = DrawMode.OwnerDrawFixed;
                    listBox_Satuan_Hasil.Items.Clear();
                    int konversi_Dari = comboBox_1.SelectedIndex;
                    string dari = comboBox_1.Text.Trim();
                    bool cek = true;
                    foreach (char i in textBox_Satuan_Input.Text)
                        if (i == '.')
                        {
                            MessageBox.Show("Input False");
                            cek = false;
                            break;
                        }
                    if (cek == true)
                        for (int i = 0; i < comboBox_1.Items.Count; i++)
                        {
                            try
                            {
                                KonversiSatuan konv = new KonversiSatuan(dari, comboBox_1.Items[i].ToString().Trim(), Convert.ToDouble(textBox_Satuan_Input.Text));
                                listBox_Satuan_Hasil.Items.Add(comboBox_1.Items[i] + "= " + konv.Berat());
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Input False");
                                break;
                            }
                        }
                }
                else if (Konversi_Satuan == 4)
                {
                    listBox_Satuan_Hasil.DrawMode = DrawMode.OwnerDrawFixed;
                    listBox_Satuan_Hasil.Items.Clear();
                    int konversi_Dari = comboBox_1.SelectedIndex;
                    string dari = comboBox_1.Text.Trim();
                    bool cek = true;
                    foreach (char i in textBox_Satuan_Input.Text)
                        if (i == '.')
                        {
                            MessageBox.Show("Input False");
                            cek = false;
                            break;
                        }
                    if (cek == true)
                        for (int i = 0; i < comboBox_1.Items.Count; i++)
                        {
                            try
                            {
                                KonversiSatuan konv = new KonversiSatuan(dari, comboBox_1.Items[i].ToString().Trim(), Convert.ToDouble(textBox_Satuan_Input.Text));
                                listBox_Satuan_Hasil.Items.Add(comboBox_1.Items[i] + "= " + konv.Data());
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Input False");
                                break;
                            }
                        }
                }

            }
        }
    }
}
