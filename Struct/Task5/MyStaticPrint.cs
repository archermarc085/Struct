using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
  enum Color { Blue, Red, White, Yellow }
  static  class MyStaticPrint
    {
        public static void Print(string stroka, int color)
        {
            ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow };
            Console.ForegroundColor = colors[color];
            Console.WriteLine(stroka);
            Console.ResetColor();
            // Console.Clear();
        }
    }
}
