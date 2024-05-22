

namespace UtilsNameSpace03
{
    using System;

    //--.
    public class Test
    {
        public static void Main()
        {
            //int f;      // Factorial result
            //bool ok;    // Factorial success or failure
            
            //--. Get input numbers
            Console.WriteLine("Enter number for factorial: ");
            int x = int.Parse(Console.ReadLine());

            bool ok = Utils.Factorial(x, out int f);

            // Output factorial results
            if( ok ) 
            {
                Console.WriteLine("Factorial( " + x + " ) = " + f );
            }
            else
            {
                Console.WriteLine("Cannot compute this factorial" );
            }
        }
    }
}
