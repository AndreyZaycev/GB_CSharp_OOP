using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //общий класс для всего курса : класс общей информации
    internal class BackgroundInformation
    {
        public static void GetBackgroundInfo()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Курс :          Основы ООП в С#");
            Console.WriteLine("Преподаватель : Кучма Андрей Витальевич");
            Console.WriteLine("Студент :       Зайцев Андрей");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
        }
    }
}
