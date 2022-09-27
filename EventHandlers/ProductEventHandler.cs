using EventSourcing.Events;
using MediatR;

namespace EventSourcing.EventHandlers
{
    public class ProductEventHandler :
                INotificationHandler<ProductCreateEvent>,
                INotificationHandler<ProductUpdateEvent>,
                INotificationHandler<ProductRemoveEvent>
    {
        // gửi Email thông báo
        public Task Handle(ProductCreateEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ProductUpdateEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(ProductRemoveEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}