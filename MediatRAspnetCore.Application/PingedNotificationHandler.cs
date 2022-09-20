using MediatR;
using System.Diagnostics;

namespace MediatRAspnetCore.Application;

internal class PingedNotificationHandler : INotificationHandler<PingedNotification>
{
    public Task Handle(PingedNotification notification, CancellationToken cancellationToken)
    {
        Debug.WriteLine(notification.Value);
        return Task.CompletedTask;
    }
}