

namespace UtilsNameSpace04
{
    using System;

    //--.
    public class Program
    {
        //--.
        static void FuncInputValues(out double side1Len, out double side2len, out double side3len)
        {

            while (true)
            {

                try
                {
                    Console.WriteLine("Введите длину 1-й стороны треугольника: ");
                    side1Len = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите длину 2-й стороны треугольника: ");
                    side2len = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите длину 3-й стороны треугольника: ");
                    side3len = Double.Parse(Console.ReadLine());

                    break;
                }
                catch 
                {
                    Console.WriteLine("Неверный формат ввода. Повторите ввод. ");
                }

            }
        }

        //--.
        static void FuncInputValues(out double sideLen)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите длину стороны треугольника: ");
                    sideLen = Double.Parse(Console.ReadLine());
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
            double side1Len, side2Len, side3Len, rS;
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
                    FuncInputValues(out side1Len);
                    //--.
                    ok = Operation.GeronS(in side1Len, in side1Len, in side1Len, out rS);
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
                    FuncInputValues(out side1Len, out side2Len, out side3Len);
                    //--.
                    ok = Operation.GeronS(in side1Len, in side2Len, in side3Len, out rS);
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
