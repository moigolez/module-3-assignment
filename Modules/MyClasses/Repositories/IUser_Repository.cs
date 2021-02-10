using System;
using Modules.Models;
using static Modules.MyClasses.Repositories.IMainRepository;

namespace Modules.MyClasses.Repositories
{
    public interface IUser_Repository : IMainRepository<User>
    {
        public void GetAllUsersByName(string name);
    }
}
