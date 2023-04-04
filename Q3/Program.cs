namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle();
            PrintTriangleUpsideDown();
            PrintTriangleGeneral();
        }
        static private void PrintTriangle()
        {
            
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        static private void PrintTriangleUpsideDown()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j<(6-i); j++ )
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
        static private void PrintTriangleGeneral()
        {
            Console.WriteLine("How many rows in your triangle:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < (1+i); j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

        }
    }
}