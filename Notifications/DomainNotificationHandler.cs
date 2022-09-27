using MediatR;

namespace EventSourcing.Notifications
{
    public class DomainNotificationHandler : INotificationHandler<DomainNotification>
    {
        private List<DomainNotification> notifications {get; set;}

        public DomainNotificationHandler()
        {
            this.notifications = new List<DomainNotification>();
        }

        public Task Handle(DomainNotification notification, CancellationToken cancellationToken)
        {
            notifications.Add(notification);
            return Task.CompletedTask;
        }
        public virtual List<DomainNotification> GetNotifications() 
        {
            return notifications;
        }
        public virtual bool HasNofitication() 
        {
            return notifications.Any();
        }
        public void Dispose() 
        { 
            notifications = new List<DomainNotification>();
        }
    }
}