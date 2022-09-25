namespace EventSourcing.Events.Core
{
    public class StoredEvent : Event
    {
        public StoredEvent(Event theEvent, string Data, string User)
        {
            this.Id = Guid.NewGuid();
            this.AggregateId= theEvent.AggregateId;
            this.MessageType = theEvent.MessageType;
            this.Data = Data;
            this.User = User;
        }

        // EF khởi tạo
        protected StoredEvent()
        {

        }

        public Guid Id { get; private set; }
        public string Data { get; private set; }
        public string User { get; private set; }

    }
}