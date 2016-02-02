using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Notebook
    {
        double price;
        string model;
        string manufacturer;

        public Notebook(string model, string manufacturer, double price)
        {
            this.price = price;
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public void Display()
        {
            int length = manufacturer.Length + model.Length;
            string begin = "+-";
            string end = "+";

            while (true)
            {
                if (begin.Length - 1 == length)
                {
                    begin += "--";
                    begin += end;
                    break;
                }
                begin += "-";
            }
            Console.WriteLine(begin);
            Console.WriteLine(@"Model: {0} 
Manufacturer: {1}
Price: {2} ", model, manufacturer, price);
            Console.WriteLine(begin);
        }
    }
}
