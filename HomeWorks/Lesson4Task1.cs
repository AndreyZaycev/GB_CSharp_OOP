using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Lesson4Task1 : ILessons
    {
        public string Number => "5";

        public string Description => "Урок № 4, дз № 1 : проверка работоспособности класса Building";

        public void Run()
        {
            //
            Console.WriteLine("\nРешение домашнего задания № 1 урока № 4");

            //
            Building oBuild_1 = new Building(50.0, 10, 100, 2);
            Building oBuild_2 = new Building(60.0, 20, 120, 3);
            Building oBuild_3 = new Building(80.0, 20, 160, 4);

            //
            oBuild_1.GetInfoBuilding();
            oBuild_2.GetInfoBuilding();
            oBuild_3.GetInfoBuilding();
        }
    }
}
