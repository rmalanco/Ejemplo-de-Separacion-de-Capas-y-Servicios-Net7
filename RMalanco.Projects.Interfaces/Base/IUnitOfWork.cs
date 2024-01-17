using RMalanco.Projects.Interfaces.Repositories;

namespace RMalanco.Projects.Interfaces.Base;

public interface IUnitOfWork : IDisposable
{
    
    IUserRepository Users { get; }
    IRoleRepository Roles { get; }

    void Save();
}
