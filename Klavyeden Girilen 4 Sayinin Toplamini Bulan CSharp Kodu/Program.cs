﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_Girilen_4_Sayinin_Toplamini_Bulan_CSharp_Kodu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Konsolda sayıları direkt yanına yazmasını istediğim için WriteLine yerine Write yazdım.

            Console.Write("Birinci Sayıyı Giriniz: ");
            int Sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            int Sayı2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçüncü Sayıyı Giriniz: ");
            int Sayı3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dördüncü Sayıyı Giriniz: ");
            int Sayı4 = Convert.ToInt32(Console.ReadLine());

            int Toplam = Sayı1 + Sayı2 + Sayı3 + Sayı4;

            Console.WriteLine("Girdiğiniz Dört Sayının Toplamı: " + Toplam);

            Console.ReadKey();
               
        }
    }
}