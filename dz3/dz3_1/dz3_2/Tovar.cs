using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_2
{
    public class Tovar
    {
        string name; //название товара
        string opisanie; //описание
        double price;//цена

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Opisanie
        {
            get { return opisanie; }
            set { opisanie = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                    throw new System.Exception("Цена не может быть меньше нуля");
                    price = value;
            }
        }
        public Tovar()
        {
            Name = "unknown"; Price = 0;
            Opisanie = "unknown";
        }
        public Tovar(string name, string made, double
        price)
        {
            Name = name; Opisanie = made; Price = price;
        }
        public override string ToString()
        {
            return " Наименование: "+ Name + " Описание: " + Opisanie ;//+ "Цена: "+Price;
}
    }
}
