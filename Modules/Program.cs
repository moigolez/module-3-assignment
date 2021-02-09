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

            DateTime myFirstDateVariable = new DateTime(1954, 01, 01);
            DateTime mySecondDateVariable = new DateTime(1998, 01, 01);

            int result = DateTime.Compare(myFirstDateVariable, mySecondDateVariable);



            if(result==1)
            {
                Console.WriteLine("The second date is greater");

            }
            else
            {

                Console.WriteLine("The first date is greater");
            }
        }
    }
}


