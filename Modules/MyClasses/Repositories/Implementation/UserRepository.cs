using System;
using System.Collections.Generic;
using System.Linq;
using Modules.Models;
using Modules.MyClasses.Exceptions;

namespace Modules.MyClasses.Repositories.Implementation
{
    public class UserRepository: MainRepository<User>, IUser_Repository
    {
        public UserRepository() 
        {
        }

        public void GetAllUsersByName(string name)
        {
            List<User> resultList =
                currentDatabase.Where(User => User.UserName == name).ToList();

            if (resultList.Count > 0)
            {
                foreach (var User in resultList)
                {
                    Console.WriteLine(User.UserName);
                    Console.WriteLine(User.UserId);


                }
            }
            else
            {

                throw new UserNotFound("No users found");
            }
        }
    }
}
