using Service.Domain;
using Service.Model;

namespace Service.Application;

public sealed class AuthFactory : IAuthFactory
{
    public Auth Create(AuthModel model)
    {
        return new Auth(model.Login, model.Password, (Roles)model.Roles);
    }
}
