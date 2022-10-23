using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ
{
    internal class Парогенератор : Утюг, IGetPriceWithDiscount
    {
        protected float steamTemp;
        public Парогенератор(string pName, int pPrice, bool pWaterCompartment, float pMaxPower, float pSteamTemp) : base(pName, pPrice, pWaterCompartment, pMaxPower)
        {
            steamTemp = pSteamTemp;
        }
        override public string GetInfo()
        {
            return $"Название: {name}, Потребление энергии = {maxPower}, Температура пара: {steamTemp}";
        }

        new public void GetPrice()
        {
            Console.WriteLine($"На данную категорию скидка 44%, цена товара : {price * 0.56}");
        }
    }
}
