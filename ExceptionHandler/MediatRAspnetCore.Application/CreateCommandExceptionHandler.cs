using MediatR.AspnetCore.Application;
using MediatR.Pipeline;

namespace MediatRAspnetCore.Application;

public class CommandExceptionHandler :
    RequestExceptionHandler<CreateUserCommand, CoommandResult, Exception>
{
    protected override void Handle(
        CreateUserCommand request,
        Exception exception,
        RequestExceptionHandlerState<CoommandResult> state)
    {
        state.SetHandled(new CoommandResult()
        {
            Message = exception.Message + " Not Handled",
            Success = false,
            IsInternalError = true,
            Data = { }
        });
    }
}