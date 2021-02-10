
using System;
using System.Collections.Generic;
using static Modules.MyClasses.Repositories.IMainRepository;

namespace Modules.MyClasses.Repositories.Implementation
{
    public class MainRepository<T> : IMainRepository<T>
    {

        public List<T> currentDatabase = new List<T>();

        public MainRepository()
        {
        }

        public void Delete(T Entity)
        {
            currentDatabase.Remove(Entity);
            Console.WriteLine("You deleted the entity");
        }

        public void Save(T Entity)
        {
            currentDatabase.Add(Entity);
            Console.WriteLine("You saved the entity");
        }

        public void Update(T Entity)
        {
            Console.WriteLine("You updated the entity");
        }
        
    }
}
