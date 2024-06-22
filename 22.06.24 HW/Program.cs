using System;

namespace _22._06._24_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //First method

            //int[] sides = new int[5];
            //int perimeter = 0;

            //Console.WriteLine("Side's length:");
            //for (int i = 0; i < sides.Length; i++)
            //{
            //    Console.Write($"Side {i + 1}: ");
            //    sides[i] = Convert.ToInt32(Console.ReadLine());
            //    perimeter += sides[i];
            //}
            //Console.WriteLine($"Perimetr: {perimeter}");


            //Second method
            int[] sides = new int[5];

            Console.WriteLine("side's length:");
            for (int i = 0; i < sides.Length; i++)
            {
                Console.Write($"side {i + 1}: ");
                sides[i] = Convert.ToInt32(Console.ReadLine());
            }
            int perimeter = sides.Sum();
            Console.WriteLine($"perimetr: {perimeter}");


            //Task 2
            int[] Array = new int[12];
            string[] months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("Enter a number: ");
                Array[i] = int.Parse(Console.ReadLine());

                if (Array[i] < Array[minIndex])
                {
                    minIndex = i;
                }
                if (Array[i] > Array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            Console.WriteLine($"Min profit was in month: {months[minIndex]}");
            Console.WriteLine($"Max profit was in month: {months[maxIndex]}");


            //Task 3
            int[] array = new int[10];
            Random rand = new Random();
            int sumOddElements = 0;
            int sumOddIndices = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-9, 10);

                if (array[i] % 2 != 0) 
                {
                    sumOddElements += array[i];
                }

                if (i % 2 != 0) 
                {
                    sumOddIndices += array[i];
                }
            }

            Console.WriteLine("Sum of the odd elements: " + sumOddElements);
            Console.WriteLine("Sum of the elements with the odd indexes: " + sumOddIndices);
        }
    }
}