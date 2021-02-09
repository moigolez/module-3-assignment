using System;
using System.Collections.Generic;
using Modules.Models;

namespace Modules.MyClasses.Models
{
    public class ShoppingCart
    {
        private List<User> userList = new List<User>();
        private List<CakeReview> cakeReviewList = new List<CakeReview>();

        public ShoppingCart()
        {
        }

        public void PrintMenu()
        {
            Console.WriteLine("1. Create a User");
            Console.WriteLine("2. Create a Cake Review");
            Console.WriteLine("3. Print the list of Users");
            Console.WriteLine("4. Print the list of Cake Reviews");
            Console.WriteLine("5. Exit");
        }

        public string CaptureResponse()
        {
            string response = Console.ReadLine();

            return response;
        }
        public void CreateUser()
        {
            User myUser = new User();
            myUser.Email = "kimi@yahoo.com";
            myUser.Password = "Password";
            myUser.UserId = 1;
            myUser.UserName = "Kimi";

            userList.Add(myUser);

            Console.WriteLine("");
            Console.WriteLine("You have created a User for your Shopping Cart");
            Console.WriteLine("");
        }

        public void CreateCakeReview()
        {
            CakeReview review = new CakeReview();
            review.CakeId = 1;
            review.CakeReviewId = 1;
            review.Review = "Fantastic Cake";

            cakeReviewList.Add(review);

            Console.WriteLine("");
            Console.WriteLine("You have added a review for a Cake on your Shopping Cart");
            Console.WriteLine("");
        }

        public void ShowAllExistingUsers()
        {
            int userCount = 1;

            string format = "User {0}: Has the following data.- User Name[{1}], Password[{2}], " +
                            "UserId[{3}], Email[{4}]";

            Console.WriteLine("");
            foreach (var user in userList)
            {
                Console.WriteLine(String.Format(format, userCount, user.UserName, user.Password,
                                                user.UserId, user.Password));

                userCount++;
            }
            Console.WriteLine("");
        }

        public void ShowAllExistingCakeReviews()
        {
            int reviewCount = 1;

            string format = "Cake Review {0}: Has the following data.- Review belings to cake id[{1}], " +
                            "ReviewId[{2}], The Actual review[{3}]";

            Console.WriteLine("");
            foreach (var review in cakeReviewList)
            {
                Console.WriteLine(String.Format(format, reviewCount, review.CakeId, review.CakeReviewId,
                                                review.Review));

                reviewCount++;
            }
            Console.WriteLine("");
        }
    }
}




