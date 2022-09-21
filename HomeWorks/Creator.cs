using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    //урок 4, дз № 2
    public class Creator
    {
        //хэш-таблица
        private Hashtable _tableBuilding = new Hashtable();

        //свойство
        public Hashtable TableBuilding { get => _tableBuilding; }

        //фабрика
        public CreateBuild Create(double heightBuilding, int numberFloors,
                                  int numberApartments, int numberEntrances)  //фабрика
        {
            CreateBuild create = new CreateBuild(heightBuilding, numberFloors, numberApartments, numberEntrances);
            TableBuilding[create.Count] = create;
            return create;
        }

        //метод : удалить здание по номеру
        public void DeleteBuild(int numberBuild)
        {
            TableBuilding.Remove(numberBuild);
        }

        //вывод информации о всех созданных зданиях
        public void GetInfoAllCreatingBuilding()
        {
            ICollection collectionBuildingValues = TableBuilding.Values;
            foreach (CreateBuild currentBuilding in collectionBuildingValues)
            {
                currentBuilding.GetInfoBuilding();
            }
        }
    }
}
