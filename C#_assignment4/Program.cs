using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Q1
            //Console.Write("number: ");
            //int n = int.Parse(Console.ReadLine());
            //if (n%3==0 && n%4==0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No"); 
            #endregion
            #region Q2
            //Console.Write("Enter number: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n < 0)
            //    Console.WriteLine("Negative");
            //else
            //    Console.WriteLine("Positive");
            #endregion

            Console.WriteLine($"enter number n1");
            int.TryParse( Console.ReadLine(), out int n1 );
            Console.WriteLine($"enter number n2 ");
            int.TryParse(Console.ReadLine(), out int n2);
            Console.WriteLine($"enter number n3");
            int.TryParse(Console.ReadLine(), out int n3);
            int max = 0;
            int min = 0;
            if (n1 > n2 && n1 < n3)
            {
                max = n3;
                min = n2;
                Console.WriteLine($"max element {max}");
                Console.WriteLine($"min element {min}");
            }
            else if(n3>n1&& n2>n3)
            { 
                max = n3;
                min = n1;
                Console.WriteLine($"max element {max}");
                Console.WriteLine($"min element {min}");

            }









        }
    }
}
