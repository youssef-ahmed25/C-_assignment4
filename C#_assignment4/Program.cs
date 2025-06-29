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

            #region Q3
            //Console.Write("Enter number: ");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number: ");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter number: ");
            //int n3 = Convert.ToInt32(Console.ReadLine());
            //int max = Math.Max(n1, Math.Max(n2, n3));
            //int min = Math.Min(n1, Math.Min(n2, n3));
            #endregion
            #region Q4

            //Console.Write("Enter integer: ");
            //int.TryParse(Console.ReadLine(),out int n);
            //if (n % 2 == 0)
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");

            #endregion
            #region Q5
            //Console.Write("Enter character: ");
            //string character = Console.ReadLine();
            //string result = character switch
            //{
            //    "a" => "vowel",
            //    "e" => "vowel",
            //    "i" => "vowel",
            //    "o" => "vowel",
            //    "u" => "vowel",
            //    _ => "consonant"
            //};

            //Console.WriteLine(result);
            #endregion
            #region Q6
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(),out int number);
            //for (int i = 1; i <= number; i++)
            //    Console.Write(i);

            #endregion
            #region Q7
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i <= 12; i++)
            //    Console.Write(i*number);
            #endregion
            #region Q8
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i <= number; i++)
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            #endregion
            #region Q9
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int n1);
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int n2);
            //double result = Math.Pow(n1, n2);
            //Console.WriteLine("power of two number:"+result);
            #endregion
            #region Q10
            int[] marks = new int[5];
            int t = 0;
            for (int i = 0; i < 5; i++)
            {Console.Write("Enter number: ");
                int.TryParse(Console.ReadLine(), out marks[i]);
                t += marks[i];}
            double avg = t / 5;
            double percentage = avg;
            Console.WriteLine("Total = " + t);
            Console.WriteLine("avg = " + avg);
            Console.WriteLine("Percentage = " + percentage);

            #endregion
            #region Q11
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int n);

            //string r = n switch
            //{
            //    1 or 3 or 5 or 7 or 8 or 10 or 12 =>"31 days",
            //    4 or 6 or 9 or 11 =>"30 days",
            //    2 => "29 days",
            //    _ => "not month"
            //};

            //Console.WriteLine(r);
            #endregion
            #region Q12
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int n1);
            //Console.Write("Enter number: ");
            //int.TryParse(Console.ReadLine(), out int n2);
            //Console.Write("Enter option 1 to + or 2 to - or 3 to * or 4 to /: ");
            //int.TryParse(Console.ReadLine(), out int option);
            //string r = option switch
            //{
            //    1 => $"Result: {n1 + n2}",
            //    2 => $"Result: {n1 - n2}",
            //    3 => $"Result: {n1 * n2}",
            //    4 => $"Result: {(double)n1 / n2}",
            //    _ => "Invalid option"
            //};

            //Console.WriteLine(r);
            #endregion
            #region Q13
            //Console.Write("Enter name: ");
            //string i = Console.ReadLine();
            //char[] arr = i.ToCharArray();
            //Array.Reverse(arr);
            //Console.WriteLine((arr));
            #endregion


            #region Q15

            #endregion
            #region Q16

            #endregion
            #region Q17

            #endregion
            #region Q18
            //Console.Write("Enter number: ");
            //double time = double.Parse(Console.ReadLine());
            //if (time <= 3 || time >= 2)
            //    Console.WriteLine("Highly efficient");
            //else if (time <= 4)
            //    Console.WriteLine("increase their speed");
            //else if (time <= 5)
            //    Console.WriteLine("they are provided with training to enhance their speed");
            //else
            //    Console.WriteLine("Leave the company");

            #endregion
            #region Q19
            //Console.Write("Enter number: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i=0; i<n;i++)
            //{
            //    for (int j=0;j<n;j++)
            //    {
            //        if (i == j)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Q20
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //    sum += arr[i];

            //Console.WriteLine("Sum = " + sum);

            #endregion
            #region Q21

            #endregion
            #region Q22

            #endregion
            #region Q23
            //int[] array = { 1,2,3,4,5,6,7,8 };
            //int max = array.Max();
            //int min = array.Min();
            //Console.WriteLine("Max: " + max);
            //Console.WriteLine("Min: " + min);

            #endregion




        }
    }
}
