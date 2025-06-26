using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("Enter a number: ");
            int Num = int.Parse(Console.ReadLine());
            if (Num % 3 == 0 && Num % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            #endregion

            #region Q2
            Console.Write("Enter an number: ");
            int Num2 = int.Parse(Console.ReadLine());
            if (Num2 > 0)
                Console.WriteLine("positive");
            else
                Console.WriteLine("negative");
            #endregion

            #region Q3
            Console.WriteLine("Enter three numbers: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int max = x;
            int min = x;

            if (y > max)
                max = y;
            if (z > max)
                max = z;

            if (y < min)
                min = y;
            if (z < min)
                min = z;
            Console.WriteLine("max element = " + max);
            Console.WriteLine("min element = " + min);
            #endregion

            #region Q4
            Console.Write("Enter a number: ");
            int Num3 = int.Parse(Console.ReadLine());

            if (Num3 % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            #endregion
        }
    }
}
