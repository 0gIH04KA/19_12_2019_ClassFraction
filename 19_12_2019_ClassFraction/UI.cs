using System;
using System.Collections.Generic;
using System.Text;

namespace _19_12_2019_ClassFraction
{
    public class UI
    {
        static string str = "\nДля продолжениея нажмите любую кнопку\n";

        #region ---===    Print Fraction    ===---

        public static void PrintFraction(Fraction fraction)
        {
            Console.WriteLine($"Fraction  = {fraction}");
        }

        public static void PrintFraction(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"Fraction 1 = {frac1}");
            Console.WriteLine($"Fraction 2 = {frac2}");
        }

        #endregion

        #region ---===    Print Add    ===---

        public static void PrintAdd(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} + {frac2} = {frac1 + frac2}");
        }

        public static void PrintAdd(int i, Fraction frac)
        {
            Console.WriteLine($"{i} + {frac} = {i + frac}");
        }

        public static void PrintAdd(Fraction frac, int i)
        {
            Console.WriteLine($"{frac} + {i} = {frac + i}");
        }

        public static void PrintAdd(int i, int j)
        {
            Console.WriteLine($"{i} + {j} = {i + j}");
        }

        #endregion

        #region ---===    Print Subtract    ===---

        public static void PrintSubtract(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} - {frac2} = {frac1 - frac2}");
        }

        public static void PrintSubtract(int i, Fraction frac)
        {
            Console.WriteLine($"{i} - {frac} = {i - frac}");
        }

        public static void PrintSubtract(Fraction frac, int i)
        {
            Console.WriteLine($"{frac} - {i} = {frac - i}");
        }

        public static void PrintSubtract(int i, int j)
        {
            Console.WriteLine($"{i} - {j} = {i - j}");
        }

        #endregion

        #region ---===    Print Multiply    ===---

        public static void PrintMultiply(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} * {frac2} = {frac1 * frac2}");
        }

        public static void PrintMultiply(int i, Fraction frac)
        {
            Console.WriteLine($"{i} * {frac} = {i * frac}");
        }

        public static void PrintMultiply(Fraction frac, int i)
        {
            Console.WriteLine($"{frac} * {i} = {frac * i}");
        }

        public static void PrintMultiply(int i, int j)
        {
            Console.WriteLine($"{i} * {j} = {i * j}");
        }

        #endregion

        #region ---===    Print Divide    ===---

        public static void PrintDivide(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} / {frac2} = {frac1 / frac2}");
        }

        public static void PrintDivide(int i, Fraction frac)
        {
            Console.WriteLine($"{i} / {frac} = {i / frac}");
        }

        public static void PrintDivide(Fraction frac, int i)
        {
            Console.WriteLine($"{frac} / {i} = {frac / i}");
        }

        public static void PrintDivide(int i, int j)
        {
            Console.WriteLine($"{i} / {j} = {i / j}");
        }

        #endregion

        #region ---===    Print Equals    ===---

        public static void PrintEquals(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} == {frac2} = {frac1 == frac2}");
        }

        /* ToDo: =(
        public static void PrintEquals(double i, Fraction frac)
        {
            Console.WriteLine($"{i} == {frac} = {i == frac}");
        }
        */

        public static void PrintEquals(Fraction frac, int i)
        {
            Console.WriteLine($"{frac} == {i} = {frac == i}");
        }

        #endregion

        #region ---===    Print DontEquals    ===---

        public static void PrintDontEquals(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} != {frac2} = {frac1 != frac2}");
        }

        public static void PrintDontEquals(Fraction frac, int i)
        {
            Console.WriteLine($"{frac} != {i} = {frac != i}");
        }

        #endregion

        #region ---===    Print > / >=    ===---

        public static void PrintFractionLarger(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} > {frac2} = {frac1 > frac2}");
        }

        public static void PrintFractionGreaterOrEqual(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} >= {frac2} = {frac1 >= frac2}");
        }

        #endregion

        #region ---===    Print < / <=    ===---

        public static void PrintFractionLess(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} < {frac2} = {frac1 < frac2}");
        }

        public static void PrintFractionLessOrEqual(Fraction frac1, Fraction frac2)
        {
            Console.WriteLine($"{frac1} <= {frac2} = {frac1 <= frac2}");
        }

        #endregion

        #region  ---===    Print     ===---

        public static void CreatingFraction()
        {
            Console.WriteLine("Создание дробей\n");

            Test.Create1();

            Console.WriteLine();

            Test.Create2();

            Console.WriteLine();

            Test.Create3();

            Console.WriteLine();

            Test.Create4();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static void AddFraction()
        {
            Console.WriteLine("Cложение дробей\n");

            Test.Add1();

            Console.WriteLine();

            Test.Add2();

            Console.WriteLine();

            Test.Add3();

            Console.WriteLine();

            Test.Add4();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static void SubtractFraction()
        {
            Console.WriteLine("Вычитание дробей\n");

            Test.Subtract1();

            Console.WriteLine();

            Test.Subtract2();

            Console.WriteLine();

            Test.Subtract3();

            Console.WriteLine();

            Test.Subtract4();

            Console.WriteLine(str);

            Console.ReadKey();

        }

        public static void MultiplyFraction()
        {
            Console.WriteLine("Умножение дробей\n");

            Test.Multiply1();

            Console.WriteLine();

            Test.Multiply2();

            Console.WriteLine();

            Test.Multiply3();

            Console.WriteLine();

            Test.Multiply4();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static void DivideFraction()
        {
            Console.WriteLine("Деление дробей\n");

            Test.Divide1();

            Console.WriteLine();

            Test.Divide2();

            Console.WriteLine();

            Test.Divide3();

            Console.WriteLine();

            Test.Divide4();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static void EqualsFraction()
        {
            Console.WriteLine("Равенство дробей\n");

            Test.Equals1();

            Console.WriteLine();

            Test.Equals2();

            Console.WriteLine();

            Test.Equals3();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static void DontEqualsFraction()
        {
            Console.WriteLine("НЕ Равенство дробей\n");

            Test.DontEquals1();

            Console.WriteLine();

            Test.DontEquals2();

            Console.WriteLine();

            Test.DontEquals3();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static void FractionLarger()
        {
            Console.WriteLine("A > B\n");

            Test.FractionLarger1();

            Console.WriteLine();

            Test.FractionLarger2();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static void FractionGreaterOrEqual()
        {
            Console.WriteLine("A >= B\n");

            Test.GreaterOrEqual1();

            Console.WriteLine();

            Test.GreaterOrEqual2();

            Console.WriteLine();

            Test.GreaterOrEqual3();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static void FractionLess()
        {
            Console.WriteLine("A < B\n");

            Test.FractionLess1();

            Console.WriteLine();

            Test.FractionLess2();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        public static void FractionLessOrEqual()
        {
            Console.WriteLine("A <= B\n");

            Test.LessOrEqual1();

            Console.WriteLine();

            Test.LessOrEqual2();

            Console.WriteLine();

            Test.LessOrEqual3();

            Console.WriteLine();

            Console.WriteLine(str);

            Console.ReadKey();
        }

        #endregion

    }
}
