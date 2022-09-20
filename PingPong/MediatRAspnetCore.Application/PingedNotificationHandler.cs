using MediatR;
using System.Diagnostics;

namespace MediatRAspnetCore.Application;

internal class PingedNotificationHandler : INotificationHandler<PingedNotification>
{
    public Task Handle(PingedNotification notification, CancellationToken cancellationToken)
    {
        Debug.WriteLine(notification.Value);
        throw new Exception("teste");
        //return Task.CompletedTask;
    }
}