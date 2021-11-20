using AbstractFactory.AbstractProducts;
using AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Creators
{
    public class BaseCarCreator : Creator
    {
        /// <summary>
        /// Создание обычной машины
        /// </summary>
        /// <returns>Обычная машина</returns>
        public override Car Create()
        {
            return new BaseCar();
        }
    }
}
