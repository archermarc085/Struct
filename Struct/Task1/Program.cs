using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Macbook Air", "Apple", 1000.50);
            notebook.Display();
            Console.ReadLine();
        }
    }
}
