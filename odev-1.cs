using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("İki sayının arasındaki sayıları bulma ve toplama programı");
            Console.Write("1. Sayıyı giriniz: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------");
            if (number1 == number2)
            {
                System.Console.WriteLine("Sayılar eşittir.");
            }
            else if (number1 == (number2 - 1) || (number1 - 1) == number2)
            {
                System.Console.WriteLine("{0} ve {1} arasında bir sayı yoktur.", number1, number2);

            }
            else
            {
                System.Console.WriteLine("{0} ve {1} arasındaki sayılar", number1, number2);
                System.Console.WriteLine("---");

                int biggestNumber = number1 > number2 ? number1 : number2;
                int lowestNumber = number1 < number2 ? number1 : number2;

                int totalSum = 0;

                for (int i = biggestNumber - 1; i > lowestNumber; i--)
                {
                    Console.WriteLine(i);
                    totalSum += i;
                }
                System.Console.WriteLine("---");


                Console.WriteLine("------------------------");
                System.Console.WriteLine("{0} ve {1} Sayıları'nın arasındaki toplam: {2}", number1, number2, totalSum);
                Console.WriteLine("------------------------");



            }
        }
    }
}
