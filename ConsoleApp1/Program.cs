using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       static void MyMethod()
        {
        int [,] table = new int [3,4];
            for (int i = 0; i <3; i++)
			{
                for (int j = 0; j <4; j++)
			{
                table[i,j]=(i*4)+j+1;
                    Console.Write(table[i,j]+ " ");
			}
			}
           Console.WriteLine();
            int [] nams = new int[10];
            for (int i = 0; i < nams.Length; i++)
			{
                nams[i]=i*i;
                Console.Write(nams[i]+" ");
			}
            Console.WriteLine();
        }



        static void MyMethod1()
        {
             int i,j;
            int [] nums1 = new int [10];
            int [] nums2 = new int [10];

            for ( i = 0; i <nums1.Length; i++) nums1[i]=i;
			
            Console.WriteLine("Исходное содержимое массива: ");
        
            for (  i = 0; i <nums1.Length; i++)
			{
                Console.Write(nums1[i] + " ");
			}
             if (nums1.Length==nums2.Length)
         	{
                for ( i = 0, j=nums1.Length-1; i < nums1.Length; i++, j--)
			{
              nums2[j]=nums1[i];
			}
                MethodNams2();

                Console.WriteLine();
	        }
          else
	      {
                MethodNams2();

                Console.WriteLine("\nМассивы не соответствуют по размеру!");
	       }
       void MethodNams2()
            {
                Console.WriteLine("\nСодержимое массива в обратном порядке: ");

                for ( i = 0; i <nums2.Length; i++)
			    {
                    Console.Write(nums2[i] + " ");
			    }
            }


        }
        static void Main(string[] args)
        {
        // MyMethod();  
           MyMethod1();
         
        }
        
    }
}
