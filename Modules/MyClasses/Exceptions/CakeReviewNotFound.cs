using System;
namespace Modules.MyClasses.Exceptions
{
    public class CakeReviewNotFound : ShoppingCartException
    {
        public CakeReviewNotFound(string errorMessage) : base(errorMessage)
        {
        }
    }
}
