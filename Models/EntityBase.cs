namespace EventSourcing.Models
{
    public abstract class EntityBase 
    {
        public Guid Id {get; protected set;}
        public bool IsDeleted {get; set;}

        public override bool Equals(object obj)
        {
            EntityBase compareTo = obj as EntityBase;

            // so sánh xem đối tượng có cùng cá thể đối tượng this(entity hay khong)
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            // Nếu chuyển thành entity bị null
            if (compareTo is null)
            {
                return false;
            }

            return Id.Equals(compareTo.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}