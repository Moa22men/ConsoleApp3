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

            #region Q5
            Console.Write("Enter a character: ");
            char letter = char.Parse(Console.ReadLine().ToLower());
            if ("aeiou".Contains(letter))
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
            #endregion

            #region Q6
            Console.Write("Enter a number: ");
            int Num4 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Num4; i++)
            {
                Console.Write(i + ",");
            }
            #endregion

            #region Q7
            Console.Write("Enter a number: ");
            int Num5 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(Num5 * i + " ");
            }
            #endregion

            #region Q8
            Console.Write("Enter a number: ");
            int Num6 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= Num6; i += 2)
            {
                Console.Write(i + " ");
            }
            #endregion

            #region Q9
            Console.Write("Enter the first number: ");
            int FNum = int.Parse(Console.ReadLine());
            Console.Write("Enter the power number: ");
            int PNum = int.Parse(Console.ReadLine());
            double result = Math.Pow(FNum, PNum);
            Console.WriteLine("Result = " + result);
            #endregion

            #region Q10
            Console.WriteLine("Enter marks of five subjects:");
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += int.Parse(Console.ReadLine());
            }
            double average = total / 5.0;
            double percentage = average;
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Average Marks = " + average);
            Console.WriteLine("Percentage = " + percentage);
            #endregion

            #region Q11
            Console.Write("Enter month number: ");
            int month = int.Parse(Console.ReadLine());
            int days;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    days = 28;
                    break;
                default:
                    days = 0;
                    break;
            }
            Console.WriteLine("Days in Month: " + days);
            #endregion

            #region Q12
            Console.Write("Enter matrix size: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   Console.WriteLine("*");
                }
            }
            #endregion

            #region Q13
            int[] array = { 75, 22, 14, 66, 82 };
            int sum = 0;
            foreach (int m in array)
            {
                sum += x;
            }
            Console.WriteLine("Sum = " + sum);
            #endregion

            #region Q15
            int[] array2 = { 10, 3, 7, 4, 9 };
            int max1 = array2[0];
            int min1 = array2[0];
            foreach (int Num7 in array2)
            {
                if (Num7 > max) {  
                    max1 = Num7; 
                } 
                if (Num7 < min) {
                    min1 = Num7;
                }
            }
            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
            #endregion
        }
    }
}
