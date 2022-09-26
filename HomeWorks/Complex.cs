using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //урок 5, дз № 2
    public class Complex
    {
        //поля
        private double _Re; //действительня часть комплексного числа
        private double _Im; //мнимая часть комплексного числа

        //свойства
        public double Re { get => _Re; set => _Re = value; }
        public double Im { get => _Im; set => _Im = value; }
        private double Denominator { get => Re * Re + Im * Im; }

        //конструкторы
        public Complex(double re) { Re = re; Im = 0.0; }
        public Complex(double re, double im) { Re = re; Im = im; }
        public Complex(Complex z) { Re = z.Re; Im = z.Im; }
        public Complex() { Re = 0.0; Im = 0.0; }

        //перегрузка "+"
        public static Complex operator +(Complex z1, Complex z2)
        {
            return new Complex(z1.Re + z2.Re, z1.Im + z2.Im);
        }
        public static Complex operator +(Complex z, double d)
        {
            return new Complex(z.Re + d, z.Im);
        }
        public static Complex operator +(double d, Complex z)
        {
            return new Complex(z.Re + d, z.Im);
        }

        //перегрузка "-"
        public static Complex operator -(Complex z1, Complex z2)
        {
            return new Complex(z1.Re - z2.Re, z1.Im - z2.Im);
        }
        public static Complex operator -(Complex z, double d)
        {
            return new Complex(z.Re - d, z.Im);
        }
        public static Complex operator -(double d, Complex z)
        {
            return new Complex(d - z.Re, -z.Im);
        }

        //перегрузка "*"
        public static Complex operator *(Complex z1, Complex z2)
        {
            return new Complex(z1.Re * z2.Re - z1.Im * z2.Im, z1.Re * z2.Im + z1.Im * z2.Re);
        }
        public static Complex operator *(Complex z, double d)
        {
            return new Complex(z.Re * d, z.Im * d);
        }
        public static Complex operator *(double d, Complex z)
        {
            return new Complex(z.Re * d, z.Im * d);
        }

        //перегрузка "/"
        public static Complex operator /(Complex z1, Complex z2)
        {
            double den = z2.Denominator;
            return new Complex((z1.Re * z2.Re + z1.Im * z2.Im) / den, (z2.Re * z1.Im - z2.Im * z1.Re) / den);
        }
        public static Complex operator /(Complex z, double d)
        {
            return new Complex(z.Re / d, z.Im / d);
        }
        public static Complex operator /(double d, Complex z)
        {
            double den = z.Denominator;
            return new Complex(z.Re * d / den, -z.Im * d / den);
        }

        //перегрузка == и !=
        public static bool operator ==(Complex z1, Complex z2) { return z1.Equals(z2); }
        public static bool operator !=(Complex z1, Complex z2) { return !(z1 == z2); }

        //перегрузка ToString()
        public override string ToString()
        {
            string s = Re.ToString();
            if (Im >= 0) s += "+";
            s += Im.ToString() + "*i";
            return s;
        }

        //перегрузка метода Equals()
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Complex temp = (Complex)obj;
            return temp.Re == Re && temp.Im == Im;
        }

        //перегрузка метода GetHashCode()
        public override int GetHashCode() { return Re.GetHashCode() + Im.GetHashCode(); }
    }
}
