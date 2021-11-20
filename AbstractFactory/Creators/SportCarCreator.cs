using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.Creators
{
    public class SportCarCreator : Creator
    {
        /// <summary>
        /// Создание спортивной машины
        /// </summary>
        /// <returns>Спортивная машина</returns>
        public override Car Create()
        {
            return new SportCar();
        }
    }
}
