using Service.Domain;
using System.Linq.Expressions;

namespace Service.Database;

public static class AuthExpression
{
    public static Expression<Func<Auth, bool>> Login(string login)
    {
        return auth => auth.Login == login;
    }
}
