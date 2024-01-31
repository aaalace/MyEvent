using MyEvent.Application.Common.Interfaces.Auth;

namespace MyEvent.Application.Services.Auth;

public class AuthService : IAuthService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    
    public AuthResult Register(string firstName, string lastName, string email, string password)
    {
        var userId = Guid.NewGuid();
        
        // Create JWT
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
        
        return new AuthResult(
            userId, 
            firstName,
            lastName,
            email,
            password,
            token);
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