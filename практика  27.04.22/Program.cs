using System;

namespace практика__27._04._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a;
            int b;
            int c;
            int d;
            Console.WriteLine(" Первая сторона a = 4");
            a = 4;
            Console.WriteLine("Вторая сторона b = 5a");
            b = 5*a;
            Console.WriteLine("Введите число c = 6b");
            c = 6*b;

            d = a + b + c;
            Console.WriteLine("Периметр=" + d);*/

           int a, b, c;
            double x,y, z;
            string buf;
            Console.Write("Введите целое значение a ");
            buf = Console.ReadLine();
            a = Convert.ToInt32(buf);
            Console.Write("Введите целое значение b ");
            buf = Console.ReadLine();
            b = Convert.ToInt32(buf);
            c = a + b;
            Console.WriteLine("a+b={0}", c);
            c = a * b;
            Console.WriteLine("a*b={0}", c);
            c = a / b;
            Console.WriteLine("a = {0} b = {1} a/b = {2}", a, b, c);
            Console.WriteLine("Выполняем алгоритм обмена: c = a; a = b; b = c;");
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a = {0} b = {1} c = {2}", a, b, c);
            Random rnd = new Random();
            Console.Write("rnd1 = new Random():");
            for (int i = 1; i <= 5; i++)
            {
                a = rnd.Next() % 101 - 50;
                Console.Write("  " + a.ToString());
            }
            Console.WriteLine();
            Console.Write("введите вещественное значение х");
            buf = Console.ReadLine();
            x = Convert.ToDouble(buf);
            y = Math.Sin(x);
            z = Math.Asin(y);
            Console.WriteLine("x = {0} sin(x) = {1:F5} Asin (sin(x)) = {2:F3}", x, y, z);
            x = Math.PI;
            y = Math.Sin(x);
            z = Math.Asin(y);
            Console.WriteLine("Для продолжение нажмите клавишу Enter");
            Console.ReadLine();








        }
    }
}
