using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Scheduler.DAL.Models;

namespace Scheduler.DAL.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.Login).IsRequired().HasMaxLength(64);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(64);
        }
    }
}