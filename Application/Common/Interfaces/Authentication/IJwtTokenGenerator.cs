namespace Application.Common.Interfaces.Authentication;


// interface for jwttoken
public interface IJwtTokenGenerator
{
    string GenerateJwtToken(Guid userId, string FistName, string LastName);
    
}