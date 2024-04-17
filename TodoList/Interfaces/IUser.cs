using TodoList.Models;

namespace TodoList.Interfaces
{
    public interface IUser
    {
        Task<User> GetUserAsync(Guid id);
        Task<User> GetUserByEmailAsync(string email);
        Task<bool> IsUserExistsAsync(string email);
        Task<string> GetUserSaltAsync(string email);
        Task<bool> VerifyUserAsync(User user);


        Task AddUserAsync(User user);
    }
}
