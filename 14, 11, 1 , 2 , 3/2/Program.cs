using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int[] position = new int[text.Length];
            int quantity = 0;
            SummDioganale(text, ref position, ref quantity);
            Console.WriteLine(quantity);
            for (int i = 0; i < position.Length; i++)
            {
                if(position[i] != 0)
                Console.Write(position[i] + " ");
            }
            Console.ReadKey();
        }

        public static void SummDioganale(string text, ref int[] position, ref int quantity)
        {
            int positionInArray = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]) == true)
                {
                    quantity++;
                    position[positionInArray] = i + 1;
                    positionInArray++;
                }
            }
        }
    }
}
