using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Scheduler.DAL.Models;

namespace Scheduler.DAL.Configurations
{
    public class EventConfigurations : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder
                .HasOne(e => e.Owner)
                .WithMany(u => u.Events)
                .HasForeignKey(e => e.OwnerId);
            
            builder
                .HasOne(e => e.Reminder)
                .WithMany(r => r.Events)
                .HasForeignKey(e => e.ReminderId);
            
            builder
                .HasOne(e => e.EventTag)
                .WithMany(et => et.Events)
                .HasForeignKey(e => e.EventTagId);

            builder
                .HasOne(e => e.PriorityTag)
                .WithMany(pt => pt.Events)
                .HasForeignKey(e => e.PriorityTagId);

            builder
                .HasOne(e => e.RepeatType)
                .WithMany(rt => rt.Events)
                .HasForeignKey(e => e.RepeatTypeId);

            builder.Property(p => p.Title).IsRequired().HasMaxLength(128);
            builder.Property(p => p.Description).HasMaxLength(256);
            builder.Property(p => p.Location).HasMaxLength(128);
            builder.Property(p => p.CreatedDate).IsRequired();
        }
    }
}