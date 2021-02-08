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
            try
            {
                List<User> myList = new List<User>();

                User newUser1 = new User();
                newUser1.Email = "email1@yahoo.com";
                newUser1.Password = "Password1";
                newUser1.UserId = 1;
                newUser1.UserName = "Kimi1";
                myList.Add(newUser1);

                User newUser2 = new User();
                newUser2.Email = "email2@yahoo.com";
                newUser2.Password = "Password2";
                newUser2.UserId = 2;
                newUser2.UserName = "Kimi2";
                myList.Add(newUser2);


                User newUser3 = new User();
                newUser3.Email = "email1@yahoo.com";
                newUser3.Password = "Password3";
                newUser3.UserId = 3;
                newUser3.UserName = "Kimi3";
                myList.Add(newUser3);

                User newUser4 = new User();
                newUser4.Email = "email1@yahoo.com";
                newUser4.Password = "Password4";
                newUser4.UserId = 4;
                newUser4.UserName = "Kimi4";
                myList.Add(newUser4);

                User newUser5 = new User();
                newUser5.Email = "email5@yahoo.com";
                newUser5.Password = "Password5";
                newUser5.UserId = 5;
                newUser5.UserName = "Kimi5";
                myList.Add(newUser5);


                User newUser6 = new User();
                newUser6.Email = "email6@yahoo.com";
                newUser6.Password = "Password6";
                newUser6.UserId = 6;
                newUser6.UserName = "Kimi6";
                myList.Add(newUser6);

                User newUser7 = new User();
                newUser7.Email = "email7@yahoo.com";
                newUser7.Password = "Password7";
                newUser7.UserId = 7;
                newUser7.UserName = "Kimi7";
                myList.Add(newUser7);


                User newUser8 = new User();
                newUser8.Email = "email8@yahoo.com";
                newUser8.Password = "Password8";
                newUser8.UserId = 8;
                newUser8.UserName = "Kimi8";
                myList.Add(newUser8);

                User newUser9 = new User();
                newUser9.Email = "email9@yahoo.com";
                newUser9.Password = "Password9";
                newUser9.UserId = 9;
                newUser9.UserName = "Kimi1";
                myList.Add(newUser9);

                User newUser10 = new User();
                newUser10.Email = "email10@yahoo.com";
                newUser10.Password = "Password10";
                newUser10.UserId = 10;
                newUser10.UserName = "Kimi10";
                myList.Add(newUser10);



                myList = myList.Where(User => User.UserName == "Kimi1").ToList();

                if (myList.Count > 0)
                {

                    Console.WriteLine("Users found and they have the following properties");
                    string format = "My user has these properties: " +
                                    "Email: {0}, UserId: {1}, Password:{2}," +
                                    ",UserName: {3}";


                    foreach (var user in myList)
                    {

                        Console.WriteLine(format, user.Email, user.UserId,
                                           user.Password, user.UserName);
                    }
                }
                else
                {

                    throw new UserNotFound("No users found for the specified query");
                }
                }
           
                catch(UserNotFound exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Program has ended");
            }
        }
    }
}

public class UserNotFound : Exception
{
    public UserNotFound(string errorMessage) : base(errorMessage)
    {

    }
}
    
