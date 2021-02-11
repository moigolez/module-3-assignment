 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Modules.Models;
using Modules.MyClasses;
using Modules.MyClasses.Exceptions;
using Modules.MyClasses.Models;
using Modules.MyClasses.Repositories.Implementation;

namespace Modules
{
    class Program
    {
        

        static void Main()
        {

            string path = "file.txt";

            bool fileExist = File.Exists(path);

            if(fileExist)
            {
                Console.WriteLine("File already exists");
            }
            else
            {
                Console.WriteLine("You have created the file: " +
                                  path);
                File.Create(path);

            }
           

            
        }
        
    }
}



