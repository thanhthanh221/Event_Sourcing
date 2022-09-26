using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EventSourcing.Events.Core;

namespace EventSourcing.Mappings
{
    public class StoredEventMap : IEntityTypeConfiguration<StoredEvent>
    {
        public void Configure(EntityTypeBuilder<StoredEvent> builder)
        {
            builder.Property(c => c.timeStamp)
                    .HasColumnName("Ngày Tạo");

            builder.Property(c => c.MessageType)
                    .HasColumnName("Hành động")
                    .HasColumnType("nvarchar(100)");

        }
    }
}