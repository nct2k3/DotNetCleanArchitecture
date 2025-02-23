using Application.Common.Interfaces.Authentication;

namespace Application.Service.Authentication;


public class AuthenticationService : IAuthenticationService
{
    
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
        
    public AuthenticationResult Login(string Email, string Password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "FirstName",
            "LastName",
            Email,
            "Token"
        );
    }
    

    public AuthenticationResult Register(string FirstName, string LastName, string Email, string Password)
    {
        Guid Id = Guid.NewGuid();
        
        // creat user 
        // creat token
        
         var token= _jwtTokenGenerator.GenerateJwtToken(Id,FirstName, LastName);
        return new AuthenticationResult(
            Id,
            FirstName,
            LastName,
            Email,
            token
        );
    }
}