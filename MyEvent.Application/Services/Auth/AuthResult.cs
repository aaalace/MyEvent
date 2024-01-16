namespace MyEvent.Application.Services.Auth;

public record AuthResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string Token);