using JWTPractice.Models;
using JWTPractice.Request_Models;

namespace JWTPractice.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginRequest);
    }
}
