using MediatR;

namespace EventSourcing.Events.Core
{
    public abstract class Message : IRequest<bool>
    {
        protected Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
        public Guid AggregateId {get; protected set;}

    }
}