using System;
namespace Modules.MyClasses.Exceptions
{
    public class CommentNotFound : Exception
    {
        public CommentNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
