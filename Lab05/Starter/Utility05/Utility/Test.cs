

namespace UtilsNameSpace05
{
    using System;

    //--.
    public class Program
    {
        //--.
        static void FuncInputValues(out double a, out double b, out double c)
        {

            while (true)
            {

                try
                {
                    Console.WriteLine("Введите коэффициент a: ");
                    a = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите коэффициент b: ");
                    b = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите коэффициент c: ");
                    c = Double.Parse(Console.ReadLine());
                    break;
                }
                catch 
                {
                    Console.WriteLine("Неверный формат ввода. Повторите ввод. ");
                }

            }
        }

        //--.
        public static void Main()
        {
            double a, b, c, x1 =0 , x2 = 0;
            int ret;


            //--. Осуществить ввод значений коэффициентов уравнения: a, b, c
            FuncInputValues(out a, out b, out c);

            //--.
            ret = Operation.Solution(in a, in b, in c, ref x1, ref x2);
            
            //--.
            Console.WriteLine("\tОтвет:");
            Console.WriteLine("\t------------------");

            //--.
            switch ( ret )
            {
                case 0:
                    Console.WriteLine( $"Корень уравнения с коэффициентами a = {a:F2}, b = {b:F2}, c = {c:F2} один: x1 = x2 = {x1:F2}" );
                    break;
                case 1:
                    Console.WriteLine($"Корни уравнения с коэффициентами a = {a:F2}, b = {b:F2}, c = {c:F2} равны: x1 = {x1:F2}, x2 = {x2:F2}");
                    break;
                case -1:
                    Console.WriteLine($"Корней уравнения с коэффициентами a = {a:F2}, b = {b:F2}, c = {c:F2} нет ");
                    break;
            }
        }
    }
}
