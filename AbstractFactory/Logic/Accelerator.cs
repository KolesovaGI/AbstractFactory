using AbstractFactory.AbstractProducts;
using AbstractFactory.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Logic
{
    /// <summary>
    /// Класс для реализации движения автомобилей
    /// </summary>
    public class Accelerator
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Accelerator()
        {
            _listOfCars = new();                            // Новый список автомобилей
            Distance = 8000;                                // Длина маршрута
        }

        public int Distance { get; set; }                   // Расстояние
        private List<Car> _listOfCars;                      // Список автомобилей
        private int _place = 1;                             // Текущее естоположение

        /// <summary>
        /// Добавление автомобилей
        /// </summary>
        /// <param name="listOfCars">Списко с автомобилями</param>
        public void AddCars(List<Car> listOfCars)
        {
            foreach (var car in listOfCars)                 // Для каждого автомобиля из списка автомобилей
            {               
                _listOfCars.Add(car);                       // Добавление автомобиля в список
            }
        }

        /// <summary>
        /// Добавления автомобиля
        /// </summary>
        /// <param name="car">Автомобиль</param>
        public void AddCar(Car car)
        {
            _listOfCars.Add(car);                           // Добавление автомобиля в список
        }

        /// <summary>
        /// Набор скорости автомобиля
        /// </summary>
        public void StartRace()
        {
            while (_listOfCars.Count != 0)                  // Пока список заполнен автомобилями
            {
                foreach (var car in _listOfCars)            // Для каждого автомобиля из списка автомобилей
                {
                    car.MoveForward();                      // Увеличить скорость
                    car.Distance += car.Speed / 3.6m;       // Перевод из км/ч в м/с
                }

                while (Check()) { }                         // Метод исполяется, пока исполяется проверка
            }
        }

        /// <summary>
        /// Проверка местоположения автомобиля
        /// </summary>
        public bool Check()
        {
            foreach (var car in _listOfCars)                // Для каждого автомобиля из списка автомобилей
            {
                if (car.Distance >= Distance)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} на {_place} месте");
                    _place++;                               // Изменить текущего местоположения
                    _listOfCars.Remove(car);                // Убрать автомобили, доехавшие до места назначения

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Вывод информации об автомобиле
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("Об автомобиле:");

            foreach (var car in _listOfCars)                // Для каждого автомобиля из списка автомобилей
            {
                Console.WriteLine($"Автомобиль {car.Brand} модель {car.Model}");
            }
        }
    }
}
