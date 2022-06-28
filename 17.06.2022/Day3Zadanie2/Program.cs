using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Zadanie2
{
    class MyClass
    {
        public string change;              
    }
    struct MyStruct
    {
        public string change;
    }
    class Program
    {       
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Изменено";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Изменено";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "Не изменено";
            myStruct.change = "Не изменено";
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
            Console.ReadKey();
        }
    }
}
