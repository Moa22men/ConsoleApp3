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
        }
    }
}
