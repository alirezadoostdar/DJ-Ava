
using DjAva.Domain.Entities;

namespace DjAva.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler(IApplicationUnitOfWork applicationUnitOfWork)
    : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IApplicationUnitOfWork _applicationUnitOfWork = applicationUnitOfWork;
    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
        };
        _applicationUnitOfWork.Users.Add(user);
        await _applicationUnitOfWork.SaveChangesAsync();
        return user.Id;
    }
}
