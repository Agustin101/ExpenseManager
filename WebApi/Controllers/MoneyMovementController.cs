using Application.UseCases.MoneyMovementFeatures.CreateMoneyMovement;
using Application.Wrappers.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoneyMovementController(IMediator mediator) : ControllerBase
{

    [HttpPost]
    public async Task<ActionResult<Response<CreateMoneyMovementResponse>>> Create(CreateMoneyMovementRequest request,
                                 CancellationToken cancellationToken)
    {
        var response = await mediator.Send(request, cancellationToken);
        return Ok(response);
    }

}
