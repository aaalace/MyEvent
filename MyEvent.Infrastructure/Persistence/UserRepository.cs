using MyEvent.Application.Common.Interfaces.Persistence;
using MyEvent.Domain.Entities;

namespace MyEvent.Infrastructure.Persistence;

public class UserRepository : IUserRepository
{
    private static readonly List<User> users = new();
    
    public User? GetUserByEmail(string email)
    {
        return users.SingleOrDefault(user => user.Email == email);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }
}