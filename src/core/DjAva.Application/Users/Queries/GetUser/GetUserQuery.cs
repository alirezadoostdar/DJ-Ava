﻿namespace DjAva.Application.Users.Queries.GetUser;

public record GetUserQuery(Guid Id) : IRequest<GetUserDto>;

