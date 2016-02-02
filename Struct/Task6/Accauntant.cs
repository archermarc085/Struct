using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    enum Post
    {
        Worker = 160, Manager = 200, Engineer = 280
    }
    class Accauntant
    {
        public bool check = false;
        public double Salary { get; set; }
        public double Bonus { get { return 0.2 * Salary; } }
        public double FullSalary
        {
            get
            {
                if (check)
                {
                    return Salary + Bonus;
                }
                return Salary;
            }
        }

        public bool AskForBonus(Post worker, int hours)
        {
            switch (worker)
            {
                case Post.Worker:
                    if (hours > (int)Post.Worker)
                    {
                        return true;
                    }
                    return false;
                case Post.Manager:
                    if (hours > (int)Post.Manager)
                    {
                        return true;
                    }
                    return false;
                case Post.Engineer:
                    if (hours > (int)Post.Engineer)
                    {
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }
        public void ShowSalary()
        {
            Console.WriteLine("Your Salary: {0}", FullSalary);
        }
    }
}
