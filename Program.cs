using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lab1.Lab11.Lab11_Input();
            //Lab1.Lab12.TernarnaOut();
            //Lab1.Lab13.SwitchTrigger();
            //Lab1.Lab14.NumTest();
            //Lab1.Lab15.SumOut();
            //Lab1.Lab16.FactorialRealization();
            Lab1.Lab17.QuadratOut();
            Console.ReadKey(true);
            Console.WriteLine();
        }
    }

    #region Lab1.1 

    //Написать программу которая выводит решение уравнения на опеределенном интервале с заданым шагом и условием 
    class Lab11
    {
        static double Lab11_Function(double argument) // функция в которой производится вычисления в зависимости от условия меньше или больше 5
        {
            if (argument < 5)
            {
                return (Math.Pow(Math.Cos(0.5 * argument - 2.5), argument));
            }
            else
            {
                return ((Math.Pow(argument - 4, 1 / 3) / Math.Pow(Math.E, argument - 5)) + 4);
            }
        }

        public static void Lab11_Input() //метод для ввода и вывода данных
        {
            Console.WriteLine("Enter start of interval");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end of interval");
            int ending = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter steap of function");
            int steap = int.Parse(Console.ReadLine());

            for (int i = start; i <= ending; i += steap)
            {
                Console.WriteLine("Для на числа {0} = {1}", i, Lab11_Function(start));
                Console.WriteLine();
            }
        }
    }
    #endregion

    #region Lab1.2

    //Реалізувати алгоритм і програму, в якій уводиться x, обчислюється вираз та виводиться y, який дорівнює -1, якщо f(x) < 0, 
    //дорівнює 0, якщо f(x) = 0, та 1, якщо f(x) > 0. Використати тернарну умовну операцію
    class Lab12
    {
        static double Ternarna(double x)
        {
            return x > 0 ? 1 : (x < 0 ? -1 : 0);
        }

        public static void TernarnaOut()
        {
            Console.WriteLine("Enter value");
            double z = Int32.Parse(Console.ReadLine());
            double y = Math.Pow(z, 3);
            Console.WriteLine(Ternarna(y));
        }

    }
    #endregion

    #region Lab1.3

    class Lab13
    {
        public static void SwitchTrigger()
        {
            Console.WriteLine("Enter value: ");
            string x = Console.ReadLine();

            switch (x)
            {
                case "yes":
                    Console.WriteLine("20");
                    break;
                case "no":
                    Console.WriteLine("100");
                    break;
                default:
                    Console.WriteLine(0.5.ToString());
                    break;
            }
        }
    }
    #endregion

    #region Lab1.4

    //Работа с null совместимостью
    class Lab14
    {
        public static void NumTest()
        {
            Console.WriteLine();
            try
            {
                double x = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error!");
            }

        }
    }
    #endregion

    #region Lab1.5

    class Lab15
    {
        static void SumNum(double m)
        {
            double sum = 1;
            for (double i = 2; i <= m; i*=i)
            {
                sum += 1/i;
            }
            Console.WriteLine("Result: {0}", sum);
        }

        public static void SumOut()
        {
            Console.WriteLine("Sum of y = 1 + 1/2 + 1/4 + ... + 1/sqr(n)\nEnter n");
            double n = Int32.Parse(Console.ReadLine());
            SumNum(n);
        }
    }
    #endregion

    #region Lab1.6

    class Lab16
    {
        public static void FactorialRealization()
        {
            Console.WriteLine("Enter n and get factorial");
            double x = System.Int32.Parse(Console.ReadLine());
            FactorialThrowCycle(x);
            Console.WriteLine("Factorial throw recursion: {0}", FactorialThrowRecursion(x));
        }

        static void FactorialThrowCycle(double y1)
        {
            double z1 = 1, result = 1;
            while (z1 <=  y1)
            {
                result *= z1;
                z1++;
            }
            Console.WriteLine("Factorial throw cycle: {0}", result);
        }

        static double? FactorialThrowRecursion(double y1)
        {
            if (y1 == 0)
                return null;
            if (y1 == 1)
                return 1;
            return y1 * FactorialThrowRecursion(y1 - 1);
            
        }
    }
    #endregion

    #region Lab1.7
    class Lab17
    {
        static void Solve(double a, double b, double c,
                             out double x1, out double x2)
        {
            double d = b * b - 4 * a * c;
            x1 = (-b - Math.Sqrt(d)) / (2 * a);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
        }

        public static void QuadratOut()
        {
            double x1, x2;
            double a = 1;
            double b = 1;
            double c = 2;
            Solve(a, b, c, out x1, out x2);
            Console.WriteLine("x1 = {0} x2 = {1}", x1, x2);
        }

    }
    #endregion
}
