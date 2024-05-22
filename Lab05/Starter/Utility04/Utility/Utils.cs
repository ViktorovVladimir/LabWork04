


namespace UtilsNameSpace04
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

        //--. расчёт площади
        static double SCalc(in double l1, in double l2, in double l3)
        {
            double rPerimetr = (l1 + l2 + l3) / 2;    // Полупериметр - это Периметр/2
            return (double) Math.Sqrt(rPerimetr * (rPerimetr - l1) * (rPerimetr - l2) * (rPerimetr - l3));
        }


        //--.
        public static bool GeronS( in double l1, in double l2, in double l3, out double rS )
        {
            rS = 0;
            
            //--. Проверяем наличия треугольника по заданным параметрам
            if( ! validTriangle( l1, l2, l3 )  )
            {
                return false;
            }

            //--. расчёт площади
            rS = SCalc(l1, l2, l3);

            //--.
            return true; 
        }

        //--.
        public static bool GeronS(in double l, out double rS)
        {
            rS = 0;

            //--. Проверяем наличия треугольника по заданным параметрам
            if (!validTriangle(l, l, l))
            {
                return false;
            }

            //--. расчёт площади
            rS = SCalc(l, l, l);

            //--.
            return true;
        }


    }
}
