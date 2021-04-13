using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_AND_ESLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            if ((a < b + c) & (b < a + c) & (c < a + b))
                {
                Console.WriteLine("труг.сущ");
                }
            else
            {
                Console.WriteLine("Треуг.не сущ.");
            }
            Console.ReadKey();


        }
    }
}
