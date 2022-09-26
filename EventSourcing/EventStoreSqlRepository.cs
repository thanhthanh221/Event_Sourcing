using EventSourcing.Events.Core;
using EventSourcing.Data;

namespace EventSourcing
{
    public class EventStoreSqlRepository : IEventStoreRepository
    {
        private readonly EventStoreSqlContext context;

        public EventStoreSqlRepository(EventStoreSqlContext context)
        {
            this.context = context;
        }

        public IList<StoredEvent> All(Guid aggregateId)
        {
            IQueryable<StoredEvent> eventFindByIds = from e in context.storedEvents 
                                                    where e.AggregateId == aggregateId
                                                    select e;
            return eventFindByIds.ToList();
        }

        // khai triển từ IDisposable
        public void Dispose()
        {
            // giải phóng tài nguyên
            context.Dispose();
        }

        public void Store(StoredEvent theEvent)
        {
            context.storedEvents.Add(theEvent);
            context.SaveChanges();
        }
    }
}