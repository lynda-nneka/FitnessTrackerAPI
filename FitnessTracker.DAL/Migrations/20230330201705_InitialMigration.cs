using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitnessTracker.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BMI = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Experiencelevel = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAchievements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AchievementId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAchievements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAchievements_Achievement_AchievementId",
                        column: x => x.AchievementId,
                        principalTable: "Achievement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAchievements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGoal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GoalType = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TargetWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGoal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGoal_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkOut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LiveWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOut", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOut_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkOutExercise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkOutId = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false),
                    Intensitylevel = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Sets = table.Column<int>(type: "int", nullable: false),
                    Reps = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOutExercise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOutExercise_Exercise_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkOutExercise_WorkOut_WorkOutId",
                        column: x => x.WorkOutId,
                        principalTable: "WorkOut",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Achievement",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3560), "You did lots of strength reps", "Strength King", null },
                    { 2, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3560), "You ran 5km in one day", "Runner", null }
                });

            migrationBuilder.InsertData(
                table: "Exercise",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3520), "An activity that makes your heart race", "Running", null },
                    { 2, 2, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3530), "Anything working your stomach muscles", "Abs", null },
                    { 3, 1, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3530), "Jumping like jacks", "Jumping Jacks", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "BMI", "CreatedAt", "Email", "Experiencelevel", "Gender", "Height", "Name", "Password", "UpdatedAt", "Weight" },
                values: new object[,]
                {
                    { 1, 20, 2.46m, new DateTime(2023, 3, 20, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3280), "Johndoe@gmail.com", 1, "Male", 6.0m, "John Doe", "1234", null, 67.9m },
                    { 2, 20, 1.46m, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3320), "AliceParker@gmail.com", 3, "Female", 5.0m, "Alice parker", "5678", null, 54.9m }
                });

            migrationBuilder.InsertData(
                table: "UserAchievements",
                columns: new[] { "Id", "AchievementId", "CreatedAt", "Date", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 20, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3580), null, 1 },
                    { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3580), null, 1 },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3580), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserGoal",
                columns: new[] { "Id", "CreatedAt", "EndDate", "GoalType", "StartDate", "Status", "TargetWeight", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 20, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 4, 19, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480), 1, new DateTime(2023, 3, 20, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3470), 3, 40.0m, null, 1 },
                    { 2, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 4, 29, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480), 2, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480), 3, 79.0m, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "WorkOut",
                columns: new[] { "Id", "CreatedAt", "Date", "LiveWeight", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3500), new DateTime(2023, 3, 29, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3500), 68.10m, null, 1 },
                    { 2, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3510), 69.09m, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "WorkOutExercise",
                columns: new[] { "Id", "CreatedAt", "Duration", "ExerciseId", "Intensitylevel", "Reps", "Sets", "UpdatedAt", "WorkOutId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3550), 1900, 3, 2, 5, 5, null, 1 },
                    { 2, new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3550), 1800, 2, 1, 5, 5, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_AchievementId",
                table: "UserAchievements",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAchievements_UserId",
                table: "UserAchievements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGoal_UserId",
                table: "UserGoal",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOut_UserId",
                table: "WorkOut",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOutExercise_ExerciseId",
                table: "WorkOutExercise",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOutExercise_WorkOutId",
                table: "WorkOutExercise",
                column: "WorkOutId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAchievements");

            migrationBuilder.DropTable(
                name: "UserGoal");

            migrationBuilder.DropTable(
                name: "WorkOutExercise");

            migrationBuilder.DropTable(
                name: "Achievement");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "WorkOut");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
