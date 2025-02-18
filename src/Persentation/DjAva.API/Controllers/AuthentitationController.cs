using DjAva.Application.Authentication.Commands.UserRegister;
using DjAva.Application.Authentication.Queries.Login;
using Microsoft.AspNetCore.Mvc;

namespace DjAva.API.Controllers;

public class AuthentitationController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<Guid>> Register([FromBody] UserRegisterCommand userRegisterCommand,
        CancellationToken cancellationToken = default)
       => await Mediator.Send(userRegisterCommand, cancellationToken);

    [HttpPost]
    public async Task<ActionResult<UserDto>> Login([FromBody] LoginQuery loginQuery,
        CancellationToken cancellationToken = default)
       => await Mediator.Send(loginQuery, cancellationToken);
}
