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
        private static object file;
        private static bool result;

        private static string Main()
        {
            string response = "";
            List<User> userList = new List<User>();
            List<Comment> commentList = new List<Comment>();


            while (response != "8")
            {
                Console.WriteLine("1. Create a User");
                Console.WriteLine("2. Create a Comment");
                Console.WriteLine("3. Print the List of Users");
                Console.WriteLine("4. Print the List of Comments");
                Console.WriteLine("5. Look for a User");
                Console.WriteLine("6. Look for a Comment");
                Console.WriteLine("7. Create a Data File");
                Console.WriteLine("8. Exit");

                Console.WriteLine("");
                Console.WriteLine("Please select an option");
                response = Console.ReadLine();

                switch(response)
                {
                    case "1":
                        User user = new User();
                        user.Email = "kimi1@yahoo.com";
                        user.Password = "Password";
                        user.UserId = 1;
                        user.UserName = "Kimi";

                        userList.Add(user);

                        Console.WriteLine("You have created a user");
                        break;

                    case "2":
                        Comment myComment = new Comment();
                        myComment.CommentId = 1;
                        myComment.TheComment = "Hello";
                       

                        commentList.Add(myComment);

                        Console.WriteLine("You have created a comment");

                        break;

                    case "3":
                        Console.WriteLine("These is the list of users created:");

                        foreach(var insideUser in userList)
                        {

                            Console.WriteLine("The user email is: " + insideUser.Email);
                            Console.WriteLine("The user password is: " + insideUser.Password);
                            Console.WriteLine("The user user id is: " + insideUser.UserId);
                            Console.WriteLine("The user user name is: " + insideUser.UserName);

                        }
                        break;

                    case "4":
                        Console.WriteLine("These is the list of comments created:");

                        foreach (var insideComment in commentList)
                        {

                            Console.WriteLine("The  comment id is: " + insideComment.CommentId);
                            Console.WriteLine("The actual comment is: " + insideComment.TheComment);
                          
                        }
                        break;


                    case "5":
                        try
                        {
                            List<User> myList = new List<User>();

                            User newUser1 = new User();
                            newUser1.Email = "email1@yahoo.com";
                            newUser1.Password = "Password1";
                            newUser1.UserId = 1;
                            newUser1.UserName = "Kimi1";
                            myList.Add(newUser1);

                            myList = myList.Where(User => User.UserName == "Kimi1").ToList();

                            if (myList.Count > 0)
                            {

                                Console.WriteLine("Users found and they have the following properties");
                                string format = "My user has these properties: " +
                                                "Email: {0}, UserId: {1}, Password:{2}," +
                                                ",UserName: {3}";


                                foreach (var insideUser in userList)
                                {

                                    Console.WriteLine(format, insideUser.Email, insideUser.UserId,
                                                       insideUser.Password, insideUser.UserName);
                                }
                            }
                            else
                            {

                                throw new UserNotFound("No users found for the specified query");
                            }
                        }

                        catch (UserNotFound exception)
                        {

                            Console.WriteLine(exception.Message);
                        }

                         Console.WriteLine("Please enter the username you are looking for:");

                        break;

                    case "6":
                        try
                        {
                            List<Comment> myList = new List<Comment>();

                            Comment newComment = new Comment();
                            newComment.CommentId = 1;
                            newComment.TheComment = "Hello";

                            myList = myList.Where(Comment => Comment.TheComment == "Hello").ToList();

                            if (myList.Count > 0)
                            {

                                Console.WriteLine("Comments found and they have the following properties");
                                string format = "My comment has these properties: " +
                                                "CommentId: {0}, TheComment: {1}";


                                foreach (var insideComment in commentList)
                                {

                                    Console.WriteLine(format, insideComment.CommentId, insideComment.TheComment);
                                }
                            }
                            else
                            {

                                throw new UserNotFound("No comment found for the specified query");
                            }
                        }

                        catch (UserNotFound exception)
                        {

                            Console.WriteLine(exception.Message);
                        }

                        Console.WriteLine("Please enter the comment you are looking for:");

                        break;

                    case "7":
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

        }
    }
}



