using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double weight;
            double growth;
            double index;
            Console.WriteLine("Введите имя и фамилию");
            string fname = Console.ReadLine();
            string sname = Console.ReadLine();
            Console.Write($"Добрый день,{fname} {sname}!");
            Console.WriteLine("Заполните анкету для ИМТ");
            Console.WriteLine("Введите свой возраст");
            age  = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите свой Рост");
            growth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой Вес");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Подвердите данные:Имя {0} {1},",fname, sname);
            Console.WriteLine("Возраст {0:D},Возраст {1},Рост {1:N}см,Вес {2}кг",age, growth, weight);
            Console.WriteLine("ИМТ = Рост/(Вес^2)");
            Console.ReadKey();
            index = growth / (Math.Pow(weight,2));
            Console.WriteLine("ИМТ={0:N}",index);
            Console.ReadKey();
        }
    }
}
