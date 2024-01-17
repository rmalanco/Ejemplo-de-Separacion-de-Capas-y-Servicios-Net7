
using RMalanco.Projects.Data;
using RMalanco.Projects.Interfaces.Base;
using RMalanco.Projects.Interfaces.Repositories;
using RMalanco.Projects.Service.Repositories;

namespace RMalanco.Projects.Service.Base;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
    public IUserRepository Users { get; private set; }
    public IRoleRepository Roles { get; private set; }

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        Users = new UserRepository(_db);
        Roles = new RoleRepository(_db);
    }

    public void Save()
    {
        _db.SaveChanges();
    }

    public void Dispose()
    {
        _db.Dispose();
        GC.SuppressFinalize(this);
    }
}
