using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class KonversiSatuan
    {
        
        //private int satuan { set; get; } //menampung conversi satuan, sprti Panjang, Luas, Volume, Kecepatan dalam int
        private string dari { set; get; } // Konversi dari, mis. dari centimeter
        private string ke { set; get; }
        private double nilai { set; get; } //menampung nilai yg akan di konversi
        public KonversiSatuan(string dari,string ke,double nilai)
        {
            //this.satuan = satuan;
            this.dari = dari;
            this.ke = ke;
            this.nilai=nilai;
        }
        public double Panjang()
        {
            Dictionary<string, Double> satuan2 = new Dictionary<string, Double>()
            {
                {"Inci",25.4},
                {"Kaki",304.8},
                {"Mil",1609344},
                {"Yard",914.4},
                {"Mil Laut",1852000.0}
            };

            if (satuan2.ContainsKey(dari))
            {
                nilai = nilai * satuan2[dari];
                dari = "Milimeter";
            }

            if (satuan2.ContainsKey(ke))
            {
                nilai = nilai / satuan2[ke];
                ke = "Milimeter";
            }

            Dictionary<string, double> satuan = new Dictionary<string, double>()
            {
                
                {"Kilometer",1},
                {"Hektometer",10},
                {"Dekameter",100},
                {"Meter",1000},
                {"Desimeter",10000},
                {"Sentimeter",100000},
                {"Milimeter",1000000},
                {"Mikrometer",1000000000},
                {"Nanometer",1000000000000}
            };
            if (satuan[dari] <= satuan[ke])
                return nilai * (satuan[ke] / satuan[dari]);
            else
                return nilai / (satuan[dari] / satuan[ke]);
        }
        public double Berat()
        {
            Dictionary<string, double> satuan = new Dictionary<string, double>()
            {
                {"Ton",0.001},
                {"Kilogram",1},
                {"Hektogram",10},
                {"Dekagram",100},
                {"Gram",1000},
                {"Desigram",10000},
                {"Karat",20000},
                {"Centigram",100000},
                {"Miligram",1000000},
            };

            if (satuan[dari] <= satuan[ke])
                return nilai * (satuan[ke] / satuan[dari]);
            else
                return nilai / (satuan[dari] / satuan[ke]);
        }
        public double Data()
        {
            Dictionary<string, double> satuan = new Dictionary<string, double>()
            {
                {"Bit",0},{"Byte",3},{"Kilobit",10},{"Kilobyte",13},{"Megabit",20},{"Megabyte",23},{"Gigabit",30},{"Gigabyte",33},{"Terabit",40},{"Terabyte",43},{"Petabit",50},{"Petabyte",53}
            };
            if (satuan[dari] <= satuan[ke])
                return nilai / (Math.Pow(2, satuan[ke]) / Math.Pow(2, satuan[dari]));
            else
                return nilai * (Math.Pow(2, satuan[dari]) / Math.Pow(2, satuan[ke]));
        }
        public double Area()
        {
            Dictionary<string, Double> satuan2 = new Dictionary<string, Double>()
            {
                {"Mil persegi",2.58998},
                {"Acre",0.004047},
                {"Yard persegi",0.00000083612736},
                {"Kaki persegi",0.00000009290304},
                {"Inci persegi",0.00000000064516},
            };
            if (satuan2.ContainsKey(dari))
            {
                nilai = nilai * satuan2[dari];
                dari = "Kilometer persegi";
            }

            if (satuan2.ContainsKey(ke))
            {
                nilai = nilai / satuan2[ke];
                ke = "Kilometer persegi";
            }
            Dictionary<string, Int32> satuan = new Dictionary<string, Int32>()
            {

                {"Kilometer persegi",0},
                {"Hektar",2},
                {"Meter persegi",6},
                {"Sentimeter persegi",10},
                {"Milimeter persegi",12}
            };

            if (satuan[dari] <= satuan[ke])
                return nilai * (Math.Pow(10, satuan[ke]) / Math.Pow(10, satuan[dari]));
            else
                return nilai / (Math.Pow(10, satuan[dari]) / Math.Pow(10, satuan[ke]));
        }
    }
}
