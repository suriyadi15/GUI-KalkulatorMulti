using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class ConversiBilangan
    {
        private int basisDari { set; get; }
        private int basisKe { set; get; }
        private string nilai { set; get; }
        public ConversiBilangan(int basisDari, int basisKe, string nilai)
        {
            this.basisDari = basisDari;
            this.basisKe = basisKe;
            this.nilai = nilai;
        }
        public string hitung()
        {
            if (basisDari == 2 && basisKe == 2)
                return nilai;
            else if (basisDari == 2 && basisKe == 8)
                return BinnerToOctal(nilai);
            else if (basisDari == 2 && basisKe == 10)
                return BinnerToDecimal(nilai);
            else if (basisDari == 2 && basisKe == 16)
                return BinnerToHexa(nilai);
            else if (basisDari == 8 && basisKe == 2)
                return OctalToBinner(nilai);
            else if (basisDari == 8 && basisKe == 8)
                return nilai;
            else if (basisDari == 8 && basisKe == 10)
                return OctalToDecimal(nilai);
            else if (basisDari == 8 && basisKe == 16)
                return OctalToHexa(nilai);
            else if (basisDari == 10 && basisKe == 2)
                return DecimalToBinner(Convert.ToInt32(nilai), 2);
            else if (basisDari == 10 && basisKe == 8)
                return DecimalToOctal(Convert.ToInt32(nilai));
            else if (basisDari == 10 && basisKe == 10)
                return nilai;
            else if (basisDari == 10 && basisKe == 16)
                return DecimalToHexa(Convert.ToInt32(nilai));
            else if (basisDari == 16 && basisKe == 2)
                return HexaToBinner(nilai);
            else if (basisDari == 16 && basisKe == 8)
                return HexaToOctal(nilai);
            else if (basisDari == 16 && basisKe == 10)
                return HexaToDecimal(nilai);
            else if (basisDari == 16 && basisKe == 16)
                return nilai;
            else
                return "0";
        }
        private string DecimalToBinner(int nilai,int basisKe)
        {
            string hasil = "";
            int tmp = nilai;
            Dictionary<int, char> basis = new Dictionary<int, char>()
                {
                    {0,'0'},{1,'1'},{2,'2'},{3,'3'},{4,'4'},{5,'5'},{6,'6'},{7,'7'},{8,'8'},{9,'9'},{10,'A'},{11,'B'},{12,'C'},{13,'D'},{14,'E'},{15,'F'}
                };
            while (tmp > 0)
            {
                hasil = basis[tmp % basisKe].ToString() + hasil;
                tmp = tmp / basisKe;
            }
            return hasil;
        }
        private string DecimalToOctal(int nilai)
        {
            return DecimalToBinner(nilai,8);
        }
        private string DecimalToHexa(int nilai)
        {
            return DecimalToBinner(nilai,16);
        }
        private string BinnerToDecimal(string nilai)
        {
            string hasil = "";
            long tmp = 0;
            foreach (char i in nilai)
            {
                tmp = 2 * tmp + Convert.ToInt32(i.ToString());
            }
            hasil = Convert.ToString(tmp);
            return hasil;
        }
        private string BinnerToOctal(string nilai)
        {
            string hasil = "";
            int tmp = 0;
            int pangkat = 0;
            int update = 0;
            update = nilai.Length - 3;
            for (int i = nilai.Length - 1; i >= 0; i--)
            {
                tmp += Convert.ToInt32(nilai[i].ToString()) * Convert.ToInt32(Math.Pow(2, pangkat));
                pangkat++;
                if (i == update)
                {
                    hasil = tmp.ToString() + hasil;
                    update -= 3;
                    pangkat = 0;
                    tmp = 0;
                }
            }
            hasil = tmp.ToString() + hasil;
            return hasil;
        }
        private string BinnerToHexa(string nilai)
        {
            Dictionary<int, char> basis = new Dictionary<int, char>()
                {
                    {0,'0'},{1,'1'},{2,'2'},{3,'3'},{4,'4'},{5,'5'},{6,'6'},{7,'7'},{8,'8'},{9,'9'},{10,'A'},{11,'B'},{12,'C'},{13,'D'},{14,'E'},{15,'F'}
                };
            string hasil = "";
            int tmp = 0;
            int pangkat = 0;
            int update = 0;
            update = nilai.Length - 4;
            for (int i = nilai.Length - 1; i >= 0; i--)
            {
                tmp += Convert.ToInt32(nilai[i].ToString()) * Convert.ToInt32(Math.Pow(2, pangkat));
                pangkat++;
                if (i == update)
                {
                    hasil = basis[tmp].ToString() + hasil;
                    update -= 4;
                    pangkat = 0;
                    tmp = 0;
                }
            }
            hasil = basis[tmp].ToString() + hasil;
            return hasil;
        }
        private string OctalToBinner(string nilai)
        {
            string hasil = "";
            string tmp = "";
            for (int i = nilai.Length - 1; i >= 0; i--)
            {
                tmp = DecimalToBinner(Convert.ToInt32(nilai[i].ToString()), 2);
                if (tmp.Length == 1)
                    tmp = "00" + tmp;
                else if (tmp.Length == 2)
                    tmp = "0" + tmp;
                else if (tmp.Length == 0)
                    tmp = "000" + tmp;
                hasil = tmp+hasil;
            }
            return hasil;
        }
        private string OctalToDecimal(string nilai)
        {
            long x = 0;
            foreach (char i in nilai)
                x = 8 * x + Convert.ToInt32(i.ToString());
            return Convert.ToString(x);
        }
        private string OctalToHexa(string nilai)
        {
            string tmp = "";
            tmp = OctalToBinner(nilai);
            tmp = BinnerToHexa(tmp);
            return tmp;
        }
        private string HexaToBinner(string nilai)
        {
            string hasil = "";
            string tmp = "";
            Dictionary<char, int> basis = new Dictionary<char,int>()
                {
                    {'0',0},{'1',1},{'2',2},{'3',3},{'4',4},{'5',5},{'6',6},{'7','7'},{'8',8},{'9',9},{'A',10},{'B',11},{'C',12},{'D',13},{'E',14},{'F',15}
                };
            foreach (char i in nilai)
            {
                tmp = DecimalToBinner(basis[i],2);
                if (tmp.Length == 1)
                    tmp = "000" + tmp;
                else if (tmp.Length == 2)
                    tmp = "00" + tmp;
                else if (tmp.Length == 3)
                    tmp = "0" + tmp;
                else if (tmp.Length == 0)
                    tmp = "0000" + tmp;
                hasil += tmp;
            }
            return hasil;
        }
        private string HexaToDecimal(string nilai)
        {
            Dictionary<char, int> basis = new Dictionary<char, int>()
                {
                    {'0',0},{'1',1},{'2',2},{'3',3},{'4',4},{'5',5},{'6',6},{'7',7},{'8',8},{'9',9},{'A',10},{'B',11},{'C',12},{'D',13},{'E',14},{'F',15}
                };
            long hasil = 0;
            int pangkat = 0;
            for (int i = nilai.Length - 1; i >= 0; i--)
            {
                hasil += basis[nilai[i]] * Convert.ToInt64(Math.Pow( 16, pangkat));
                pangkat++;
            }
            return hasil.ToString();
        }
        private string HexaToOctal(string nilai)
        {
            string hasil = "";
            hasil = HexaToBinner(nilai);
            hasil = BinnerToOctal(hasil);
            return hasil;
        }
    }
}

