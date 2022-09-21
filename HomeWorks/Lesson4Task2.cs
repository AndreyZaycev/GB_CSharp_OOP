using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Lesson4Task2 : ILessons
    {
        public string Number => "6";

        public string Description => "Урок № 4, дз № 2 : проверка работоспособности классов CreateBuild и Creator (фабрика)";

        public void Run()
        {
            //
            Console.WriteLine("\nРешение домашнего задания № 2 урока № 4");

            //создание объектов
            Creator creator = new Creator();
            CreateBuild o1 = creator.Create(50.0, 10, 100, 2);
            CreateBuild o2 = creator.Create(60.0, 20, 120, 3);
            CreateBuild o3 = creator.Create(80.0, 20, 160, 4);

            //вывод информации о всех созданных объектах
            Console.WriteLine(" ----- Информация о всех созданных зданиях до удаления -----");
            creator.GetInfoAllCreatingBuilding();

            //удаление здания - удалим здание с уникальным номером 2
            Console.WriteLine(" \n----- Информация о всех созданных зданиях после удаления здания № 2 -----");
            creator.DeleteBuild(2);
            creator.GetInfoAllCreatingBuilding();
        }
    }
}
