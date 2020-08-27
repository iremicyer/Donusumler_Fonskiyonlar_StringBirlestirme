using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace proje
{
    class Program
    {

        public static string StringCevir(double sayi1) // 1. fonksiyon
        {
            //ilk değer burada string'e dönüştürülüyor
            Console.Write("1. SAYİ:");
            Console.WriteLine(sayi1);
            return sayi1.ToString();
        }

        public static int Intcevir(double sayi2) // 2. fonksiyon
        {
            // 2. değer burada integer'a dönüştürülüyor.
            int sayi;
            sayi = Convert.ToInt32(sayi2);

            Console.Write("2. sayi:");
            Console.WriteLine(sayi);

            return sayi;
        }

        public static string Birlestir(double sayi1, double sayi) // 3. fonksiyon
        {
            // 1. ve 2. değerler burada bir string' de birleştiriliyor

            string sayilar = "";

            sayilar += sayi1;
            sayilar += sayi;
     

            return sayilar.ToString();
        }

        static void Main(string[] args)
        {
            // burada ekrandan double tipinde 2 tane değer alınıyor, 
            //alınan ilk değer 1. fonksiyona gönderiliyor, 2. değer 2. fonksiyona gönderiliyor
         // Birlestir() fonksiyonundaki değerler burada ekrana yazdırılıyor.
            double sayi1, sayi2;
        

            Console.Write("1. sayiyi giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayiyi giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

         
            StringCevir(sayi1);
            int sayiAl = Intcevir(sayi2); 
            Birlestir(sayi1, sayi2);

            var sayilar = Birlestir(sayi1, sayiAl);
            Console.Write("sayilarin Birlesimi:" + sayilar); // >>>Console.Write("sayilarin Birlesimi:" + Birlestir(sayi1,sayiAl));




        }
    }
}
