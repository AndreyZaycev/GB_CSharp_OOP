using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    public class Building
    {
        private static int _id = 0;             //статическая переменная для уникальности номера здания 
        private int m_count;                    //номер здания 
        private double m_heightBuilding;        //высота всего здания
        private int m_numberFloors;             //количество этажей всего здания
        private int m_numberApartments;         //количество квартир во всем здании
        private int m_numberEntrances;          //количество подъездов во всем здании

        public int Count
        {
            get => m_count;
            private set => m_count = value;     //установка только внутри класса  
        }

        public Building(double heightBuilding, int numberFloors, int numberApartments, int numberEntrances)
        {
            Count = ++_id;
            m_heightBuilding = heightBuilding;
            m_numberFloors = numberFloors;
            m_numberApartments = numberApartments;
            m_numberEntrances = numberEntrances;
        }

        //метод вычисления высоты одного этажа 
        private double GetHeightOneFloor()
        {
            return (double)(m_heightBuilding / m_numberFloors);
        }

        //метод вычисления количества квартир в подъезде
        private int GetNumberApartmentsOneEntrance()
        {
            return m_numberApartments / m_numberEntrances;
        }

        //метод вычисления количества квартир на этаже
        private int GetNumberApartmentsOneFloor()
        {
            return GetNumberApartmentsOneEntrance() / m_numberFloors;
        }

        //метод : вывод информации об объекте
        public void GetInfoBuilding()
        {
            Console.WriteLine("--- Здание ---");
            Console.WriteLine($"Номер здания : {Count}");
            Console.WriteLine($"Высота всего здания, м : {m_heightBuilding}");
            Console.WriteLine($"Количество этажей во всем здании, штук : {m_numberFloors}");
            Console.WriteLine($"Количество квартир во всем здании, штук : {m_numberApartments}");
            Console.WriteLine($"Количество подъездов во всем здании, штук : {m_numberEntrances}");
            Console.WriteLine($"Высота одного этажа здания, м : {GetHeightOneFloor()}");
            Console.WriteLine($"Количество квартир в подъезде, штук : {GetNumberApartmentsOneEntrance()}");
            Console.WriteLine($"Количество квартир на этаже, штук : {GetNumberApartmentsOneFloor()}");
        }
    }
}
