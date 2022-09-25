namespace EventSourcing.Events.Core.Interfaces
{
    // xử lý khi T thuộc về message
    public interface IHandler<in T> where T: Message
    {
        void Handle(T message);
        
    }
}