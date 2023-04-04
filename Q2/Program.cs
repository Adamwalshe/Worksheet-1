using System;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CountOfddNumbers());
            AverageMinMax();
        }
        static int CountOfddNumbers()
        {
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Number:");
                int num = int.Parse(Console.ReadLine());
                if (num%2 != 0)
                {
                    counter++;
                }
                
            }
            return counter;
        }
        static private void AverageMinMax()
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Number:");
                int num = int.Parse(Console.ReadLine());
                sum += num;
                int min;
                int max; 
                if (num < min) min = num;
                if (num > max) max = num;
            }
            
            double average = sum / 5;
            min = int.MinValue; 
            max = int.MaxValue;
            Console.WriteLine($"Average: { average}");
            Console.WriteLine($"Smallest number: { min}");
            Console.WriteLine($"Biggest number: {max}");
        }
    }
}