using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ
{
    internal class Пылесос : БытТехника, IGetPriceWithDiscount
    {
        protected int weight;
        protected string type;
        public Пылесос(string pName, int pPrice, int pWeight, string pType) : base(pName, pPrice)
        {
            type=pType;
            weight=pWeight;
        }
        override public string GetInfo()
        {
            return $"Название: {name}, Вес = {weight}";
        }
        new public void GetPrice()
        {
            Console.WriteLine($"На данную категорию скидка 5%, цена товара : {price * 0.95}");
        }
    }
}
