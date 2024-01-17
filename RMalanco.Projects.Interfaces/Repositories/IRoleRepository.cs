using RMalanco.Projects.Interfaces.Base;
using RMalanco.Projects.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMalanco.Projects.Interfaces.Repositories
{
    public interface IRoleRepository : IRepository<Roles>
    {
        void Update(Roles roles);
    }
}
