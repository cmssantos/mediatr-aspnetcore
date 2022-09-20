using MediatRAspnetCore.Application;
using System.Net.NetworkInformation;

namespace MediatR.AspnetCore.Application;

public class PingCommandHandler : IRequestHandler<PingCommand, string>
{
    private readonly IMediator _mediator;

    public PingCommandHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task<string> Handle(PingCommand request, CancellationToken cancellationToken)
    {
        _mediator.Publish(new PingedNotification("Pinged"), cancellationToken);
        return Task.FromResult("Pong");
    }
}