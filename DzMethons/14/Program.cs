using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вычислить время за которое перекинется файл
            int speed = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int time = FlippingFile(speed, weight);
            Console.WriteLine(time);
            Console.ReadKey();
        }

        public static int FlippingFile(int speed,int weight)
        {
            int time = 0;
            do
            {
                weight -= speed;
                time++;
                if(time % 2 == 0)
                {
                    weight++;
                }
            } while (weight >= 0);
            return time;
        }
    }
}
