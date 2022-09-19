using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Lesson3Task3 : ILessons
    {
        public string Number => "4";

        public string Description => "Урок № 3, дз № 3 : выделить из строки адрес почты";

        public void Run()
        {
            //
            Console.WriteLine("\nРешение домашнего задания № 3 урока № 3");

            //
            SelectEmail oSelEmail = new SelectEmail();
            oSelEmail.ShowResult();
        }
    }
}
