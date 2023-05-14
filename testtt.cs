using System;

namespace LegendaryMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter '+' or '-' (any other character to exit): ");
                char operation = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (operation != '+' && operation != '-')
                {
                    break;
                }

                Console.Write("Enter the size of the matrix: ");
                int size = int.Parse(Console.ReadLine());

                double[,] matrix = new double[size, size];

                Console.WriteLine("Enter the matrix values:");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Result:");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (operation == '+')
                        {
                            Console.Write(Math.Abs(matrix[i, j]) + " ");
                        }
                        else
                        {
                            Console.Write(-matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
