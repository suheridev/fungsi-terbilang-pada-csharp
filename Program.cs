using System;

namespace Fungsi_Terbilang
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Masukkan angka : ");
                double angka = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Terbilang(angka));
            }            
        }

        public static string Terbilang(double x)
        {
            x = Math.Abs(x);
            string[] angka = new string[] {"", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"};
            string temp = string.Empty;

            if (x < 12)
                temp = " " + angka[(int)x];            
            else if (x < 20)
                temp = Terbilang(x - 10) + " belas";            
            else if (x < 100)
                temp = Terbilang(Math.Floor(x / 10)) + " puluh" + Terbilang(x % 10);           
            else if (x < 200)
                temp = " seratus" + Terbilang(x - 100);            
            else if (x < 1000)
                temp = Terbilang(Math.Floor(x / 100)) + " ratus" + Terbilang(x % 100);           
            else if (x < 2000)
                temp = " seribu" + Terbilang(x - 1000);            
            else if (x < 1000000)
                temp = Terbilang(Math.Floor(x / 1000)) + " ribu" + Terbilang(x % 1000);            
            else if (x < 1000000000)
                temp = Terbilang(Math.Floor(x / 1000000)) + " juta" + Terbilang(x % 1000000);            
            else if (x < 1000000000000)
                temp = Terbilang(Math.Floor(x / 1000000000)) + " milyar" + Terbilang(x % 1000000000);            
            else if (x < 1000000000000000)
                temp = Terbilang(Math.Floor(x / 1000000000000)) + " trilyun" + Terbilang(x % 1000000000000);
            
            return temp;
        }

    }
}
