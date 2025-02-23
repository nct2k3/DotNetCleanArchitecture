
using Microsoft.AspNetCore.Mvc;
using Application.Service.Authentication;
namespace WebApplication3.Controller;
using Contracts;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    // main controller
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterRequest registerRequest)
    {
        var authResult = _authenticationService.Register(
            registerRequest.FirstName,
            registerRequest.LastName,
            registerRequest.Email,
            registerRequest.Password
        );
        var reponse = new AuthenticationResponse(
            authResult.Id,
            authResult.FistName,
            authResult.LastName,
            authResult.Email,
            authResult.Token
            
        );

        return Ok(reponse); 
    }


    [HttpPost("login")]
    public IActionResult Login( LoginRequest loginRequest)
    {
        var authResult = _authenticationService.Login(
            loginRequest.Email,
            loginRequest.Password
        );
        var reponse = new AuthenticationResponse(
            authResult.Id,
            authResult.FistName,
            authResult.LastName,
            authResult.Email,
            authResult.Token
            
        );

        return Ok(reponse); 
    }
}