using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Scheduler.DAL.Models;

namespace Scheduler.DAL.Configurations
{
    public class ScheduleConfigurations : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasKey(p => new {p.UserId, p.EventId});

            builder
                .HasOne(s => s.User)
                .WithMany(u => u.Schedules)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.Event)
                .WithMany(e => e.Schedules)
                .HasForeignKey(s => s.EventId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}