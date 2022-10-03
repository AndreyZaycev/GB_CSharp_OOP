using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    public class Lesson7Task1 : ILessons
    {
        public string Number => "11";

        public string Description => "Урок № 7, дз № 1 : проверка функционирования классов ACoder и BCoder";

        public void Run()
        {
            //
            Console.WriteLine("\nРешение домашнего задания # 1 урока № 7");

            //Проверка работы класса ACoder
            Check_Acoder();

            //Проверка работы класса BCoder
            Check_Bcoder();
        }
    
        private void Check_Acoder()
        {
            Console.WriteLine("\nПроверка работы класса ACoder");
            string inString = "Проверка работы класса ACoder";
            Console.WriteLine($"Строка для шифрования : {inString}");
            ACoder aCd = new ACoder(inString);
            string encodeString = aCd.Encode();
            Console.WriteLine($"Строка после шифрования : {encodeString}");
            string decodeString = aCd.Decode();
            Console.WriteLine($"Строка после дешифрования : {decodeString}");
        }

        private void Check_Bcoder()
        {
            Console.WriteLine("\nПроверка работы класса BCoder");
            string inString = "АБВГД ЕЁЖЗИЙК ЛМНОП  РСТУФ ХЦЧШЩЪЫЬЭ ЮЯ абвг! деёжз& ийклмн? опрст уфхцч шщъ ыьэ юя!!  ABKLGFGJjkLKJKL 444 gfmgnfdgnm,nbpwojgkls!";
            Console.WriteLine($"Строка для шифрования : {inString}");
            BCoder bCd = new BCoder(inString);
            string encodeString = bCd.Encode();
            Console.WriteLine($"Строка после шифрования : {encodeString}");
            string decodeString = bCd.Decode();
            Console.WriteLine($"Строка после дешифрования : {decodeString}");
        }
    }
}
