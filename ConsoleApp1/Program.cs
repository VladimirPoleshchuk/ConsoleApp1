using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ConvertDigitsToWords
    {
        static void Main()
        {
            int num;
            int nextdigit=0;
            int numdigits=0;
            int[] n = new int[4];

            string[] digits = { "ноль","один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

            num = 1908;

            Console.WriteLine($"Число: {num}");

            Console.WriteLine("Число словами: ");

            do
            {
                nextdigit = num % 10;
                n[numdigits] = nextdigit;
                numdigits++;
                num = num/ 10;
            } while (num>0);
            numdigits--;
            for (; numdigits>=0; numdigits--)
                Console.Write(digits[n[numdigits]]+ " ");
            Console.WriteLine();
            
            //Проверка метода
            string str = "Привет кто сегодня пойдет?";

             str = str.Substring( 5,  10);
            Console.WriteLine(str);

        }
        
    }
}
