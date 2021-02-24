using System;

namespace fractionSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerator = 2, numerator2 = 1;
            int denominator = 24, denominator2 = 15;

            try
            {
                Fraction fraction = new Fraction((int)numerator, (int)denominator);
                Fraction fraction2 = new Fraction((int)numerator2, (int)denominator2);

                Console.WriteLine("Input fraction 1: " + fraction);

                Console.WriteLine("Input fraction 2: " + fraction2);

                Console.WriteLine(fraction2 + " + " + fraction + " = " + (fraction + fraction2));

                Console.WriteLine(fraction2 + " - " + fraction + " = " + (fraction2 - fraction));

                Console.WriteLine(fraction2 + " * " + fraction + " = " + fraction2 * fraction);

                Console.WriteLine(fraction2 + " / " + fraction + " = " + fraction2 / fraction);

                Console.WriteLine("5" + " + " + fraction2 + " = " + (5 + fraction2));

                Console.WriteLine(fraction2 + " + " + "5" + " = " + (fraction2 + 5));

                Console.WriteLine("5" + " - " + fraction2 + " = " + (5 - fraction2));

                Console.WriteLine(fraction2 + " - " + "5" + " = " + (fraction2 - 5));

                Console.WriteLine("5" + " * " + fraction2 + " = " + (5 * fraction2));

                Console.WriteLine(fraction2 + " * " + "5" + " = " + (fraction2 * 5));

                Console.WriteLine("5" + " / " + fraction2 + " = " + (5 / fraction2));

                Console.WriteLine(fraction2 + " / " + "5" + " = " + (fraction2 / 5));

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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
