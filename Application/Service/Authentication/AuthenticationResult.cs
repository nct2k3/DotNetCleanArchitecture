namespace Application.Service.Authentication;

//Dto for authenticaton result
public record AuthenticationResult(
    Guid Id,
    string FistName,
    string LastName,
    string Email,
    string Token
    
    
);