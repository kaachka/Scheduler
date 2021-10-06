using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Scheduler.DAL.Models;

namespace Scheduler.DAL.Configurations
{
    public class ReminderConfigurations : IEntityTypeConfiguration<Reminder>
    {
        public void Configure(EntityTypeBuilder<Reminder> builder)
        {
            builder.Property(p => p.StartRemind).IsRequired();
            builder.Property(p => p.EndRemind).IsRequired();
        }
    }
}