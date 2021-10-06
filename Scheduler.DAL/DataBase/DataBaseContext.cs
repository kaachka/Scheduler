using Microsoft.EntityFrameworkCore;
using Scheduler.DAL.Configurations;
using Scheduler.DAL.Models;

namespace Scheduler.DAL.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        
        public DataBaseContext()
        {
            
        }
        
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EventTagConfigurations());
            modelBuilder.ApplyConfiguration(new PriorityTagConfigurations());
            modelBuilder.ApplyConfiguration(new ReminderConfigurations());
            modelBuilder.ApplyConfiguration(new RepeatTypeConfigurations());
            modelBuilder.ApplyConfiguration(new UserConfigurations());
            modelBuilder.ApplyConfiguration(new EventConfigurations());
            modelBuilder.ApplyConfiguration(new ScheduleConfigurations());

            modelBuilder.Entity<EventTag>().HasData(
                new EventTag() {Id = 1, Tag = "Робота"},
                new EventTag() {Id = 2, Tag = "Сім’я"},
                new EventTag() {Id = 3, Tag = "Навчання"},
                new EventTag() {Id = 4, Tag = "Відпочинок"}
            );
            
            modelBuilder.Entity<PriorityTag>().HasData(
                new PriorityTag() {Id = 1, Tag = "Важливо"},
                new PriorityTag() {Id = 2, Tag = "Некритично"},
                new PriorityTag() {Id = 3, Tag = "Середній пріоритет"},
                new PriorityTag() {Id = 4, Tag = "В процесі"}
            );
            
            modelBuilder.Entity<RepeatType>().HasData(
                new RepeatType() {Id = 1, Type = "Один раз"},
                new RepeatType() {Id = 2, Type = "Щодня"},
                new RepeatType() {Id = 3, Type = "Щотижня"},
                new RepeatType() {Id = 4, Type = "Щомісяця"},
                new RepeatType() {Id = 5, Type = "Щороку"}
            );
        }
    }
}