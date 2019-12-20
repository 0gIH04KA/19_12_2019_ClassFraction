using System;
using System.Collections.Generic;
using System.Text;

namespace _19_12_2019_ClassFraction
{
    class Test
    {
        #region ---===    Create Fraction    ===---

        public static void Create1()
        {
            Fraction fraction = new Fraction(1);

            UI.PrintFraction(fraction);
        }

        public static void Create2()
        {
            Fraction fraction = new Fraction(2, 3);

            UI.PrintFraction(fraction);
        }

        public static void Create3()
        {
            Fraction fraction = new Fraction(4, 6);

            UI.PrintFraction(fraction);
        }

        public static void Create4()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(4, 5);

            UI.PrintFraction(frac1, frac2);
        }

        #endregion

        #region ---===    Add    ===---

        public static void Add1()
        {
            Fraction fraction = new Fraction(1);
            int myInt = 7;

            UI.PrintAdd(fraction, myInt);
        }

        public static void Add2()
        {
            Fraction fraction = new Fraction(2,3);
            int myInt = 2;

            UI.PrintAdd(fraction, myInt);
        }

        public static void Add3()
        {
            int myInt = 2;
            Fraction fraction = new Fraction(2, 3);

            UI.PrintAdd(myInt, fraction);
        }

        public static void Add4()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintAdd(frac1, frac2);
        }

        #endregion

        #region ---===    Subtract    ===---

        public static void Subtract1()
        {
            Fraction fraction = new Fraction(3);
            int myInt = 2;

            UI.PrintSubtract(fraction, myInt);
        }

        public static void Subtract2()
        {
            Fraction fraction = new Fraction(7, 3);
            int myInt = 2;

            UI.PrintSubtract(fraction, myInt);
        }

        public static void Subtract3()
        {
            int myInt = 1;
            Fraction fraction = new Fraction(1, 3);
            

            UI.PrintSubtract(myInt, fraction);
        }

        public static void Subtract4()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(1, 3);


            UI.PrintSubtract(frac1, frac2);
        }

        #endregion

        #region ---===    Multiply    ===---

        public static void Multiply1()
        {
            Fraction fraction = new Fraction(3);
            int myInt = 2;

            UI.PrintMultiply(fraction, myInt);
        }

        public static void Multiply2()
        {
            Fraction fraction = new Fraction(2, 3);
            int myInt = 2;

            UI.PrintMultiply(fraction, myInt);
        }

        public static void Multiply3()
        {
            int myInt = 2;
            Fraction fraction = new Fraction(2, 3);

            UI.PrintMultiply(myInt, fraction);
        }

        public static void Multiply4()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintMultiply(frac1, frac2);
        }

        #endregion

        #region ---===    Divide    ===---

        public static void Divide1()
        {
            Fraction fraction = new Fraction(3);
            int myInt = 2;

            UI.PrintDivide(fraction, myInt);
        }

        public static void Divide2()
        {
            Fraction fraction = new Fraction(5, 6);
            int myInt = 2;

            UI.PrintDivide(fraction, myInt);
        }

        public static void Divide3()
        {
            int myInt = 2;
            Fraction fraction = new Fraction(2, 3);

            UI.PrintDivide(myInt, fraction);
        }

        public static void Divide4()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(3, 2);

            UI.PrintDivide(frac1, frac2);
        }
        #endregion

        #region ---===    Equals    ===---

        // ToDO: =(
        public static void Equals1()
        {
            Fraction fraction = new Fraction(7);
            int myInt = 7;

            UI.PrintEquals(fraction, myInt);
        }

        public static void Equals2()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintEquals(frac1, frac2);
        }

        public static void Equals3()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(3, 2);

            UI.PrintEquals(frac1, frac2);
        }

        #endregion

        #region ---===    DontEquals    ===---

        // ToDo: =(
        public static void DontEquals1()
        {
            Fraction fraction = new Fraction(7);
            int myInt = 7;

            UI.PrintDontEquals(fraction, myInt);
        }

        public static void DontEquals2()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(5, 3);

            UI.PrintDontEquals(frac1, frac2);
        }

        public static void DontEquals3()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintDontEquals(frac1, frac2);
        }

        #endregion

        #region ---===    >    ===---

        public static void FractionLarger1()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(5, 3);

            UI.PrintFractionLarger(frac1, frac2);
        }

        public static void FractionLarger2()
        {
            Fraction frac1 = new Fraction(5, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintFractionLarger(frac1, frac2);
        }

        #endregion

        #region ---===    >=    ===---

        public static void GreaterOrEqual1()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(5, 3);

            UI.PrintFractionGreaterOrEqual(frac1, frac2);
        }

        public static void GreaterOrEqual2()
        {
            Fraction frac1 = new Fraction(5, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintFractionGreaterOrEqual(frac1, frac2);
        }

        public static void GreaterOrEqual3()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintFractionGreaterOrEqual(frac1, frac2);
        }

        #endregion

        #region ---===    <    ===---

        public static void FractionLess1()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(5, 3);

            UI.PrintFractionLess(frac1, frac2);
        }

        public static void FractionLess2()
        {
            Fraction frac1 = new Fraction(5, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintFractionLess(frac1, frac2);
        }

        #endregion

        #region ---===    <=    ===---

        public static void LessOrEqual1()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(5, 3);

            UI.PrintFractionLessOrEqual(frac1, frac2);
        }

        public static void LessOrEqual2()
        {
            Fraction frac1 = new Fraction(5, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintFractionLessOrEqual(frac1, frac2);
        }

        public static void LessOrEqual3()
        {
            Fraction frac1 = new Fraction(2, 3);
            Fraction frac2 = new Fraction(2, 3);

            UI.PrintFractionLessOrEqual(frac1, frac2);
        }

        #endregion

    }
}
