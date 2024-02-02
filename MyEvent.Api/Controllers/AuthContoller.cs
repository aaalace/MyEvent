using Microsoft.AspNetCore.Mvc;
using MyEvent.Application.Services.Auth;
using MyEvent.Contracts.Auth;

namespace MyEvent.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _service;

    public AuthController(IAuthService service)
    {
        _service = service;
    }
    
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _service.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);  
        
        var response = new AuthResponse(
            authResult.Id,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            authResult.Token
        );
        
        return Ok(response);
    }
    
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {   
        var authResult = _service.Login(
            request.Email,
            request.Password);

        var response = new AuthResponse(
            authResult.Id,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            authResult.Token
            );
        
        return Ok(response);
    }
}