using System;
namespace Modules.MyClasses.Exceptions
{
    public class UserNotFound : ShoppingCartException
    {
        public UserNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
