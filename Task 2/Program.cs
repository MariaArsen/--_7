using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void GetParamsCub(double r, out double s, out double v)
        {
            s = 6 * r * r;
            v = r * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра");
            double r = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;
            GetParamsCub(r, out s, out v);
            Console.WriteLine("Объем={0:.0}   Площадь={1:.0}", v, s);
            Console.ReadKey();
        }
    }
}
