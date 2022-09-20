namespace MediatR.AspnetCore.Application;

public record CreateUserCommand(string Name, string Email) : IRequest<CoommandResult>;