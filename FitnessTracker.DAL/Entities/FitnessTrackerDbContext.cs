using System;
using System.Collections.Generic;
using FitnessTracker.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.DAL.Entities
{
    public class FitnessTrackerDbContext : DbContext
    {
        public FitnessTrackerDbContext(DbContextOptions<FitnessTrackerDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserGoal> UserGoal { get; set; }
        public DbSet<WorkOut> WorkOut { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<WorkOutExercise> WorkOutExercise { get; set; }
        public DbSet<Achievement> Achievement { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = 1,
                        Name = "John Doe",
                        Age = 20,
                        Email = "Johndoe@gmail.com",
                        Password = "1234",
                        Height = 6.0M,
                        Weight = 67.9M,
                        Gender = "Male",
                        BMI = 2.46M,
                        Experiencelevel = ExperienceLevel.Beginner,
                        CreatedAt = DateTime.Now.AddDays(-10)

                    },

                    new User
                    {
                        Id = 2,
                        Name = "Alice parker",
                        Age = 20,
                        Email = "AliceParker@gmail.com",
                        Password = "5678",
                        Height = 5.0M,
                        Weight = 54.9M,
                        Gender = "Female",
                        BMI = 1.46M,
                        Experiencelevel = ExperienceLevel.Pro,
                        CreatedAt = DateTime.Now

                    },
                    new User
                    {
                        Id = 3,
                        Name = "Lynn Doe",
                        Age = 20,
                        Email = "Lynndoe@gmail.com",
                        Password = "1579",
                        Height = 5.0M,
                        Weight = 64.9M,
                        Gender = "Female",
                        BMI = 4.46M,
                        Experiencelevel = ExperienceLevel.Beginner,
                        CreatedAt = DateTime.Now.AddDays(-5)

                    });


            modelBuilder.Entity<UserGoal>()
            .HasData(
            new UserGoal
            {
                Id = 1,
                UserId = 1,
                GoalType = GoalType.LoseWeight,
                StartDate = DateTime.Now.AddDays(-10),
                EndDate = DateTime.Now.AddDays(20),
                Status = Status.InProgress,
                TargetWeight = 40.0M,
                CreatedAt = DateTime.Now.AddDays(-10)

            },

            new UserGoal
            {
                Id = 2,
                UserId = 2,
                GoalType = GoalType.GainWeight,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(30),
               Status = Status.InProgress,
               TargetWeight = 79.0M,
                CreatedAt = DateTime.Now

            });

        modelBuilder.Entity<WorkOut>()
           .HasData(
           new WorkOut
           {
               Id = 1,
               UserId = 1,
               Date = DateTime.Now.AddDays(-1),
               LiveWeight = 68.10M,
               CreatedAt = DateTime.Now

           },
           
           new WorkOut
           {
               Id = 2,
               UserId = 1,
               Date = DateTime.Now,
               LiveWeight = 69.09M,
               CreatedAt = DateTime.Now

           });


        modelBuilder.Entity<Exercise>()
           .HasData(
           new Exercise
           {
               Id = 1,
               Name = "Running",
               Description = "An activity that makes your heart race",
               Category = Category.Cardio,
               CreatedAt = DateTime.Now,
               

           },

           new Exercise
           {
               Id = 2,
               Name = "Abs",
               Description = "Anything working your stomach muscles",
               Category = Category.Strength,
               CreatedAt = DateTime.Now

           },
           new Exercise
           {
               Id = 3,
               Name = "Jumping Jacks",
               Description = "Jumping like jacks",
               Category = Category.Cardio,
               CreatedAt = DateTime.Now
               

           });

            modelBuilder.Entity<WorkOutExercise>()
           .HasData(
           new WorkOutExercise
           {
               Id = 1,
               WorkOutId = 1,
                ExerciseId = 3,
               Intensitylevel = IntensityLevel.Moderate,
               Duration = 1900,
               Sets = 5,
               Reps = 5,
               CreatedAt = DateTime.Now

           },
           

          new WorkOutExercise
           {

              Id = 2,
              WorkOutId = 1,
              ExerciseId = 2,
              Intensitylevel = IntensityLevel.Low,
              Duration = 1800,
              Sets = 5,
              Reps = 5,
              CreatedAt = DateTime.Now

          });


        modelBuilder.Entity<Achievement>()
           .HasData(
           new Achievement
           {
               Id = 1,
               Name = "Strength King",
               Description = "You did lots of strength reps",
               CreatedAt = DateTime.Now

           },
 
         new Achievement
          {
             Id = 2,
             Name = "Runner",
             Description = "You ran 5km in one day",
             CreatedAt = DateTime.Now

         });

            modelBuilder.Entity<UserAchievement>()
          .HasData(
          new UserAchievement
          {
              Id =1,
              UserId = 1,
              AchievementId = 1,
              Date = DateTime.Now.AddDays(-10),

          },

        new UserAchievement
        {
            Id = 2,
           UserId = 1,
           AchievementId = 2,
           Date = DateTime.Now

        },
         new UserAchievement
         {
             Id = 3,
             UserId = 2,
             AchievementId = 2,
             Date = DateTime.Now

         });



            base.OnModelCreating(modelBuilder);
        }
    }
}

