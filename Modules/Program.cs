 using System;
using System.Collections.Generic;
using System.Linq;
using Modules.MyClasses;
using Modules.MyClasses.DTOS;

namespace Modules
{
    class Program
    {


        static void Main()
        {
            int[] myArray = new int[10];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;
            myArray[5] = 6;
            myArray[6] = 7;
            myArray[7] = 8;
            myArray[8] = 9;
            myArray[9] = 10;


            Console.WriteLine("The values on the array are the following:");
            foreach (var item in myArray)


            {
                Console.Write(item + ",");

            }


            List<string> myList = new List<string>();
            myList.Add("Value 1");
            myList.Add("Value 2");
            myList.Add("Value 3");
            myList.Add("Value 4");
            myList.Add("Value 5");
            myList.Add("Value 6");
            myList.Add("Value 7");
            myList.Add("Value 8");
            myList.Add("Value 9");
            myList.Add("Value 10");

            Console.WriteLine("");
            Console.WriteLine("The values on the list are the following:");
            foreach (var item in myList)

            {

                Console.Write(item + ",");
            }
        }
    }
}