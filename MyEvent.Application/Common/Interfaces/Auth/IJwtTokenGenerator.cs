using MyEvent.Domain.Entities;

namespace MyEvent.Application.Common.Interfaces.Auth;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}