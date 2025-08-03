using MediatR;

namespace Restaurants.Application.Users.Commands.UnssignUserRole;

public class UnssignUserRoleCommand :IRequest
{
    public string UserEmail { get; set; } = default!;
    public string RoleName { get; set; } = default!;
}
