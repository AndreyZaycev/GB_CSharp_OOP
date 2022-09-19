using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //перечисление: тип банковского счета
    public enum TypeBankAccount
    {
        текущий,
        расчетный,
        кредитный,
        депозитный,
        бюджетный
    }

    //класс: банковский счет
    public class BankAccount
    {
        // --- поля --- //
        private static int _id = 0;             //статическая переменная для уникальности номера счета  
        private int m_count;                    //номер счета 
        private decimal m_balance;              //баланс счета
        private TypeBankAccount m_typeAccount;  //тип счета

        // --- свойства --- //
        public int Count
        {
            get => m_count;
            private set => m_count = value;     //установка только внутри класса  
        }
        public decimal Balance
        {
            get => m_balance;
            set => m_balance = value;
        }
        public TypeBankAccount TypeAccount
        {
            get => m_typeAccount;
            set => m_typeAccount = value;
        }

        // --- конструкторы --- //

        //по умолчанию
        public BankAccount()
        {
            Count = ++_id;
            Balance = 0;
            TypeAccount = TypeBankAccount.текущий;
        }

        //для заполнения баланса
        public BankAccount(decimal balance)
        {
            Count = ++_id;
            Balance = balance;
            TypeAccount = TypeBankAccount.текущий;
        }

        //для заполнения банковского счета
        public BankAccount(TypeBankAccount typeAccount)
        {
            Count = ++_id;
            Balance = 0;
            TypeAccount = typeAccount;
        }

        //для заполнения баланса и банковского счета
        public BankAccount(decimal balance, TypeBankAccount typeAccount)
        {
            Count = ++_id;
            Balance = balance;
            TypeAccount = typeAccount;
        }

        // --- методы --- //

        //снять со счета
        public bool Take(decimal sum)
        {
            bool bResult = false;
            if (Balance >= sum)
            {
                Balance -= sum;
                bResult = true;
            }
            return bResult;
        }

        //положить на счет
        public void Put(decimal sum)
        {
            Balance += sum;
        }

        //вывод информации об объекте класса
        public void GetInfo()
        {
            Console.WriteLine("----- БАНКОВСКИЙ СЧЕТ -----");
            Console.WriteLine($"Номер: {Count}");
            Console.WriteLine($"Баланс: {Balance} рублей");
            Console.WriteLine($"Тип: {TypeAccount}");
            Console.WriteLine("---------------------------");
        }

        //перевести деньги с одного счета на другой (для урока № 3, дз № 1)
        public bool Transfer(BankAccount bankAccount, decimal sum)
        {
            bool bResult = false;
            if (bankAccount.Take(sum))
            {
                Put(sum);
                bResult = true;
            }
            return bResult;
        }

    }
}
