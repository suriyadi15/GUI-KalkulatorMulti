﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kalkulator
{
    class Calculator
    {
        private string inp { set; get; } //Declare string input for menampung masukkan
        private ArrayList arr;
        public bool cekError;  //True jika Tidak ada Error
        public Calculator(string inp)  //declare Constructore
        {
            this.inp = inp;
            arr = new ArrayList();
            cekError = true;
        }
        public void validasi()
        {
            if (inp == "" || inp.Length == 1)  //Validasi
            {
                cekError = false;
            }
            else  //Validasi
            {
                foreach (char i in inp)
                {
                    if (!Char.IsDigit(i) && i != '^' && i != '*' && i != '/' && i != '+' && i != '-' && i != '(' && i != ')' && i != ',')
                    {
                        cekError = false;
                        break;
                    }
                }
                for (int i = 1; i < inp.Length; i++)
                {
                    if (inp[i - 1] == '(' && inp[i] == ')')
                    {
                        cekError = false;
                        break;
                    }
                    if (inp[i - 1] == ')' && inp[i] == '(')
                    {
                        cekError = false;
                        break;
                    }
                }
                if (inp[0] == ')')
                    cekError = false;
                if (inp[inp.Length - 1] == '(')
                    cekError = false;
            }
        }
        public void convert()
        {
            string tmp = "";  //untuk tempat sementara bilangan
            if (inp[0] != '(' && inp[0] != ')' && inp[0] != '^' && inp[0] != '*' && inp[0] != '/' && inp[0] != '+')
                tmp += inp[0];
            else if (inp[0] == '(')
                arr.Add(inp[0]);
            else
                cekError = true;
            if (cekError == true)
            {
                for (int i = 1; i < inp.Length; i++) //for dari inp[1] bukan inp[0]
                {
                    if (inp[i] == '^' || inp[i] == '*' || inp[i] == '/' || inp[i] == '+' || inp[i] == '(' || inp[i] == ')')
                    {
                        if (tmp != "")
                        {
                            try
                            {
                                arr.Add(Convert.ToDouble(tmp));
                            }
                            catch (Exception)
                            {
                                cekError = false;
                                break;
                            }
                        }
                        tmp = "";
                        arr.Add(inp[i]);
                    }
                    else if (inp[i] == '-')
                    {
                        if (inp[i - 1] == '^' || inp[i - 1] == '*' || inp[i - 1] == '/' || inp[i - 1] == '+' || inp[i - 1] == ')')
                            tmp += inp[i];
                        else
                        {
                            try
                            {
                                arr.Add(Convert.ToDouble(tmp));
                            }
                            catch (Exception)
                            {
                                cekError = false;
                                break;
                            }
                            tmp = "";
                            arr.Add(inp[i]);
                        }
                    }
                    else
                        tmp += inp[i];
                }
                if (tmp != "")
                {
                    try
                    {
                        arr.Add(Convert.ToDouble(tmp));
                    }
                    catch (Exception)
                    {
                        cekError = false;
                    }
                }
            }
        }
        private Double hitung(Double op1, Double op2, char op) //Fungsi Perhitungan ^,*,/,+,-
        {
            if (op == '^')
            {
                Double tmp = op1;
                for (int i = 2; i <= op2; i++)
                    tmp *= op1;
                return tmp;
            }
            else if (op == '*')
                return op1 * op2;
            else if (op == '/')
                return op1 / op2;
            else if (op == '+')
                return op1 + op2;
            else
                return op1 - op2;
        }
        private int prioritas(int start, int end) //Mengambil posisi Prioritas operator 
        {
            if (arr.IndexOf('^', start, end - start) != -1)
                return arr.IndexOf('^', start, end - start);
            else if ((arr.IndexOf('*', start, end - start) != -1) && (arr.IndexOf('/', start, end - start) != -1))
            {
                if (arr.IndexOf('*', start, end - start) < arr.IndexOf('/', start, end - start))
                    return arr.IndexOf('*', start, end - start);
                else
                    return arr.IndexOf('/', start, end - start);
            }
            else if (arr.IndexOf('*', start, end - start) == -1 && arr.IndexOf('/', start, end - start) != -1)
                return arr.IndexOf('/', start, end - start);
            else if (arr.IndexOf('/', start, end - start) == -1 && arr.IndexOf('*', start, end - start)!=-1)
                return arr.IndexOf('*', start, end - start);
            else if ((arr.IndexOf('+', start, end - start) != -1) && (arr.IndexOf('-', start, end - start) != -1))
            {
                if (arr.IndexOf('+', start, end - start) < arr.IndexOf('-', start, end - start))
                    return arr.IndexOf('+', start, end - start);
                else
                    return arr.IndexOf('-', start, end - start);
            }
            else if (arr.IndexOf('+', start, end - start) == -1 && arr.IndexOf('-', start, end - start) != -1)
                return arr.IndexOf('-', start, end - start);
            else if (arr.IndexOf('-', start, end - start) == -1 && arr.IndexOf('+', start, end - start) != -1)
                return arr.IndexOf('+', start, end - start);
            else
                return -1;
        }
        private string tampil()
        {
            string hasil = "";
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].ToString() == "^" || arr[i].ToString() == "*" || arr[i].ToString() == "/" || arr[i].ToString() == "+" || arr[i].ToString() == "-")
                {
                    hasil+= " " + arr[i] + " ";
                }
                else if (arr[i].ToString() == "(" || arr[i].ToString() == ")")
                {
                    hasil+= arr[i];
                }
                else
                {
                    hasil+= arr[i];
                }
            }
            return hasil;
        }
        private void cekKali()  //Untuk mengecek input * mis 2(2-2), akan diubah menjadi 2*(2-2)
        {
            if (arr.IndexOf('(') != -1)     //Akan dilakukan pengecekan jika ada input '('
            {
                int tmp = arr.IndexOf('(', 1);
                while (tmp != -1)
                {
                    if (arr[tmp - 1].ToString() != "(" && arr[tmp - 1].ToString() != "^" && arr[tmp - 1].ToString() != "*" && arr[tmp - 1].ToString() != "/" && arr[tmp - 1].ToString() != "+" && arr[tmp - 1].ToString() != "-")
                    {
                        arr.Insert(tmp, '*');
                        tmp++;
                    }
                    tmp = arr.IndexOf('(', tmp + 1);
                }
                tmp = arr.LastIndexOf(')', arr.Count - 2);
                while (tmp != -1)
                {
                    if (arr[tmp + 1].ToString() != "(" && arr[tmp + 1].ToString() != ")" && arr[tmp + 1].ToString() != "^" && arr[tmp + 1].ToString() != "*" && arr[tmp + 1].ToString() != "/" && arr[tmp + 1].ToString() != "+" && arr[tmp + 1].ToString() != "-")
                    {
                        arr.Insert(tmp + 1, '*');
                        tmp--;
                    }
                    tmp = arr.LastIndexOf(')', tmp - 1);
                }
            }
        }
        private void validasiOperator()
        {
            int counterKurung = 0;
            int counterOperator = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (counterKurung < 0)
                    break;
                if (arr[i].ToString() == "(")
                    counterKurung++;
                else if (arr[i].ToString() == ")")
                    counterKurung--;
                else if (arr[i].ToString() == "^" || arr[i].ToString() == "*" || arr[i].ToString() == "/" || arr[i].ToString() == "+" || arr[i].ToString() == "-")
                    counterOperator--;
                else
                    counterOperator++;
            }
            if (counterKurung != 0 || counterOperator != 1)
                cekError = false;
        }
        public string[] aritmatika()
        {
            string[] hslJlan = new string[0];
            cekKali();
            if (arr.Count <= 2)
            {
                cekError = false;
            }
            bool cekKurung = false;
            if (arr.IndexOf('(') != -1)
                cekKurung = true;
            while (cekKurung == true && cekError == true)
            {
                int bKurung = arr.LastIndexOf('(');
                int tKurung = arr.IndexOf(')', bKurung);
                int pos;
                while (tKurung - bKurung > 2)
                {
                    pos = prioritas(bKurung + 1, tKurung - 1);
                    try
                    {
                        arr[pos - 1] = hitung(Convert.ToDouble(arr[pos - 1]), Convert.ToDouble(arr[pos + 1]), (char)arr[pos]);
                    }
                    catch (Exception)
                    {
                        cekError = false;
                        Console.WriteLine("Input False");
                        break;
                    }
                    arr.RemoveAt(pos);
                    arr.RemoveAt(pos);
                    tKurung = arr.IndexOf(')', bKurung);
                    Array.Resize(ref hslJlan, hslJlan.Length + 1);
                    hslJlan[hslJlan.GetUpperBound(0)]=tampil();
                }
                arr.RemoveAt(tKurung);
                arr.RemoveAt(bKurung);
                if (arr.IndexOf('(') != -1)
                    cekKurung = true;
                else
                    cekKurung = false;
            }
            while (arr.Count != 1 && cekError == true)
            {
                int pos = prioritas(0, arr.Count);
                try
                {
                    arr[pos - 1] = hitung(Convert.ToDouble(arr[pos - 1]), Convert.ToDouble(arr[pos + 1]), (char)arr[pos]);
                }
                catch
                {
                    cekError = false;
                    //Console.WriteLine("Input False");
                    break;
                }
                arr.RemoveAt(pos);
                arr.RemoveAt(pos);
                Array.Resize(ref hslJlan, hslJlan.Length + 1);
                hslJlan[hslJlan.GetUpperBound(0)] = tampil();
            }
            return hslJlan;
        }
    }
}
