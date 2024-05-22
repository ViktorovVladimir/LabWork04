﻿


namespace UtilsNameSpace05
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    //--.
    class Operation
    {
        //--. Треугольник существует только тогда, когда сумма двух его сторон больше третьей
        static bool validTriangle( in double l1, in double l2, in double l3 )
        {
            if ((l1 + l2) <= l3 ||
                (l2 + l3) <= l1 ||
                (l3 + l1) <= l2 )
                return false;
            
            return true;
        }

        //--. расчёт дискриминанта
        static double discriminant(in double a, in double b, in double c)
        {
            return (double)(b * b - 4 * a * c);
        }


        //--.
        public static int Solution( in double a, in double b, in double c, ref double x1, ref double x2 )
        {
            //--.
            x1 = 0;
            x2 = 0;

            //--. Рассчитывает дискрименант D для понимания сколько будет корней
            //--. D < 0 - корней нет, возвращаем -1
            //--. D = 0 - есть один корень, возвращаем 0
            //--. D > 0, есть два различных корня, возвращаем 1
            double D = discriminant(in a, in b, in c );
            
            //--.
            if (  D < 0  )
            {
                return -1;
            }

            //--.
            if ( D == 0 )
            {
                //--.
                x1 = (-b + Math.Sqrt(D)) / (2 * a);

                return 0;
            }

            //--.
            x1 = (-b + Math.Sqrt(D) ) / (2 * a);
            //--.
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            return 1;


        }

    }
}
