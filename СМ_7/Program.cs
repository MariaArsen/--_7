using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СМ_7
{
    class Program
    {
        static double GetSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double s1 = GetSquare(x1, y1, z1);
            Console.WriteLine("Введите длины сторон второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double s2 = GetSquare(x2, y2, z2);

            if (s1 > s2)
                Console.WriteLine("Площадь первого треугольника больше");
            else if (s1 < s2)
                Console.WriteLine("Площадь втрого треугольника больше");
            else
                Console.WriteLine("Площадь треугольников равны");
            Console.ReadKey();
        }
    }
}
