using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Hafta_2_Week_
{
    class Program
    {
        static void Main(string[] args)
        
        {

            System.Console.WriteLine("Adinizi Giriniz: ");

            string ad = System.Console.ReadLine();

            Console.Write("Doğum yilinizi giriniz: ");

            int yil = Convert.ToInt32(Console.ReadLine());

            int yas = 2023 - yil;

            Console.WriteLine(yas);
            Console.ReadLine();

        }

        static int hesapla()                   //FUNCTION
        {
            int paraustu, odeme = 500, alisveris = 25;

            paraustu = odeme - alisveris;

            return paraustu;
        }
        
        void selamla()
        {
            Console.WriteLine("merhaba");
        }
    }
}
