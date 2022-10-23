using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ
{
    internal class Микроволновка : БытТехника, IGetPriceWithDiscount
    {
        protected int maxPower;
        public Микроволновка(string pName, int pPrice, int pMaxPower) : base(pName, pPrice)
        {
            maxPower = pMaxPower;
        }
        override public string GetInfo()
        {
            return $"Название: {name}, Максимальная мощность = {maxPower}";
        }

        new public void GetPrice()
        {
            Console.WriteLine($"На данную категорию скидка 20%, цена товара : {price*0.8}");
        }
    }
}
