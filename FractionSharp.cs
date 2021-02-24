using System;
using System.Collections.Generic;
using System.Text;

namespace fractionSharp
{
    class Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public Fraction(int numerator = 0, int denominator = 1)
        {
            setFraction(numerator, denominator);
        }

        public Fraction(int numerator)
        {
            int denominator = 1;
            setFraction(numerator, denominator);
        }

        public void setFraction(int numerator, int denominator)
        {
            if (numerator == 0)
            {
                denominator = 1;
            }
            if (denominator < 0)
            {
                Denominator = -denominator;
                Numerator = -numerator;
            }
            else if (denominator == 0)
            {
                throw new ArgumentException("Denominator is equal to 0. Division by 0 is not allowed.");
            }
            else
            {
                Denominator = denominator;
                Numerator = numerator;
            }
            reduce();
        }

        private static long gdc(long numerator, long denominator)
        {
            long gcd, max = 0, min = 0;
            long remainder = 1;
            if (numerator == denominator)
            {
                return gcd = numerator;
            }
            if (numerator > denominator)
            {
                max = numerator;
                min = denominator;
            }
            if (numerator < denominator)
            {
                max = denominator;
                min = numerator;
            }
            while (min != 0)
            {
                remainder = max % min;
                max = min;
                min = remainder;
            }
            gcd = max;

            return gcd;
        }

        private static long lcm(long numerator, long denominator)
        {
            long Gdc = gdc(numerator, denominator);
            long lcm = checked(numerator * (denominator / Gdc));

            return lcm;
        }

        private Fraction reduce()
        {
            int Gdc = (int)gdc(Math.Abs(Numerator), Math.Abs(Denominator));

            Numerator /= Gdc;
            Denominator /= Gdc;

            return this;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
            if (obj is Fraction)
            {
                return this == (obj as Fraction);
            }
            else
            {
                throw new ArgumentException("Object should be Fraction.");
            }
        }

        public override int GetHashCode()
        {
            return Numerator.GetHashCode() + Denominator.GetHashCode();
        }

        public static Fraction operator -(Fraction fr1)
        {
            Fraction a = new Fraction();
            a.Numerator = -fr1.Numerator;
            a.Denominator = fr1.Denominator;

            return a;
        }

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            Fraction a = new Fraction();
            long numerator, denominator;

            numerator = checked(fr1.Numerator * lcm(fr1.Denominator, fr2.Denominator) / fr1.Denominator) + (fr2.Numerator * lcm(fr1.Denominator, fr2.Denominator) / fr2.Denominator);
            denominator = lcm(fr1.Denominator, fr2.Denominator);
            a.setFraction((int)numerator, (int)denominator);

            return a;
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            return fr1 + (-fr2);
        }

        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            Fraction a = new Fraction();
            long numerator, denominator;

            numerator = checked(fr1.Numerator * fr2.Numerator);
            denominator = checked(fr1.Denominator * fr2.Denominator);
            a.setFraction((int)numerator, (int)denominator);

            return a;
        }

        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            Fraction a = new Fraction();
            long numerator, denominator;

            numerator = checked(fr1.Numerator * fr2.Denominator);
            denominator = checked(fr1.Denominator * fr2.Numerator);
            a.setFraction((int)numerator, (int)denominator);

            return a;
        }

        public static Fraction operator +(int a, Fraction fr2)
        {
            Fraction fr1 = new Fraction(a);
            return fr1 + fr2;
        }

        public static Fraction operator -(int a, Fraction fr2)
        {
            Fraction fr1 = new Fraction(a);
            return fr1 - fr2;
        }

        public static Fraction operator *(int a, Fraction fr2)
        {
            Fraction fr1 = new Fraction(a);
            return fr1 * fr2;
        }

        public static Fraction operator /(int a, Fraction fr2)
        {
            Fraction fr1 = new Fraction(a);
            return fr1 / fr2;
        }

        public static bool operator ==(Fraction fr1, Fraction fr2)
        {
            return (fr1.Numerator == fr2.Numerator && fr1.Denominator == fr2.Denominator);
        }

        public static bool operator !=(Fraction fr1, Fraction fr2)
        {
            return !(fr1 == fr2);
        }

        public static bool operator <(Fraction fr1, Fraction fr2)
        {
            return checked((fr1.Numerator * lcm(fr1.Denominator, fr2.Denominator) / fr1.Denominator) <
        (fr2.Numerator * lcm(fr1.Denominator, fr2.Denominator) / fr2.Denominator));
        }

        public static bool operator >(Fraction fr1, Fraction fr2)
        {
            return !(fr1 <= fr2);
        }

        public static bool operator <=(Fraction fr1, Fraction fr2)
        {
            return fr1 < fr2 || fr1 == fr2;
        }

        public static bool operator >=(Fraction fr1, Fraction fr2)
        {
            return !(fr1 < fr2);
        }

        public override string ToString()
        {
            string str;
            if (Numerator == 0 || Denominator == 1)
            {
                str = Numerator.ToString();
            }
            else
            {
                str = Numerator + "/" + Denominator;
            }

            return str;
        }

    }
}