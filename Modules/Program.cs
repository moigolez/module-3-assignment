 using System;
using System.Collections.Generic;
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
            
 
           

            UserRepository userRepo = new UserRepository();
            

            User newUser = new User();
            newUser.Email = "kimi1@yahoo.com";
            newUser.Password = "Password";
            newUser.UserId = 1;
            newUser.UserName = "Kimi";
            userRepo.Save(newUser);

            userRepo.GetAllUsersByName("Kimi");
        }
        
    }
}



