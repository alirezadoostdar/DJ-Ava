using DjAva.Application.Users.Commands.CreateUser;
using DjAva.Application.Users.Queries.GetUser;
using Microsoft.AspNetCore.Mvc;

namespace DjAva.API.Controllers;

public class UserController : BaseController
{
    [HttpGet]
    public async Task<ActionResult<GetUserDto>> GetUser([FromQuery] GetUserQuery query)
        => await Mediator.Send(query);

    [HttpPost]
    public async Task<ActionResult<Guid>> Create(CreateUserCommand command)
        => await Mediator.Send(command);
}
