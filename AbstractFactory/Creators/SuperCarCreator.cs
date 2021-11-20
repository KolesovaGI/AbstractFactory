using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Products;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.Creators
{
    public class SuperCarCreator : Creator
    {
        /// <summary>
        /// Создание суперкара
        /// </summary>
        /// <returns>Суперкар</returns>
        public override Car Create()
        {
            return new SuperCar();
        }
    }
}
