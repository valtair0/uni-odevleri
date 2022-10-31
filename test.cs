using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "mmert";
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i > j)
                    {
                        break;
                    }
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }
                if (count > 0) Console.WriteLine(str[i] + " karakterinden" + count + " tane var");
            }
        }

    }
}



