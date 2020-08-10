using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] table = new int [3,4];
            for (int i = 0; i <table.length; i++)
			{
                for (int j = 0; j <table.length; j++)
			{
                table[i,j]=(i*4)+j+1;
                    Console.WriteLine(table[i,j]+ " ");
			}
			}
           
        }
    }
}
