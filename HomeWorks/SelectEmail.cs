using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //урок 3, дз № 3
    internal class SelectEmail
    {
        //поля
        private List<string> m_listData;  //список исходных данных  
        private List<string> m_listEmail; //список адресов электронной почты

        //конструктор
        public SelectEmail()
        {
            m_listData = new List<string>()
            { "Кучма Андрей Витальевич & Kuchma@mail.ru", 
              "Мизинцев Павел Николаевич & Pasha@mail.ru",
              "Хоменко Андрей Анатольевич & homenko@mail.ru" 
            };

            m_listEmail = new List<string>();
        }

        //метод: выделяет из строки e-mail
        private void SearchMail(ref string s)
        {
            s = s.Split(new char[] { '&' })[1].Trim();
        }

        //метод: формирует список e-mail адресов из файла
        private void FormedListEmail()
        {
            for(int i = 0; i < m_listData.Count; i++)
            {
                string s = m_listData[i];
                SearchMail(ref s);
                m_listEmail.Add(s);
            }
        }

        public void ShowResult()
        {
            Console.WriteLine("\nИсходные данные : ");
            m_listData.ForEach(s => Console.WriteLine(s));
            Console.WriteLine("\nСписок e-mail адресов : ");
            FormedListEmail();
            m_listEmail.ForEach(s => Console.WriteLine(s));
        }
    }
}
