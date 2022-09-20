using MediatRAspnetCore.Application;

namespace MediatR.AspnetCore.Application;

public class PingCommandHandler : IRequestHandler<PingCommand, CoommandResult>
{
    private readonly IMediator _mediator;

    public PingCommandHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<CoommandResult> Handle(PingCommand request, CancellationToken cancellationToken)
    {
        return await Task.Run(() =>
       {
           try
           {
               var result = _mediator.Publish(new PingedNotification("Pinged"), cancellationToken);


               return Task.FromResult(
                new CoommandResult()
                {
                    Message = "Pong",
                    Success = true,
                    Data = { }
                });
           }
           catch (Exception)
           {
               throw;
           }
       }, cancellationToken);
    }
}