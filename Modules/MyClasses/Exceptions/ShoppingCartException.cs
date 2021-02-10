using System;
namespace Modules.MyClasses.Exceptions
{
    public class ShoppingCartException : Exception
    {
        public ShoppingCartException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
