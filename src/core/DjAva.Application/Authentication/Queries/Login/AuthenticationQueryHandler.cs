
namespace DjAva.Application.Authentication.Queries.Login;

public class AuthenticationQueryHandler(IApplicationUnitOfWork unitOfWork)
    : IRequestHandler<LoginQuery, UserDto>
{
    private readonly IApplicationUnitOfWork _unitOfWork = unitOfWork;
    public async Task<UserDto> Handle(LoginQuery request, CancellationToken cancellationToken)
    {
   var user = await _unitOfWork.Users.Where(x => x.UserName == request.UserName 
                                              && x.Password == request.Password)
                                        .Select(x => new UserDto(x.Email, x.FirstName, x.LastName))
                                        .FirstOrDefaultAsync(cancellationToken);

        return user ?? null;
    }
}
