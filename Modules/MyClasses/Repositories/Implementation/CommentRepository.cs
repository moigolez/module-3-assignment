using System;
using System.Collections.Generic;
using Modules.Models;
using Modules.MyClasses.Exceptions;
using System.Linq;

namespace Modules.MyClasses.Repositories.Implementation
{
    public class CommentRepository : MainRepository<Comment>, IComment_Repository
    {
        public CommentRepository()
        {
        }

        public void GetAllHelloComment()
        {
            List<Comment> resultList =
                currentDatabase.Where(Comment => Comment.TheComment == "Hello").ToList();

            if (resultList.Count > 0)
            {
                foreach(var comment in resultList)
                {
                    Console.WriteLine(comment.CommentId);
                    Console.WriteLine(comment.TheComment);
                   

                }
            }
            else
            {
                throw new CommentNotFound("No comments found");
            }
        }
    }

    
    
    
}
