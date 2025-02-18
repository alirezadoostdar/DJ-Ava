namespace DjAva.Application.Authentication.Queries.Login;

public record LoginQuery(string UserName, string Password) : IRequest<UserDto>;

