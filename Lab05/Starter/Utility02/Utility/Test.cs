

namespace UtilsNameSpace02
{
    using System;

    //--.
    public class Test
    {
        public static void Main()
        {
            //--. Get input numbers
            Console.WriteLine("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            //--. Test the Greater() method
            Console.WriteLine("Before swap: " + x + ", " + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + ", " + y);
        }
    }
}
