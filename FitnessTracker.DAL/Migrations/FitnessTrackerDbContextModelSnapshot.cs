﻿// <auto-generated />
using System;
using FitnessTracker.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessTracker.DAL.Migrations
{
    [DbContext(typeof(FitnessTrackerDbContext))]
    partial class FitnessTrackerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitnessTracker.DAL.Entities.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Achievement");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(970),
                            Description = "You did lots of strength reps",
                            Name = "Strength King"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(970),
                            Description = "You ran 5km in one day",
                            Name = "Runner"
                        });
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Exercise");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 1,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(930),
                            Description = "An activity that makes your heart race",
                            Name = "Running"
                        },
                        new
                        {
                            Id = 2,
                            Category = 2,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(940),
                            Description = "Anything working your stomach muscles",
                            Name = "Abs"
                        },
                        new
                        {
                            Id = 3,
                            Category = 1,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(940),
                            Description = "Jumping like jacks",
                            Name = "Jumping Jacks"
                        });
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<decimal>("BMI")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Experiencelevel")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            BMI = 2.46m,
                            CreatedAt = new DateTime(2023, 3, 24, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(630),
                            Email = "Johndoe@gmail.com",
                            Experiencelevel = 1,
                            Gender = "Male",
                            Height = 6.0m,
                            Name = "John Doe",
                            Password = "1234",
                            Weight = 67.9m
                        },
                        new
                        {
                            Id = 2,
                            Age = 20,
                            BMI = 1.46m,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(680),
                            Email = "AliceParker@gmail.com",
                            Experiencelevel = 3,
                            Gender = "Female",
                            Height = 5.0m,
                            Name = "Alice parker",
                            Password = "5678",
                            Weight = 54.9m
                        },
                        new
                        {
                            Id = 3,
                            Age = 20,
                            BMI = 4.46m,
                            CreatedAt = new DateTime(2023, 3, 29, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(680),
                            Email = "Lynndoe@gmail.com",
                            Experiencelevel = 1,
                            Gender = "Female",
                            Height = 5.0m,
                            Name = "Lynn Doe",
                            Password = "1579",
                            Weight = 64.9m
                        });
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.UserAchievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AchievementId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AchievementId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAchievements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AchievementId = 1,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 3, 24, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(990),
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AchievementId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(990),
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            AchievementId = 2,
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(990),
                            UserId = 2
                        });
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.UserGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GoalType")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TargetWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserGoal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 3, 24, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880),
                            EndDate = new DateTime(2023, 4, 23, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880),
                            GoalType = 1,
                            StartDate = new DateTime(2023, 3, 24, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880),
                            Status = 3,
                            TargetWeight = 40.0m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(890),
                            EndDate = new DateTime(2023, 5, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880),
                            GoalType = 2,
                            StartDate = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880),
                            Status = 3,
                            TargetWeight = 79.0m,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.WorkOut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("LiveWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("WorkOut");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(910),
                            Date = new DateTime(2023, 4, 2, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(910),
                            LiveWeight = 68.10m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(910),
                            Date = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(910),
                            LiveWeight = 69.09m,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.WorkOutExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("Intensitylevel")
                        .HasColumnType("int");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkOutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("WorkOutId");

                    b.ToTable("WorkOutExercise");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(960),
                            Duration = 1900,
                            ExerciseId = 3,
                            Intensitylevel = 2,
                            Reps = 5,
                            Sets = 5,
                            WorkOutId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(960),
                            Duration = 1800,
                            ExerciseId = 2,
                            Intensitylevel = 1,
                            Reps = 5,
                            Sets = 5,
                            WorkOutId = 1
                        });
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.UserAchievement", b =>
                {
                    b.HasOne("FitnessTracker.DAL.Entities.Achievement", "Achievement")
                        .WithMany()
                        .HasForeignKey("AchievementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessTracker.DAL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Achievement");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.UserGoal", b =>
                {
                    b.HasOne("FitnessTracker.DAL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.WorkOut", b =>
                {
                    b.HasOne("FitnessTracker.DAL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessTracker.DAL.Entities.WorkOutExercise", b =>
                {
                    b.HasOne("FitnessTracker.DAL.Entities.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessTracker.DAL.Entities.WorkOut", "WorkOut")
                        .WithMany()
                        .HasForeignKey("WorkOutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("WorkOut");
                });
#pragma warning restore 612, 618
        }
    }
}
