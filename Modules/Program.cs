 using System;
using Modules.MyClasses;
using Modules.MyClasses.DTOS;

namespace Modules
{
    class Program
    {


        static void Main()
        {
            MyClass<int> myClass = new MyClass<int>();

            myClass.MyProperty1 = 10;
            myClass.MyProperty2 = 20;




            Console.WriteLine(myClass.MyProperty1);
            Console.WriteLine(myClass.MyProperty2);


        }
    }
}

public class MyClass<M>
{
    internal int MyProperty1;

    public M MyPtoperty1 { get; set; }
    public M MyPtoperty2 { get; set; }
    public int MyProperty2 { get; internal set; }
}