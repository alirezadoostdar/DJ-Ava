using DjAva.Domain.Enums;

namespace DjAva.Application.Users.Queries.GetUser;

public record GetUserDto(Guid Id, Gender Gender, string Email);

