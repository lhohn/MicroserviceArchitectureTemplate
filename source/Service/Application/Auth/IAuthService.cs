using Service.Domain;
using Service.Model;
using DotNetCore.Results;

namespace Service.Application;

public interface IAuthService
{
    Task<IResult<Auth>> AddAsync(AuthModel model);

    Task DeleteAsync(long id);

    Task<IResult<TokenModel>> SignInAsync(SignInModel model);
}
