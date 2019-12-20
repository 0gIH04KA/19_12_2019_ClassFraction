using System;

namespace _19_12_2019_ClassFraction
{
    public class Fraction
    {
        #region ---===    Private    ===---

        private long _numerator;
        private long _denominator;

        private ErrorType _error;

        #endregion

        #region ---===    Get / Set    ===---

        public long Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
                _error = ErrorType.NoError;
            }
        }

        public long Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                if (value != 0)
                {
                    _denominator = value;
                    _error = ErrorType.NoError;
                }
                else
                {
                    _error = ErrorType.DenominatorIsZero;
                }

            }
        }

        #endregion

        #region ---===    Constructor    ===---

        public Fraction(long numerator)
        {
            Initialize(numerator, 1);
        }

        public Fraction(long numerator, long denominator)
        {
            Initialize(numerator, denominator);
        }

        #endregion

        #region ---===    Override Operator    ===---

        #region ---===    Binary Operations    ===---

        private static Fraction Add(Fraction frac1, Fraction frac2)
        {
            checked
            {
                long numerator = (frac1.Numerator * frac2.Denominator)
                    + (frac2.Numerator * frac1.Denominator);
                long denominator = frac1.Denominator * frac2.Denominator;

                return new Fraction(numerator, denominator);
            }
        }

        private static Fraction Multiply(Fraction frac1, Fraction frac2)
        {
            checked
            {
                long numerator = frac1.Numerator * frac2.Numerator;
                long denominator = frac1.Denominator * frac2.Denominator;

                return new Fraction(numerator, denominator);
            }
        }

        #endregion

        #region ---===    Operator +    ===---

        public static Fraction operator +(Fraction frac1, Fraction frac2)
        { 
            return (Add(frac1, frac2)); 
        }

        public static Fraction operator +(int value, Fraction fraction)
        {
            return (Add(new Fraction(value), fraction));
        }

        public static Fraction operator +(Fraction fraction, int value)
        {
            return (Add(fraction, new Fraction(value)));
        }

        public static Fraction operator +(double value, Fraction fraction)
        {
            return (Add(ToFraction(value), fraction));
        }

        public static Fraction operator +(Fraction fraction, double value)
        {
            return (Add(fraction, ToFraction(value)));
        }

        #endregion

        #region ---===    Operator -    ===---

        public static Fraction operator -(Fraction frac1)
        {
            return Negative(frac1);
        }

        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            return (Add(frac1, -frac2));
        }

        public static Fraction operator -(int value, Fraction fraction)
        {
            return (Add(new Fraction(value), -fraction));
        }

        public static Fraction operator -(Fraction fraction, int value)
        {
            return (Add(fraction, -(new Fraction(value))));
        }


        public static Fraction operator -(double value, Fraction fraction)
        {
            return (Add(ToFraction(value), -fraction));
        }

        public static Fraction operator -(Fraction fraction, double value)
        {
            return (Add(fraction, -ToFraction(value)));
        }

        #endregion

        #region ---===    Operator *    ===---

        public static Fraction operator *(Fraction frac1, Fraction frac2)
        {
            return (Multiply(frac1, frac2));
        }

        public static Fraction operator *(int value, Fraction fraction)
        {
            return (Multiply(new Fraction(value), fraction));
        }

        public static Fraction operator *(Fraction fraction, int value)
        {
            return (Multiply(fraction, new Fraction(value)));
        }

        public static Fraction operator *(double value, Fraction fraction)
        {
            return (Multiply(ToFraction(value), fraction));
        }

        public static Fraction operator *(Fraction fraction, double value)
        {
            return (Multiply(fraction, ToFraction(value)));
        }

        #endregion

        #region ---===    Operator /    ===---

        public static Fraction operator /(Fraction frac1, Fraction frac2)
        {
            return (Multiply(frac1, GetReverseFraction(frac2)));
        }

        public static Fraction operator /(int value, Fraction fraction)
        {
            return (Multiply(new Fraction(value), GetReverseFraction(fraction)));
        }

        public static Fraction operator /(Fraction fraction, int value)
        {
            return (Multiply(fraction, GetReverseFraction(new Fraction(value))));
        }

        public static Fraction operator /(double value, Fraction fraction)
        {
            return (Multiply(ToFraction(value), GetReverseFraction(fraction)));
        }

        public static Fraction operator /(Fraction fraction, double value)
        {
            return (Multiply(fraction, GetReverseFraction(ToFraction(value))));
        }

        #endregion

        #region ---===    Comparison operations    ===--- 

        #region ---===    Operator Equals    ===---

        public static bool operator ==(Fraction frac1, Fraction frac2)
        {
            return (frac1.Numerator == frac2.Numerator) && (frac1.Denominator == frac2.Denominator);
        }

        // ToDo: Так можно ???
        public static bool operator ==(Fraction fraction, int value)
        {
            return fraction.Equals(new Fraction(value));
        }
        // ??

        #endregion

        #region ---===    Operator DontEquals    ===---

        public static bool operator !=(Fraction frac1, Fraction frac2)
        {
            return !(frac1 == frac2);
        }

        // ToDo: Так можно ???
        public static bool operator !=(Fraction fraction, int value)
        {
            return (!fraction.Equals(new Fraction(value)));
        }
        //

        #endregion

        public static bool operator <(Fraction frac1, Fraction frac2)
        {
            return frac1.Numerator * frac2.Denominator < frac2.Numerator * frac1.Denominator;
        }

        public static bool operator >(Fraction frac1, Fraction frac2)
        {
            return frac1.Numerator * frac2.Denominator > frac2.Numerator * frac1.Denominator;
        }

        public static bool operator <=(Fraction frac1, Fraction frac2)
        {
            return frac1.Numerator * frac2.Denominator <= frac2.Numerator * frac1.Denominator;
        }

        public static bool operator >=(Fraction frac1, Fraction frac2)
        {
            return frac1.Numerator * frac2.Denominator >= frac2.Numerator * frac1.Denominator;
        }

        #endregion

        // ToDo: почему без этого нормально не выводит в консоль?
        public override string ToString()
        {
            string str;

            if (Denominator == 1)
            {
                str = Numerator.ToString();
            }
            else
            {
                str = Numerator + "/" + Denominator;
            }

            return str;
        }

        #endregion

        #region ---===    Metods    ===---

        private void Initialize(long numerator, long denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            ReduceFraction(this);
        }

        /// <summary>
        /// The function reduces(simplifies) a Fraction object by dividing both its numerator 
        /// and denominator by their greatest common divisor (GCD)
        /// </summary>
        public static void ReduceFraction(Fraction frac)
        {
            if (frac.Numerator == 0)
            {
                frac.Denominator = 1;

                return;
            }

            long GCD = GetGCD(frac.Numerator, frac.Denominator);

            frac.Numerator /= GCD;
            frac.Denominator /= GCD;

            if (frac.Denominator < 0)
            {
                frac.Numerator *= -1;
                frac.Denominator *= -1;
            }
        }

        private static long GetGCD(long a, long b)
        {
            if (a < 0)
            {
                a = Math.Abs(a);
            }
            if (b < 0)
            {
                b = Math.Abs(b);
            }

            do
            {
                if (a < b)
                {
                    long tmp = a;
                    a = b;
                    b = tmp;
                }

                a = a % b;

            } while (a != 0);

            return b;
        }

        private static long GetGCDRec(long x, long y)
        {
            if (y == 0)
            {
                return x;
            }
           
            return GetGCDRec(y, x % y);
        }

        public static Fraction ToFraction(double value)
        {
            if (value % 1 == 0)
            {
                return new Fraction((long)value);
            }
            else
            {
                return new Fraction((long)value);

                // ToDo: Дописать обработку чисел с плавающей точкой 
            }
        }

        public static Fraction GetReverseFraction(Fraction frac1)
        {
            if (frac1.Numerator == 0)
            {
                return null; 
            }

            long numerator = frac1.Denominator;
            long denominator = frac1.Numerator;

            return new Fraction(numerator, denominator);
        }

        private static Fraction Negative(Fraction frac1)
        {
            long numerator = -frac1.Numerator;
            long denominator = frac1.Denominator;

            return (new Fraction(numerator, denominator));
        }

        #endregion

    } 
}
