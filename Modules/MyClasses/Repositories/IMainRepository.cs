using System;
namespace Modules.MyClasses.Repositories
{
    public interface IMainRepository
    {
        public interface IMainRepository<T>
        {


            public void Save(T entity);

            public void Update(T entity);

            public void Delete(T entity);

        }
    }
}
