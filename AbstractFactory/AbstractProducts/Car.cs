using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractProducts
{
    /// <summary>
    /// Класс, описывающий автомобили
    /// </summary>
    public abstract class Car
    {
        public string Brand { get; set; }           // Марка
        public string Model { get; set; }           // Модель
        public int Speed { get; set; } = 0;         // Скорость
        public int MaxSpeed { get; set; }           // Максимальная скорость
        public int Velocity { get; set; }           // Сила движения
        public decimal Distance { get; set; } = 0;  // Расстояние

        /// <summary>
        /// Увеличение скорости
        /// </summary>
        public virtual void MoveForward()
        {
            if (Speed < MaxSpeed)                   // Если текущая скорость меньше максимума
            {
                Speed += Velocity;                  // Увеличить скорость
            }
        }

        /// <summary>
        /// Уменьшение скорости
        /// </summary>
        public virtual void MoveBack()
        {
            if (Speed > 0)                          // Если текущая скорость больше нуля
            {
                Speed -= Velocity;                  // Уменьшить скорость
            }
        }
    }
}
