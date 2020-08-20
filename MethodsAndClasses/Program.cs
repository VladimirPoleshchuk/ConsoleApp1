
using System;
using System.Text;

namespace MethodsAndClasses
{/*
    class Program
    {
        #region MyREF
        /*
         static void Foo(int p)
        {
            p += 1;
            Console.WriteLine(p);
         }
        static void Foo(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
        }
        static void Foo(ref int p)
        {
            p += 1;
            Console.WriteLine(p);
        }
        static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        #endregion

        #region Out
        /* static void Split(string name, out  string firstName, out string lastName )
      {
          int i = name.LastIndexOf(' ');
          firstName = name.Substring(0, i);
          lastName = name.Substring(i + 1);
      }
        
        #endregion

        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i <integers.Length; i++)
            {
                result += integers[i];
                Console.WriteLine(result);
            }
            Console.WriteLine(result);
            Console.WriteLine("******************");
        }
        
        static void AdditionMas(int[] integers, int k)
        { 
            int result = 0;
            for (int i = 0; i <integers.Length; i++)
            {
                result += (integers[i] * k);
                Console.WriteLine(result);
            }
            Console.WriteLine(result);
            
        }




        public static void Main()
        {
            #region REF
            /*
            int x = 8;
            Foo(x);
            Console.WriteLine(x);

            StringBuilder sb = new StringBuilder();
            Foo(sb);
            Console.WriteLine(sb.ToString());

            int z = 8;
            Foo(ref z);
            Console.WriteLine(z);

            string name = "Penn";
            string name2 = "Teller";
            Console.WriteLine("{0} {1}", name, name2); 
            Swap(ref name, ref name2);
            Console.WriteLine("{0} {1}", name, name2);
            
            #endregion
            #region Out
            /*
            string c = "Stevie Ray Vaughan";
            Split(c, out string a, out _);
            Console.WriteLine(a);
            Console.WriteLine();
            
            #endregion
            #region Displey
            /*  Displey("Tom", 24);
           Displey("Mery", 18);

           int a = Convert.ToInt32(Console.ReadLine());
           int b = Convert.ToInt32(Console.ReadLine());

           int sum =Sum(a, b);
           Console.WriteLine(sum);


       }
           static void Displey(string name, int age)
           {
           Console.WriteLine($"Name: {name}, Age: {age}");
           }
       static int Sum(int x, int y)
       {
           return x + y;
       }
            #endregion

            Addition(1, 2, 3, 4);

            int[] array = { 1, 2, 3, 4 };
            AdditionMas(array, 2);

           

        */
        }
       
        
    
