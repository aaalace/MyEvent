namespace MyEvent.Application.Services.Auth;

public class AuthService : IAuthService
{
    public AuthResult Register(string firstName, string lastName, string email, string password)
    {
        return new AuthResult(
            Guid.NewGuid(), 
            firstName,
            lastName,
            email,
            password,
            "new_token");
    }

    public AuthResult Login(string email, string password)
    {
        return new AuthResult(
            Guid.NewGuid(), 
            "firstName",
            "lastName",
            email,
            password,
            "new_token");
    }
}