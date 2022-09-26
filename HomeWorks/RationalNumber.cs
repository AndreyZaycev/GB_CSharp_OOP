using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //урок 5, дз № 1
    public class RationalNumber
    {
        //поля
        private int _numerator;    //числитель
        private int _denominator;  //знаменатель

        //свойства
        public int Numerator { get => _numerator; set => _numerator = value; }
        public int Denominator { get => _denominator; set => _denominator = value; }
        
        //конструктор
        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        //оператор явного преобразования RationalNumber в double
        public static explicit operator double(RationalNumber rn) { return (double)rn.Numerator / (double)rn.Denominator; }

        //!!оператор неявного преобразования RationalNumber в int
        public static implicit operator int(RationalNumber rn) { return (int)(rn.Numerator / rn.Denominator); }

        //перегрузка оператора '>'
        public static bool operator >(RationalNumber rn1, RationalNumber rn2) { if ((double)rn1 < (double)rn2) return false; return true; }

        //перегрузка оператора '<'
        public static bool operator <(RationalNumber rn1, RationalNumber rn2) { if ((double)rn1 > (double)rn2) return false; return true; }

        //перегрузка оператора '>='
        public static bool operator >=(RationalNumber rn1, RationalNumber rn2) { if ((double)rn1 < (double)rn2) return false; return true; }
        
        //перегрузка оператора '<='
        public static bool operator <=(RationalNumber rn1, RationalNumber rn2) { if ((double)rn1 > (double)rn2) return false; return true; }
        
        //перегрузка оператора '+'
        public static RationalNumber operator +(RationalNumber rn1, RationalNumber rn2) 
        {
            return new RationalNumber(rn1.Numerator * rn2.Denominator + rn1.Denominator * rn2.Numerator, rn1.Denominator * rn2.Denominator);
        }

        //перегрузка оператора '-'
        public static RationalNumber operator -(RationalNumber rn1, RationalNumber rn2)
        {
            return new RationalNumber(rn1.Numerator * rn2.Denominator - rn1.Denominator * rn2.Numerator, rn1.Denominator * rn2.Denominator);
        }

        //перегрузка оператора '*'
        public static RationalNumber operator *(RationalNumber rn1, RationalNumber rn2)
        {
            return new RationalNumber(rn1.Numerator * rn2.Numerator, rn1.Denominator * rn2.Denominator);
        }

        //перегрузка оператора '/'
        public static RationalNumber operator /(RationalNumber rn1, RationalNumber rn2)
        {
            return new RationalNumber(rn1.Numerator * rn2.Denominator, rn1.Denominator * rn2.Numerator);
        }

        //перегрузка оператора '%'
        public static double operator %(RationalNumber rn1, RationalNumber rn2) { return (double)rn1 % (double)rn2; }

        //перегрузка оператора '++'
        public static RationalNumber operator ++(RationalNumber rn) { return new RationalNumber(rn.Numerator + 1, rn.Denominator + 1); }

        //перегрузка оператора '--'
        public static RationalNumber operator --(RationalNumber rn) { return new RationalNumber(rn.Numerator - 1, rn.Denominator - 1); }

        //перегрузка == и !=
        public static bool operator ==(RationalNumber rn1, RationalNumber rn2) { return rn1.Equals(rn2); }
        public static bool operator !=(RationalNumber rn1, RationalNumber rn2) { return !(rn1 == rn2); }

        //перегрузка ToString()
        public override string ToString() 
        {
            string sResult = "";
            int den = Denominator;
            if (Denominator < 0) { sResult = "-"; den = Math.Abs(Denominator); }
            return sResult + $"{Numerator}/{den}"; 
        }

        //перегрузка метода Equals()
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            RationalNumber temp = (RationalNumber)obj;
            return temp.Numerator == Numerator && temp.Denominator == Denominator;
        }

        //перегрузка метода GetHashCode()
        public override int GetHashCode() { return Numerator ^ Denominator; }
    }
}
