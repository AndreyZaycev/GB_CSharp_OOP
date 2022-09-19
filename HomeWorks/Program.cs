using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ILessons> tasks = new List<ILessons>()
            {
                new Lesson2Task(),
                new Lesson3Task1(),
                new Lesson3Task2(),
                new Lesson3Task3()
            };

            
            bool bExit = true;
            do
            {
                BackgroundInformation.GetBackgroundInfo();

                Console.WriteLine("----------- МЕНЮ ВЫБОРА ЗАДАНИЙ ------------\n");

                foreach (var task in tasks)
                    Console.WriteLine($"Введите '{task.Number}' для вызова => {task.Description}");

                Console.Write("\nВведите номер задания : ");
                string taskNumber = Console.ReadLine();

                foreach (var task in tasks)
                    if (task.Number == taskNumber) task.Run();

                Console.Write("\nДля продолжения работы нажмите любую клавишу, для окончания n : ");
                bExit = (Console.ReadLine() == "n") ? false : true;
                Console.Clear();
            }
            while (bExit);
        }
    }
}
