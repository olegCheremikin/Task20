using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        delegate double RadiusDelegate(double r);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус, R=");
            double r = Convert.ToDouble(Console.ReadLine());

            RadiusDelegate circumferenceDelegate = Circumference;
            if (circumferenceDelegate != null)
            {
                Console.WriteLine("Длина окружности с радиусом {0} = {1:F1}", r, circumferenceDelegate(r));
            }

            RadiusDelegate areaDelegate = Area;
            if (areaDelegate != null)
            {
                Console.WriteLine("Площадь круга с радиусом {0} = {1:F2}", r, areaDelegate(r));
            }

            RadiusDelegate volumeDelegate = Volume;
            if (volumeDelegate != null)
            {
                Console.WriteLine("Объём шара с радиусом {0} = {1:F2}", r, volumeDelegate(r));
            }
            Console.ReadKey();
        }

        static double Circumference(double r)
        {
            double result = 2 * Math.PI * r;
            return result;
        }
        static double Area(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        static double Volume(double r)
        {
            return (4 / 3) * Math.PI * Math.Pow(r, 3);
        }
    }
}
