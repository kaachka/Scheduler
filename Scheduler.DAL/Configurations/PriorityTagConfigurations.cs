using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Scheduler.DAL.Models;

namespace Scheduler.DAL.Configurations
{
    public class PriorityTagConfigurations : IEntityTypeConfiguration<PriorityTag>
    {
        public void Configure(EntityTypeBuilder<PriorityTag> builder)
        {
            builder.Property(p => p.Tag).IsRequired().HasMaxLength(64);
        }
    }
}