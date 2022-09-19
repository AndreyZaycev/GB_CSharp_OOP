using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //класс: проверка работы метода Transfer класса BankAccount - домашнее задания № 1 к уроку № 3
    public class Lesson3Task1 : ILessons
    {
        public string Number => "2";

        public string Description => "Урок № 3, дз № 1 : проверка работы метода Transfer (перевод денег) класса BankAccount";

        public void Run()
        {
            //
            Console.WriteLine("\nРешение домашнего задания № 1 урока № 3");

            //
            Console.WriteLine("\n--- Создание объектов и вывод информации о созданных объектах ---");
            BankAccount creditAccount = new BankAccount((decimal)1200.75, TypeBankAccount.расчетный);
            BankAccount recoilAccount = new BankAccount((decimal)5500.25, TypeBankAccount.депозитный);
            Console.WriteLine("Cчет на который будет зачислена сумма");
            creditAccount.GetInfo();
            Console.WriteLine("Cчет с которого будет переведена сумма на счет зачисления");
            recoilAccount.GetInfo();

            //
            Console.WriteLine("Операция перевода № 1");
            CheckTransfer(creditAccount, recoilAccount, (decimal)4500.25);
            Console.WriteLine("\nОперация перевода № 2");
            CheckTransfer(creditAccount, recoilAccount, (decimal)1500.25);
        }

        private void CheckTransfer(BankAccount creditAccount, BankAccount recoilAccount, decimal sum)
        {
            Console.WriteLine($"\nТекущий баланс на счете № {creditAccount.Count} до перевода составляет {creditAccount.Balance} рублей");
            Console.WriteLine($"Текущий баланс на счете № {recoilAccount.Count} до перевода составляет {recoilAccount.Balance} рублей");
            Console.WriteLine($"Выполняется операция перевода {sum} рублей со счета № {recoilAccount.Count} на счет № {creditAccount.Count} ...");
            if (creditAccount.Transfer(recoilAccount, sum))
            {
                Console.WriteLine("Операция выполнена");
                Console.WriteLine($"Текущий баланс на счете № {creditAccount.Count} после перевода составляет {creditAccount.Balance} рублей");
                Console.WriteLine($"Текущий баланс на счете № {recoilAccount.Count} после перевода составляет {recoilAccount.Balance} рублей");
            }
            else
            {
                Console.WriteLine($"Недостаточно средств на счете № {recoilAccount.Count}");
            }
        }
    }
}
