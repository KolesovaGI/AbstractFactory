using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractProducts
{
    /// <summary>
    /// Класс релизующий создание автомобилей
    /// </summary>
    public abstract class Creator
    {
        public abstract Car Create();

        /// <summary>
        /// Создание автомобиля
        /// </summary>
        public void Log()
        {
            var car = Create();                                                         // Создание машины
            Console.WriteLine($"Автомобиль марки {car.Brand} модели {car.Model}");      // Вывод информации о машине
        }
    }
}
