using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.AbstractProducts;
using AbstractFactory.Products;

namespace AbstractFactory.Creators
{
    public class RacingCarCreator : Creator
    {
        /// <summary>
        /// Создание гоночной машины
        /// </summary>
        /// <returns>Гоночная машина</returns>
        public override Car Create()
        {
            return new RacingCar();
        }
    }
}
