using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14__11__1___2___3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] arrayWithNumber = new int[5, 5];
            for (int i = 0; i < arrayWithNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayWithNumber.GetLength(1); j++)
                {
                    arrayWithNumber[i, j] = random.Next(1, 2 + 1);
                    Console.Write(arrayWithNumber[i, j] + " ");
                }
                Console.WriteLine();
            }
            int result = SummDioganale(arrayWithNumber);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int SummDioganale(int[,] arrayWithNumber)
        {
            int result = 0;
            for (int i = 0; i < arrayWithNumber.GetLength(0); i++)
            {
                for (int j = 0; j < arrayWithNumber.GetLength(1); j++)
                {
                    if (i == j || i + j == 4)
                    {
                        result += arrayWithNumber[i, j];
                        if (i == arrayWithNumber.GetLength(0) / 2 && j == arrayWithNumber.GetLength(1) / 2)
                        result += arrayWithNumber[i, j];
                    }
                }
            }
            return result;
        }
    }
}
