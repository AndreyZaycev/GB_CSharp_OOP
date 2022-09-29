using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class Lesson6Task1 : ILessons
    {
        public string Number => "9";

        public string Description => "Урок № 6, дз № 1 : проверка функционирования переопределенных методов и опреаторов BankAccount";

        public void Run()
        {
            Console.WriteLine("\nРешение домашнего задания # 1 урока № 6");

            //
            Console.WriteLine("\n--- Создание объектов и вывод информации о созданных объектах перегруженным методом ToString() ---");
            BankAccount account1 = new BankAccount((decimal)1200.75, TypeBankAccount.расчетный);
            BankAccount account2 = new BankAccount((decimal)1565.15, TypeBankAccount.депозитный);
            BankAccount account3 = new BankAccount((decimal)1200.75, TypeBankAccount.расчетный);
            Console.WriteLine(account1.ToString());
            Console.WriteLine(account2.ToString()); 
            Console.WriteLine(account3.ToString());

            //
            Console.WriteLine("\n--- Проверка операций сравнения '==', '!=' ---");
            CheckCompareOperations("==", account1, account2);
            CheckCompareOperations("==", account1, account3);
            CheckCompareOperations("!=", account1, account2);
            CheckCompareOperations("!=", account1, account3);

            //
            Console.WriteLine("\n--- Проверка перегруженного метода GetHashCode() ---");
            Console.WriteLine($"Хэш-код account1 = {account1.GetHashCode()}");
            Console.WriteLine($"Хэш-код account2 = {account2.GetHashCode()}");
            Console.WriteLine($"Хэш-код account3 = {account3.GetHashCode()}");
        }

        private void CheckCompareOperations(string sNameOperator, BankAccount account1, BankAccount account2)
        {
            switch (sNameOperator)
            {
                case "==": 
                    Console.WriteLine($"Банковский счет № {account1.Count} == Банковский счет № {account2.Count} ==> {account1 == account2}"); 
                    break;
                case "!=": 
                    Console.WriteLine($"Банковский счет № {account1.Count} != Банковский счет № {account2.Count} ==> {account1 != account2}"); 
                    break;
            }
        }
    }
}
