using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ
{
    internal class Утюг : БытТехника, IGetPriceWithDiscount
    {
        protected float maxPower;
        protected bool waterCompartment;
        public Утюг(string pName, int pPrice, bool pWaterCompartment, float pMaxPower) : base(pName, pPrice)
        {
            maxPower = pMaxPower;
            waterCompartment = pWaterCompartment;
        }

        override public string GetInfo()
        {
            return $"Название: {name}, Потребление энергии = {maxPower}";
        }

        new public void GetPrice()
        {
            Console.WriteLine($"На данную категорию нет скидок, цена товара : {price}");
        }
    }
}
