using MediatR.AspnetCore.Application;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.AspnetCore.API;

[Route("/")]
[ApiController]
public class PingController : ControllerBase {
    private readonly IMediator _mediator;

    public PingController(IMediator mediator) {
        _mediator = mediator;
    }

    [HttpGet]
    public IActionResult Ping() 
    {
        var response = _mediator.Send(new PingCommand());
        return Ok(response.Result);
    }
}