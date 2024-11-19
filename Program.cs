using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        /// <summary>
        /// ввод вершин
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты вершин треугольника:");
            Console.Write("X1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("X2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Y2: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.Write("X3: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("Y3: ");
            int y3 = int.Parse(Console.ReadLine());
            double Side1 = Wide1(x1, y1, x2, y2);
            double Side2 = Wide2(x2, y2, x3, y3);
            double Side3 = Wide3(x3, y3, x1, y1);
            double per = Perimetr(Side1, Side2, Side3);
            Console.WriteLine($"{Area(Side1,Side2,Side3)}");
            Console.WriteLine($"{per}");
            Console.Read();
        }
        /// <summary>
        /// рассчитываем первую сторону
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        static double Wide1(double x1, double y1, double x2, double y2)
        {
         return (int) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        /// <summary>
        /// рассчитываем вторую сторону
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        static double Wide2(double x2,double y2,double x3,double y3)
        {
            return (int)Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        }
        /// <summary>
        /// рассчитываем третью сторону
        /// </summary>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <returns></returns>
        static double Wide3(double x3, double y3, double x1, double y1)
        {
            return (int)Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
        }
        /// <summary>
        /// находим площадь
        /// </summary>
        /// <param name="Side1"></param>
        /// <param name="Side2"></param>
        /// <param name="Side3"></param>
        /// <returns></returns>
        static double Area(double Side1, double Side2, double Side3)
        {
            double s = (Side1 + Side2 + Side3);
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }
        /// <summary>
        /// Ищем периметр
        /// </summary>
        /// <param name="Side1"></param>
        /// <param name="Side2"></param>
        /// <param name="Side3"></param>
        /// <returns></returns>
        static double Perimetr(double Side1, double Side2, double Side3)
        {
            return Side1 + Side2 + Side3;
        }
    }
}
