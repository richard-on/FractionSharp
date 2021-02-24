using System;

namespace fractionSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 999999999, numerator2 = 999999998;
            int denominator = 999999999, denominator2 = 999999998;

            try
            {
                Fraction fraction = new Fraction((int)numerator, (int)denominator);
                Fraction fraction2 = new Fraction((int)numerator2, (int)denominator2);

                Console.WriteLine(fraction);

                Console.WriteLine(fraction2);

                Console.WriteLine(fraction + fraction2);

                Console.WriteLine(fraction2 - fraction);

                Console.WriteLine(fraction2 * fraction);

                Console.WriteLine(fraction2 / fraction);

                bool res7 = fraction2 == fraction;
                Console.WriteLine(res7);

                bool res8 = fraction2 != fraction;
                Console.WriteLine(res8);

                bool res9 = fraction2 < fraction;
                Console.WriteLine(res9);

                bool res10 = fraction2 > fraction;
                Console.WriteLine(res10);

                bool res11 = fraction2 <= fraction;
                Console.WriteLine(res11);

                bool res12 = fraction2 >= fraction;
                Console.WriteLine(res12);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
