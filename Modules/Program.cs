 using System;
using System.Collections.Generic;
using System.Linq;
using Modules.MyClasses;


namespace Modules
{
    class Program
    {
        
        static void Main()
        {

            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);

            int result = myList.Select(number => number).First();


            Console.WriteLine(result);

           

        }
    }
}


    
