using AbstractFactory.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    /// <summary>
    /// Класс, релизующий создание сцперкара, наследуемый от создания автомобиля
    /// </summary>
    public class SuperCar : Car
    {
        /// <summary>
        /// Конструктор класса Суперкар
        /// </summary>
        /// <param name="model">Модель автомобиля</param>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="velocity">Сила увеличения скорости</param>
        public SuperCar(string model = null, int maxSpeed = 400, int velocity = 3)
        {
            Brand = "Ferrari";
            model ??= "Mondial";
            Model = model;
            MaxSpeed = maxSpeed;
            Velocity = velocity;
        }
    }
}
