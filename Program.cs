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

    class Lab14
    {
        public static void NullTest()
        {
            try
            {
                Console.WriteLine("Enter value: ");
                private double x = Int32.Parse(Console.ReadLine());
    }
}
    }
    #endregion
}
