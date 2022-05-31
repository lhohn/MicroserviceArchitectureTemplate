using Service.Domain;
using Service.Model;

namespace Service.Application;

public interface IUserFactory
{
    User Create(UserModel model, Auth auth);
}
