using MyEvent.Application.Common.Interfaces.Auth;
using MyEvent.Application.Common.Interfaces.Persistence;
using MyEvent.Domain.Entities;

namespace MyEvent.Application.Services.Auth;

public class AuthService : IAuthService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    
    public AuthResult Register(string firstName, string lastName, string email, string password)
    {
        // Check if user is already exists
        if (_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User with given email is already exists");
        }

        // Create User
        var user = new User
        {
            FirstName = firstName, 
            LastName = lastName, 
            Email = email, 
            Password = password
        };
        
        _userRepository.AddUser(user);
        
        // Create JWT
        var token = _jwtTokenGenerator.GenerateToken(user);
        
        return new AuthResult(
            user.Id, 
            firstName,
            lastName,
            email,
            token);
    }

    public AuthResult Login(string email, string password)
    {
        // Check if user is already exists
        if (_userRepository.GetUserByEmail(email) is not {} user)
        {
            throw new Exception("User with given email is not exists");
        }
        
        // Check if password is correct
        if (user.Password != password)
        {
            throw new Exception("Password is incorrect");
        }
        
        // Create JWT
        var token = _jwtTokenGenerator.GenerateToken(user);
        
        return new AuthResult(
            user.Id, 
            user.FirstName,
            user.LastName,
            user.Email,
            token);
    }
}