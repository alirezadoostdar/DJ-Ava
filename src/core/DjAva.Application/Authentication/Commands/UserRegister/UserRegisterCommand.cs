using DjAva.Domain.Enums;

namespace DjAva.Application.Authentication.Commands.UserRegister;
public record UserRegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string UserName,
    string Password,
    Gender Gender) : IRequest<Guid>;

