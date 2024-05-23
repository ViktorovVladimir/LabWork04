


namespace UtilsNameSpace04
{
    using System;
    using System.Reflection.Metadata.Ecma335;

    //--.
    class Operation
    {
        //--. Треугольник существует только тогда, когда сумма двух его сторон больше третьей
        static bool validTriangle( in double side1Len, in double side2Len, in double side3Len)
        {
            if ((side1Len + side2Len) <= side3Len ||
                (side2Len + side3Len) <= side1Len ||
                (side3Len + side1Len) <= side2Len)
                return false;
            
            return true;
        }

        //--. расчёт площади
        static double SCalc(in double side1Len, in double side2Len, in double side3Len)
        {
            double rPerimetr = (side1Len + side2Len + side3Len) / 2;    // Полупериметр - это Периметр/2
            return (double) Math.Sqrt(rPerimetr * (rPerimetr - side1Len) * (rPerimetr - side2Len) * (rPerimetr - side3Len));
        }


        //--.
        public static bool GeronS( in double side1Len, in double side2Len, in double side3Len, out double rS )
        {
            rS = 0;
            
            //--. Проверяем наличия треугольника по заданным параметрам
            if( ! validTriangle(side1Len, side2Len, side3Len)  )
            {
                return false;
            }

            //--. расчёт площади
            rS = SCalc(side1Len, side2Len, side3Len);

            //--.
            return true; 
        }

        //--.
        public static bool GeronS(in double sideLen, out double rS)
        {
            rS = 0;

            //--. Проверяем наличия треугольника по заданным параметрам
            if (!validTriangle(sideLen, sideLen, sideLen))
            {
                return false;
            }

            //--. расчёт площади
            rS = SCalc(sideLen, sideLen, sideLen);

            //--.
            return true;
        }


    }
}
