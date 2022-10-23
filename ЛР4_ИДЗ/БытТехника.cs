using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ
{
    public class БытТехника : IGetPriceWithDiscount
    {
        protected string name;
        protected int price;

        public БытТехника(string pName,int pPrice)
        {
            name = pName;
            price = pPrice;
        }
        virtual public string GetInfo()
        {
            return $"Название: {name}";
        }

        public void GetPrice()
        {
            Console.WriteLine($"Цена товара: {price}");
        }
    }
}
