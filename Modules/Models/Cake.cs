using System;
namespace Modules.Models
{
    public class Cake
    {
        public string type { get; set; }
        public string flavor { get; set; }

        public Cake()
        {
            Console.WriteLine("I am inside the default construction");
        }

        public Cake(string newType, string newFlavor)
        {

            this.type = newType;
            this.flavor = newFlavor;

            Console.WriteLine("I am inside the custom construction");
        }
    }
}
