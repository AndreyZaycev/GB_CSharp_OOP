using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //класс: проверка работы класса BankAccount - домашнее задания к уроку № 2
    public class Lesson2Task : ILessons
    {
        public string Number => "1";

        public string Description => "Урок № 2, дз : проверка работы класса BankAccount";

        public void Run()
        {
            //
            Console.WriteLine("\nРешение домашнего задания урока № 2");

            //
            Console.WriteLine("\n--- Создание объектов и вывод информации о созданных объектах ---");
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount((decimal)1000.50);
            BankAccount account3 = new BankAccount(TypeBankAccount.бюджетный);
            BankAccount account4 = new BankAccount((decimal)1200.75, TypeBankAccount.расчетный);
            account1.GetInfo();
            account2.GetInfo();
            account3.GetInfo();
            account4.GetInfo();

            //
            Console.WriteLine("\n--- Проверка работы свойств на примере account1 ---");
            Console.WriteLine("Устанавливаем баланс : 2080.70 рублей; Устанавливаем тип банковского счета : депозитный");
            account1.Balance = (decimal)2080.70;
            account1.TypeAccount = TypeBankAccount.депозитный;
            account1.GetInfo();

            //
            Console.WriteLine("\n--- Проверка метода Put класса BankAccount на примере account1 ---");
            CheckPut(account1, (decimal)2350.55);

            //
            Console.WriteLine("\n--- Проверка метода Take класса BankAccount на примере account1 ---");
            CheckTake(account1, (decimal)4350.55);
            Console.WriteLine();
            CheckTake(account1, (decimal)1350.75);
        }

        private void CheckPut(BankAccount account, decimal sum)
        {
            Console.WriteLine($"Текущий баланс на счете № {account.Count} до зачисления составляет {account.Balance} рублей");
            Console.WriteLine($"Сумма зачисления : {sum} рублей");
            account.Put(sum);
            Console.WriteLine($"Текущий баланс на счете № {account.Count} после зачисления составляет {account.Balance} рублей");
        }

        private void CheckTake(BankAccount account, decimal sum)
        {
            Console.WriteLine($"Текущий баланс на счете № {account.Count} составляет {account.Balance} рублей");
            string sResult = (account.Take(sum)) ? $"Сумма {sum} рублей снята со счета № {account.Count}. Текущий баланс = {account.Balance} рублей"
                                                 : $"Сумму {sum} рублей невозможно снять со счета № {account.Count}. Текущий баланс = {account.Balance} рублей";
            Console.WriteLine(sResult);
        }
    }
}
