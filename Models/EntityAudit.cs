namespace EventSourcing.Models
{
    public abstract class EntityAudit : EntityBase
    {
        public DateTime CreateAt {get; set;}
        public Guid CreateBy {get; set;}
        public DateTime UpdateAt {get; set;}
        public Guid UpdateBy {get; set;}
        
    }
}