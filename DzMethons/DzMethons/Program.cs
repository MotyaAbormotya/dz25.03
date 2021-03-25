using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzMethons
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вычисление суммы капитала
            int money = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            CalculatingAmountCapital(ref money, percent, year);
            Console.WriteLine(money);
            Console.ReadKey();
        }

        public static void CalculatingAmountCapital(ref int money, int percent, int year)
        {
            
            while (year != 0)
            {
                money += (money * percent / 100);
                year--;
            }
        }
    }
}
