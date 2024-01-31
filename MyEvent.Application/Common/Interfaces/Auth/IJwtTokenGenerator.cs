namespace MyEvent.Application.Common.Interfaces.Auth;

public interface IJwtTokenGenerator
{
    string GenerateToken(Guid userId, string firstName, string lastName);
}