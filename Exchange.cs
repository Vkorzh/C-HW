using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchange
{
  
class Program
    {
        static double sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Первое чилсо равняется {0}",a);
            Console.WriteLine("Второе чилсо равняется {0}", b);
            Console.WriteLine("Потвердите выполнение метода");
            Console.ReadLine();
            a = (sum(a, b) - a);
            b = (sum(a, b) - b);
            Console.WriteLine("После выполнения функции");
            Console.WriteLine("Первое чилсо равняется {0}", a);
            Console.WriteLine("Второе чилсо равняется {0}", b);
            Console.ReadLine();
        }
}
}
