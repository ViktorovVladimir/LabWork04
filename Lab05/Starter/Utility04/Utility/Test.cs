﻿

namespace UtilsNameSpace04
{
    using System;

    //--.
    public class Program
    {
        //--.
        static void FuncInputValues(out double l1, out double l2, out double l3)
        {

            while (true)
            {

                try
                {
                    Console.WriteLine("Введите длину 1-й стороны треугольника: ");
                    l1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите длину 2-й стороны треугольника: ");
                    l2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите длину 3-й стороны треугольника: ");
                    l3 = Double.Parse(Console.ReadLine());

                    break;
                }
                catch 
                {
                    Console.WriteLine("Неверный формат ввода. Повторите ввод. ");
                }

            }
        }

        //--.
        static void FuncInputValues(out double l)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите длину стороны треугольника: ");
                    l = Double.Parse(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.WriteLine("Неверный формат ввода. Повторите ввод. ");
                }

            }
        }




        public static void Main()
        {
            double l1, l2, l3, rS;
            bool ok;


            while (true)
            {
                //--.
                Console.WriteLine("Будет ли треугольник равносторонним? (д - Да, н - Нет, e - Выход) :");
                string sAnswer = Console.ReadLine();
                
                //--.
                if (sAnswer[0] == 'д' || sAnswer[0] == 'Д')
                {
                    //Console.WriteLine("Равносторонний");
                    //--.
                    FuncInputValues(out l1);
                    //--.
                    ok = Operation.GeronS(in l1, in l1, in l1, out rS);
                    //--.

                    //--.
                    //Console.WriteLine("\tSumma \t\t {0} ", l1+l2+l3);
                    break;
                }

                //--.
                if (sAnswer[0] == 'н' || sAnswer[0] == 'Н')
                {
                    //Console.WriteLine("Не равносторонний");

                    //--.
                    FuncInputValues(out l1, out l2, out l3);
                    //--.
                    ok = Operation.GeronS(in l1, in l2, in l3, out rS);
                    //--.
                    break;
                }

                //--.
                if (sAnswer[0] == 'е' || sAnswer[0] == 'Е')
                {
                    return;
                }

            }

            if( !ok )
            {
                Console.WriteLine("Проверка сторон треугольника: Треугольника с такими сторонами НЕ СУЩЕСТВУЕТ!");
            }



            //--.
            Console.WriteLine("\tОтвет:");
            Console.WriteLine("\t------------------");
            Console.WriteLine("\tПлощадь треуголиника равна  {0:F2}", rS);

        }
    }
}
