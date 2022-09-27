using EventSourcing.Events.Core;

namespace EventSourcing.Notifications
{
    public class DomainNotification : Event
    {
        public DomainNotification( string key, string value, int version)
        {
            DomainNotificationId = Guid.NewGuid();
            Key = key;
            Value = value;
            Version = 1;
        }

        public Guid DomainNotificationId {get; private set;}
        public string Key {get; private set;}
        public string Value {get; private set;}
        public int Version {get; private set;}
        
    }
}