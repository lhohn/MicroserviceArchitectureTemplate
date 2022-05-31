using Service.Domain;
using Service.Model;

namespace Service.Application;

public interface IAuthFactory
{
    Auth Create(AuthModel model);
}
