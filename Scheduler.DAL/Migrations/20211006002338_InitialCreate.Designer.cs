﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scheduler.DAL.DataBase;

namespace Scheduler.DAL.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20211006002338_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Scheduler.DAL.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("EventTagId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("PriorityTagId")
                        .HasColumnType("int");

                    b.Property<int>("ReminderId")
                        .HasColumnType("int");

                    b.Property<int>("RepeatTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("EventTagId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PriorityTagId");

                    b.HasIndex("ReminderId");

                    b.HasIndex("RepeatTypeId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.EventTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("EventTag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Tag = "Робота"
                        },
                        new
                        {
                            Id = 2,
                            Tag = "Сім’я"
                        },
                        new
                        {
                            Id = 3,
                            Tag = "Навчання"
                        },
                        new
                        {
                            Id = 4,
                            Tag = "Відпочинок"
                        });
                });

            modelBuilder.Entity("Scheduler.DAL.Models.PriorityTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("PriorityTag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Tag = "Важливо"
                        },
                        new
                        {
                            Id = 2,
                            Tag = "Некритично"
                        },
                        new
                        {
                            Id = 3,
                            Tag = "Середній пріоритет"
                        },
                        new
                        {
                            Id = 4,
                            Tag = "В процесі"
                        });
                });

            modelBuilder.Entity("Scheduler.DAL.Models.Reminder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndRemind")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartRemind")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Reminders");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.RepeatType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("RepeatType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Type = "Один раз"
                        },
                        new
                        {
                            Id = 2,
                            Type = "Щодня"
                        },
                        new
                        {
                            Id = 3,
                            Type = "Щотижня"
                        },
                        new
                        {
                            Id = 4,
                            Type = "Щомісяця"
                        },
                        new
                        {
                            Id = 5,
                            Type = "Щороку"
                        });
                });

            modelBuilder.Entity("Scheduler.DAL.Models.Schedule", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.Event", b =>
                {
                    b.HasOne("Scheduler.DAL.Models.EventTag", "EventTag")
                        .WithMany("Events")
                        .HasForeignKey("EventTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scheduler.DAL.Models.User", "Owner")
                        .WithMany("Events")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scheduler.DAL.Models.PriorityTag", "PriorityTag")
                        .WithMany("Events")
                        .HasForeignKey("PriorityTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scheduler.DAL.Models.Reminder", "Reminder")
                        .WithMany("Events")
                        .HasForeignKey("ReminderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scheduler.DAL.Models.RepeatType", "RepeatType")
                        .WithMany("Events")
                        .HasForeignKey("RepeatTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EventTag");

                    b.Navigation("Owner");

                    b.Navigation("PriorityTag");

                    b.Navigation("Reminder");

                    b.Navigation("RepeatType");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.Schedule", b =>
                {
                    b.HasOne("Scheduler.DAL.Models.Event", "Event")
                        .WithMany("Schedules")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Scheduler.DAL.Models.User", "User")
                        .WithMany("Schedules")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.Event", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.EventTag", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.PriorityTag", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.Reminder", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.RepeatType", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Scheduler.DAL.Models.User", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Schedules");
                });
#pragma warning restore 612, 618
        }
    }
}