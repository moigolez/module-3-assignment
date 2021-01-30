using System;
using Modules.MyClasses;
using Modules.MyClasses.DTOS;

namespace Modules
{
    class Program
    {
        static void Main()
        {
            MyClasses.DTOS.CommentDTO comment = new CommentDTO();
            comment.TheComment = "This is a Comment";

            Console.WriteLine("The value of my first property is a comment: " + comment.TheComment);
        }

        
    }
}
