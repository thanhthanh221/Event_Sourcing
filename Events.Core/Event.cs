using MediatR;

namespace EventSourcing.Events.Core
{
    public abstract class Event : Message, INotification
    {
        // thời gian khởi tạo
        public DateTime timeStamp { get; private set;}
        protected Event()
        {
            timeStamp = DateTime.Now;
        }
    }
}