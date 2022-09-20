namespace MediatR.AspnetCore.Application;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CoommandResult>
{
    public async Task<CoommandResult> Handle(
        CreateUserCommand request, 
        CancellationToken cancellationToken)
    {
        return await Task.Run(() =>
       {
           try
           {
               var content = 0;
               var test = 0 / content;
               return Task.FromResult(
                new CoommandResult()
                {
                    Message = "User created with success",
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