using System.Threading.Tasks;
using JobApp.API.Models;

namespace JobApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> RegisterAsync(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}