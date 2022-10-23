using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР4_ИДЗ
{
    class Programm 
    {
        static void Main(string[] args)
        {
            var list = new List<БытТехника>();
            list.Add(new БытТехника("Сплитсистемочка", 15000));
            list.Add(new Телевизор("LG", 5000, true, 144));
            list.Add(new Утюг("Утюжок", 3000, false, 220));
            list.Add(new Микроволновка("Микроволновочка", 5600, 3600));
            list.Add(new Пылесос("Пылесосик", 7000, 4, "Ручной"));
            list.Add(new Парогенератор("Дымила300", 99000, true, 2500, 75));
            list.Add(new Отпариватель("Людмила299", 10000, true, 2100, 0.5f));
            foreach (var item in list)
            {
                Console.WriteLine(item.GetInfo());
            }
            Console.WriteLine();
            БытТехника tech1 = new БытТехника("Сплитсистемочка", 15000);
            tech1.GetPrice();
            Утюг tech2 = new Утюг("Утюжок", 3000, false, 220);
            tech2.GetPrice();
            Парогенератор tech3 = new Парогенератор("Дымила300", 99000, true, 2500, 75);
            tech3.GetPrice();
            Телевизор tech4 = new Телевизор("LG", 5000, true, 144);
            tech4.GetPrice();
        }
    }
}
