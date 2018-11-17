using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathcalcul
{
    class Program
    {
        static double meth(double x1, double x2, double y1, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
    static void Main(string[] args)
        {
        
            double x1;
            double x2;
            double y1;
            double y2;
            double r;
            Console.WriteLine("Координаты точек");
            Console.WriteLine("Координата X первой точки");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата Y первой точки");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата X второй точки");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координата Y второй точки");
            y2 = Convert.ToDouble(Console.ReadLine());
            r=meth(x1, x2, y1, y2);
            Console.WriteLine("Расстояние между точками равно {0:F}",r);
            Console.ReadLine();
    }
    }
}
