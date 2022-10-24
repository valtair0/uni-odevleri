using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
           //ÖDEVİN ÇÖZÜLMEMİŞ HALİ
           /*
            Console.Write("Sayıyı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < sayi; i++)
            {

                if (sayi%i==0)
                {
                    Console.Write(i+",");
                }

            }

            Console.ReadLine();
            */
            
            

            //ÇÖZÜMÜ
            Console.Write("Sayıyı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonBolunenSayi=0;

            for (int i = sayi-1; i <= sayi; i--)
            {
                    if (sayi%i==0)
                    {
                        sonBolunenSayi = i;
                        break;
                    }
                  
            }


            for (int i = 2; i < sayi; i++)
            {

                if (sayi%i==0)
                {
                    Console.Write(i);
                    if (i!=sonBolunenSayi)
                    {
                        Console.Write(",");
                    }
                }

            }

            Console.ReadLine();

        }
    }
}
