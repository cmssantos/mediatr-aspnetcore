using MediatR.AspnetCore.Application;
using MediatR.Pipeline;

namespace MediatRAspnetCore.Application;

public class PingCommandExceptionHandler :
    RequestExceptionHandler<PingCommand, CoommandResult, Exception>
{
    protected override void Handle(
        PingCommand request,
        Exception exception,
        RequestExceptionHandlerState<CoommandResult> state)
    {
        state.SetHandled(new CoommandResult()
        {
            Message = "Pong Error",
            Success = false,
            Data = { }
        }); //handled
        //request.Message = exception.Message + " Not Handled";
    }
}