using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //общий интерфейс для всего курса
    public interface ILessons
    {
        //номер домашнего задания
        string Number { get; }

        //описание домашнего задания
        string Description { get; }

        //запуск задания
        void Run();
    }
}
