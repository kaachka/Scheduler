using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Scheduler.DAL.Models;

namespace Scheduler.DAL.Configurations
{
    public class RepeatTypeConfigurations : IEntityTypeConfiguration<RepeatType>
    {
        public void Configure(EntityTypeBuilder<RepeatType> builder)
        {
            builder.Property(p => p.Type).IsRequired().HasMaxLength(64);
        }
    }
}