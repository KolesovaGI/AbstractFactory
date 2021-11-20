using System;
using System.Collections.Generic;
using AbstractFactory.AbstractProducts;
using AbstractFactory.Products;
using AbstractFactory.Creators;

namespace AbstractFactory.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Список автомобилей
            var list = new List<Car>()
            {
                new BaseCarCreator().Create(),      // Создание обычной машины
                new SportCarCreator().Create(),     // Создание спортивной машины
                new RacingCarCreator().Create(),    // Создание гоночной машины
                new SuperCarCreator().Create()      // Создание суперкара
            };

            var race = new Accelerator();           // Экземпляр класса движения
            race.AddCars(list);                     // Добавление автомобилей
            race.ShowInfo();                        // Вывод информации о каждом автомобиле
            race.StartRace();                       // Начать движение
        }
    }
}
