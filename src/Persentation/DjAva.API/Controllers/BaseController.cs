using DjAva.API.Filter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DjAva.API.Controllers;

[Route("[controller]/[action]"), CatchExceptionFilter, ApiController]
public abstract class BaseController : Controller
{
    private ISender? _mediator;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
