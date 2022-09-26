using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //урок 5, дз № 2
    internal class Lesson5Task2 : ILessons
    {
        public string Number => "8";

        public string Description => "Урок № 5, дз № 2 : проверка работоспособности класса Complex";

        public void Run()
        {
            //
            Console.WriteLine("\nРешение домашнего задания № 2 урока № 5");

            //
            Console.WriteLine("\nСоздание объектов (проверка конструкторов)");
            Complex z1 = new Complex(5.5);
            Complex z2 = new Complex(1.3, 3.8);
            Complex z3 = new Complex(-2.2, 4.1);
            Complex z4 = new Complex(4.6, -2.9);
            Complex z5 = new Complex(-3.7, -12.3);
            Complex z6 = new Complex(z3);
            Complex z7 = new Complex();
            ShowComplex(nameof(z1), z1); ShowComplex(nameof(z2), z2); ShowComplex(nameof(z3), z3);
            ShowComplex(nameof(z4), z4); ShowComplex(nameof(z5), z5); ShowComplex(nameof(z6), z6);
            ShowComplex(nameof(z7), z7);

            //
            Console.WriteLine("\nПроверка свойств на примере z4");
            Console.Write($"Комплексное число z4 до изменений => "); ShowComplex(nameof(z4), z4);
            Console.WriteLine("Установка : Re = -13.75; Im = 22.85");
            z4.Re = -13.75; z4.Im = 22.85;
            Console.Write($"Комплексное число z4 после изменений => "); ShowComplex(nameof(z4), z4);

            //
            Console.WriteLine("\nПроверка операторов '+'");
            Complex z8 = z2 + z3; ShowComplex(nameof(z8), z8);
            Complex z9 = z2 + 1.5; ShowComplex(nameof(z9), z9);
            Complex z10 = 2.8 + z5; ShowComplex(nameof(z10), z10);

            //
            Console.WriteLine("\nПроверка операторов '-'");
            Complex z11 = z5 - z3; ShowComplex(nameof(z11), z11);
            Complex z12 = z5 - 11.5; ShowComplex(nameof(z12), z12);
            Complex z13 = 22.85 - z5; ShowComplex(nameof(z13), z13);

            //
            Console.WriteLine("\nПроверка операторов '*'");
            Complex z14 = z5 * z3; ShowComplex(nameof(z14), z14);
            Complex z15 = z5 * 11.5; ShowComplex(nameof(z15), z15);
            Complex z16 = 22.85 * z5; ShowComplex(nameof(z16), z16);

            //
            Console.WriteLine("\nПроверка операторов '/'");
            Complex z17 = z5 / z3; ShowComplex(nameof(z17), z17);
            Complex z18 = z5 / 11.5; ShowComplex(nameof(z18), z18);
            Complex z19 = 22.85 / z5; ShowComplex(nameof(z19), z19);

            //
            //Проверка операторов '==' и '!='
            Complex z_1 = new Complex(3.75, -5.70);
            Complex z_2 = new Complex(-5.15, -2.95);
            Complex z_3 = new Complex(3.75, -5.70);
            
            //
            Console.WriteLine("\nПроверка оператора '=='");
            CompareComplexNumber(true, z_1, z_2);  //проверка '=='
            CompareComplexNumber(true, z_1, z_3);  //проверка '=='
            
            //
            Console.WriteLine("\nПроверка оператора '!='");
            CompareComplexNumber(false, z_1, z_2); //проверка '!='
            CompareComplexNumber(false, z_1, z_3); //проверка '!='
        }

        private void ShowComplex(string sName, Complex z) { Console.WriteLine($"{sName} = {z.ToString()}"); }
    
        private void CompareComplexNumber(bool bOperator, Complex z1, Complex z2)
        {
            string sResult = "";
            if (bOperator) //'=='
            {
                sResult = (z1 == z2) ? "равны" : "не равны";
            }
            else           //'!='
            {
                sResult = (z1 != z2) ? "не равны" : "равны";
            }

            //можно и так
            //string sResult = (bOperator) ? ((z1 == z2) ? "равны" : "не равны") : ((z1 != z2) ? "не равны" : "равны");

            Console.WriteLine($"Сравнение числа {z1.ToString()} и числа {z2.ToString()} ==> {sResult}"); 
        }
    }
}
