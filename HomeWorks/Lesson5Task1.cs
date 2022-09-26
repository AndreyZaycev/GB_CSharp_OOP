using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //урок 5, дз № 1
    internal class Lesson5Task1 : ILessons
    {
        public string Number => "7";

        public string Description => "Урок № 5, дз № 1 : проверка работоспособности класса RationalNumber";
    
        public void Run()
        {
            //
            Console.WriteLine("\nРешение домашнего задания № 1 урока № 5");

            //
            Console.WriteLine("\nСоздание объектов");
            RationalNumber rn1 = new RationalNumber(1, 5);
            RationalNumber rn2 = new RationalNumber(-1, 7);
            RationalNumber rn3 = new RationalNumber(1, -10);
            RationalNumber rn4 = new RationalNumber(-1, 7);
            RationalNumber rn5 = new RationalNumber(-10, 3);
            RationalNumber rn6 = new RationalNumber(16, -3);
            RationalNumber rn7 = new RationalNumber(22, 18);
            ShowRationalNumber(nameof(rn1), rn1);
            ShowRationalNumber(nameof(rn2), rn2);
            ShowRationalNumber(nameof(rn3), rn3);
            ShowRationalNumber(nameof(rn4), rn4);

            //
            Console.WriteLine($"\nПроверка операции явного (explicit) преобразования типа RationalNumber в double");
            ExplicitOperation(nameof(rn2), rn2);
            ExplicitOperation(nameof(rn5), rn5); 
            ExplicitOperation(nameof(rn7), rn7);

            //
            Console.WriteLine($"\nПроверка операции неявного (implicit) преобразования типа RationalNumber в int");
            ImplicitOperation(nameof(rn2), rn2);
            ImplicitOperation(nameof(rn5), rn5);
            ImplicitOperation(nameof(rn7), rn7);

            //
            Console.WriteLine($"\nПроверка операций сравнения '>', '<', '>=', '<=', '==', '!='");
            CheckCompareOperations(">", rn1, rn7);
            CheckCompareOperations("<", rn1, rn7);
            CheckCompareOperations("<=", rn2, rn4);
            CheckCompareOperations(">=", rn2, rn4);
            CheckCompareOperations("<=", rn6, rn7);
            CheckCompareOperations(">=", rn6, rn7);
            CheckCompareOperations("==", rn2, rn4);
            CheckCompareOperations("==", rn1, rn3);
            CheckCompareOperations("!=", rn2, rn4);
            CheckCompareOperations("!=", rn1, rn3);

            //
            Console.WriteLine($"\nПроверка арифметических операций '+', '-', '*', '/', '%'");
            CheckArithmeticOperations("+", rn1, rn2);
            CheckArithmeticOperations("-", rn1, rn2);
            CheckArithmeticOperations("*", rn1, rn2);
            CheckArithmeticOperations("/", rn1, rn2);
            CheckArithmeticOperations("%", rn1, rn2);

            //
            Console.WriteLine($"\nПроверка унарных операций '++', '--'");
            CheckUnaryOperations("++", rn1);
            CheckUnaryOperations("--", rn7);
        }

        private void ShowRationalNumber(string sName, RationalNumber rn) { Console.WriteLine($"{sName} = {rn.ToString()}"); }

        private void ExplicitOperation(string sName, RationalNumber rn)
        {
            Console.WriteLine($"Число {sName} = {rn.ToString()} = {(double)rn}");
        }

        private void ImplicitOperation(string sName, RationalNumber rn)
        {
            int iRn = rn;
            Console.WriteLine($"Число {sName} = {rn.ToString()} = {iRn}");
        }

        private void CheckCompareOperations(string sNameOperator, RationalNumber rn1, RationalNumber rn2)
        {
            switch (sNameOperator)
            {
                case ">": Console.WriteLine($"Число {rn1} > {rn2} ==> {rn1 > rn2}"); break;
                case "<": Console.WriteLine($"Число {rn1} < {rn2} ==> {rn1 < rn2}"); break;
                case ">=": Console.WriteLine($"Число {rn1} >= {rn2} ==> {rn1 >= rn2}"); break;
                case "<=": Console.WriteLine($"Число {rn1} <= {rn2} ==> {rn1 <= rn2}"); break;
                case "==": Console.WriteLine($"Число {rn1} == {rn2} ==> {rn1 == rn2}"); break;
                case "!=": Console.WriteLine($"Число {rn1} != {rn2} ==> {rn1 != rn2}"); break;
            }
        }

        private void CheckArithmeticOperations(string sNameOperator, RationalNumber rn1, RationalNumber rn2)
        {
            switch (sNameOperator)
            {
                case "+": Console.WriteLine($"Число {rn1} + {rn2} ==> {(rn1 + rn2).ToString()}"); break;
                case "-": Console.WriteLine($"Число {rn1} - {rn2} ==> {(rn1 - rn2).ToString()}"); break;
                case "*": Console.WriteLine($"Число {rn1} * {rn2} ==> {(rn1 * rn2).ToString()}"); break;
                case "/": Console.WriteLine($"Число {rn1} / {rn2} ==> {(rn1 / rn2).ToString()}"); break;
                case "%": Console.WriteLine($"Число {rn1} % {rn2} ==> {(rn1 % rn2).ToString()}"); break;
            }
        }

        private void CheckUnaryOperations(string sNameOperator, RationalNumber rn)
        {
            switch (sNameOperator)
            {
                case "++": Console.WriteLine($"Число ++{rn} ==> {(++rn).ToString()}"); break;
                case "--": Console.WriteLine($"Число --{rn} ==> {(--rn).ToString()}"); break;
            }
        }
    }
}
