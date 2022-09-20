using MediatR;

namespace MediatRAspnetCore.Application;

public record PingedNotification(string Value) : INotification { }