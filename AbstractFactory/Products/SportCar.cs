using AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    /// <summary>
    /// Класс, релизующий создание спортивной машины, наследуемый от создания автомобиля
    /// </summary>
    public class SportCar : Car
    {
        /// <summary>
        /// Конструктор класса Спортивная машина
        /// </summary>
        /// <param name="model">Модель автомобиля</param>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="velocity">Сила увеличения скорости</param>
        public SportCar(string model = null, int maxSpeed = 175, int velocity = 4)
        {
            Brand = "Aston martin";
            model ??= "Vanquish";
            Model = model;
            MaxSpeed = maxSpeed;
            Velocity = velocity;
        }
    }
}
