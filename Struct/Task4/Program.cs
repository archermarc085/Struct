using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string parser = "";
            string birthdayParse = "";
            DateTime date;
            DateTime birthday;

            date = parser.CheckDateTime();
            birthday = birthdayParse.CheckDateTime();
            
            TimeSpan elapsed = birthday.Subtract(date);
            Console.WriteLine("До дня рождения осталось дней: {0}\n", elapsed.Days);

            Console.ReadLine();

        }
    }
}
