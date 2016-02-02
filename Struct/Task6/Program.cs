using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            int hours = 300;
            accauntant.Salary = 10000.0;
            Post post = Post.Engineer;
            accauntant.check = accauntant.AskForBonus(post, hours);
            accauntant.ShowSalary();    
            Console.ReadLine();
        }
    }
}
