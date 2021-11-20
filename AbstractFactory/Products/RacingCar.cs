using AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    /// <summary>
    /// Класс, релизующий создание гоночной машины, наследуемый от создания автомобиля
    /// </summary>
    public class RacingCar : Car
    {
        /// <summary>
        /// Конструктор класса Гоночная машина
        /// </summary>
        /// <param name="model">Модель автомобиля</param>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="velocity">Сила увеличения скорости</param>
        public RacingCar(string model = null, int maxSpeed = 220, int velocity = 5)
        {
            Brand = "Bugatti";
            model ??= "Veyron";
            Model = model;
            MaxSpeed = maxSpeed;
            Velocity = velocity;
        }
    }
}
