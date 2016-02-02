using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "no changes";
            MyStruct myStruct = new MyStruct();
            myStruct.change = "no changes";
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.change);//changed
            Console.WriteLine(myStruct.change);// no changes
            Console.ReadLine();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }
    }
}
