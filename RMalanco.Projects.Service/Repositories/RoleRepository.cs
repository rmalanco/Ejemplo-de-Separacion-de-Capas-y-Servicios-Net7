using RMalanco.Projects.Data;
using RMalanco.Projects.Interfaces.Repositories;
using RMalanco.Projects.Models.Entities;
using RMalanco.Projects.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMalanco.Projects.Service.Repositories
{
    public class RoleRepository : Repository<Roles>, IRoleRepository
    {
        private readonly ApplicationDbContext _Db;

        public RoleRepository(ApplicationDbContext Db) : base(Db)
        {
            _Db = Db;
        }
        public void Update(Roles roles)
        {
            var objFromDb = _Db.Roles.FirstOrDefault(s => s.IdRole == roles.IdRole);
            if (objFromDb != null)
            {
                objFromDb.Name = roles.Name;
            }
            else
            {
                _Db.Roles.Add(roles);
            }
            _Db.SaveChanges();
        }
    }
}
