 
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    int flag = -1;
    int input = Convert.ToInt32(Console.ReadLine());

    int biggestnumber = 0;
    while (input != flag)
    {
        input = Convert.ToInt32(Console.ReadLine());

        if (input > biggestnumber)
        {
            biggestnumber = input;
        }
    }

    Console.WriteLine(biggestnumber);

    Console.ReadLine();
    
   
    }
}
