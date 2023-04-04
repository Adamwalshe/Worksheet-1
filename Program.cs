namespace Worksheet_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntergers();
            PrintIntegersWhile();
            PrintIntergersDo();
            PrintExcludingFor();
            PrintDescendingFor();
        }
        static private void PrintIntergers()
        {
            double num1;
            for (num1 = 40; num1 <= 60; num1++)
             Console.WriteLine(num1);
            Console.WriteLine("-------------");
        }
        static private void PrintIntegersWhile()
        {
            double num1=40;
            while (num1 >=40 & num1 <=60)
            {
                Console.WriteLine(num1);
                num1++;
            }
            Console.WriteLine("-------------");
        }
        static private void PrintIntergersDo()
        {
            double num1=40;
            do
            {
                Console.WriteLine(num1);
                num1++;
            }
            while (num1 >= 40 & num1 <= 60);
            Console.WriteLine("-------------");
        }
        static private void PrintExcludingFor()
        {
            double num1;
            for (num1 = 40; num1 <= 60; num1++)
            {
                if (num1 != 46 && num1 !=48)
                {
                    Console.WriteLine($"{num1}",num1);
                }

            }     
            Console.WriteLine("-------------");
        }
        static void PrintDescendingFor()
        {
            double num1;
            for (num1 = 60; num1 >= 40; num1--)
                Console.WriteLine(num1);
            Console.WriteLine("-------------");
        }
    }
}