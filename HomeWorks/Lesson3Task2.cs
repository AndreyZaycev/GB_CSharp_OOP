using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Lesson3Task2 : ILessons
    {
        public string Number => "3";

        public string Description => "Урок № 3, дз № 2 : проверка работы метода GetReverseString (строка в обратном порядке) класса ReverseString";

        public void Run()
        {
            //
            Console.WriteLine("\nРешение домашнего задания № 2 урока № 3");

            //
            string testString = "Эту строку необходимо вывести в обратном порядке";
            ReverseString revStr = new ReverseString(testString);
            string revString = revStr.GetReverseString();

            Console.WriteLine("Тестовая строка : " + testString);
            Console.WriteLine("Тестовая строка с буквами в обратном порядке : " + revString);
        }
    }
}
