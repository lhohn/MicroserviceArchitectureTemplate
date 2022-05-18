using Architecture.Domain;
using Architecture.Model;
using DotNetCore.Objects;
using DotNetCore.Repositories;

namespace Architecture.Database;

public interface IUserRepository : IRepository<User>
{
    Task<long> GetAuthIdByUserIdAsync(long id);

    Task<UserModel> GetModelAsync(long id);

    Task<Grid<UserModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<UserModel>> ListModelAsync();

    Task UpdateStatusAsync(User user);
}
