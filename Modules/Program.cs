using System;
using Modules.MyClasses;

namespace Modules
{
    class Program
    {
        static void Main()
        {
            int result = SumOfNumbers(10,20);

            Console.WriteLine(result);
        }

        public static int SumOfNumbers(int parameter1, int parameter2)
        {
            return parameter1 + parameter2;
        }
    }
}
