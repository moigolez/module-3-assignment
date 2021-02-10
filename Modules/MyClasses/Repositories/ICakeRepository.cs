using System;
using Modules.Models;
using static Modules.MyClasses.Repositories.IMainRepository;

namespace Modules.MyClasses.Repositories
{
    public interface ICakeRepository : IMainRepository<Cake>
    {
        public void GetAllChocolateCakes();
    }
}
