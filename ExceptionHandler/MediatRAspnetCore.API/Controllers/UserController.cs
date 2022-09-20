using MediatR.AspnetCore.Application;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.AspnetCore.API;

[Route("/")]
[ApiController]
public class UserController : ControllerBase {
    private readonly IMediator _mediator;

    public UserController(IMediator mediator) {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserCommand command) 
    {
        var response = await _mediator.Send(command);

        if (response.Success)
            return Ok();

        return response.IsInternalError ? 
            StatusCode(500, response) : 
            BadRequest(response);
    }
}