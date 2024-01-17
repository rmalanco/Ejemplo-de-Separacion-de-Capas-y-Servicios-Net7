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
    public class UserRepository : Repository<Users>, IUserRepository
    {
        private readonly ApplicationDbContext _Db;

        public UserRepository(ApplicationDbContext Db) : base(Db)
        {
            _Db = Db;
        }
        public void Update(Users users)
        {
            var objFromDb = _Db.Users.FirstOrDefault(s => s.IdUser == users.IdUser);
            if (objFromDb != null)
            {
                objFromDb.Username = users.Username;
                objFromDb.Email = users.Email;
                objFromDb.Password = users.Password;
            }
            else
            {
                _Db.Users.Add(users);
            }

            _Db.SaveChanges();
        }
    }
}
