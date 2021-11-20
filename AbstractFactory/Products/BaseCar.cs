using AbstractFactory.AbstractProducts;
using AbstractFactory.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    /// <summary>
    /// Класс, релизующий создание обычной машины, наследуемый от создания автомобиля
    /// </summary>
    public class BaseCar : Car
    {
        /// <summary>
        /// Конструктор класса Обыкновенная машина
        /// </summary>
        /// <param name="model">Модель автомобиля</param>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="velocity">Сила увеличения</param>
        public BaseCar(string model = null, int maxSpeed = 60, int velocity = 2)
        {
            Brand = "Ford";
            model ??= "Focus";
            Model = model;
            MaxSpeed = maxSpeed;
            Velocity = velocity;
        }
    }
}
