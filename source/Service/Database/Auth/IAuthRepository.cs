using Service.Domain;
using DotNetCore.Repositories;

namespace Service.Database;

public interface IAuthRepository : IRepository<Auth>
{
    Task<bool> AnyByLoginAsync(string login);

    Task<Auth> GetByLoginAsync(string login);
}
