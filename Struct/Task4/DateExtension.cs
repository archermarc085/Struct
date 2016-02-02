using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
   static class DateExtension
    {
      public static DateTime CheckDateTime(this string parser) 
       {
        DateTime date;
        CultureInfo provider = new CultureInfo("en-US");
           do 
            {
             Console.WriteLine("Add  date:");
             parser = Console.ReadLine();
            } while (!DateTime.TryParseExact(parser, "MM/dd/yyyy", provider, DateTimeStyles.None, out date));
       return date;
       }
    }
}
