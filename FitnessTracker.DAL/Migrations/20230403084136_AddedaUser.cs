using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedaUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "UserAchievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 3, 24, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "UserAchievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "UserAchievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "UserGoal",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 24, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880), new DateTime(2023, 4, 23, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880), new DateTime(2023, 3, 24, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "UserGoal",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(890), new DateTime(2023, 5, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880), new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 24, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "BMI", "CreatedAt", "Email", "Experiencelevel", "Gender", "Height", "Name", "Password", "UpdatedAt", "Weight" },
                values: new object[] { 3, 20, 4.46m, new DateTime(2023, 3, 29, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(680), "Lynndoe@gmail.com", 1, "Female", 5.0m, "Lynn Doe", "1579", null, 64.9m });

            migrationBuilder.UpdateData(
                table: "WorkOut",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(910), new DateTime(2023, 4, 2, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "WorkOut",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(910), new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "WorkOutExercise",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "WorkOutExercise",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 3, 9, 41, 36, 218, DateTimeKind.Local).AddTicks(960));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Achievement",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Exercise",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "UserAchievements",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 3, 20, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "UserAchievements",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "UserAchievements",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "UserGoal",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 20, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 4, 19, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 3, 20, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "UserGoal",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 4, 29, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480), new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 20, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "WorkOut",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3500), new DateTime(2023, 3, 29, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "WorkOut",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Date" },
                values: new object[] { new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3510), new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "WorkOutExercise",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "WorkOutExercise",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 3, 30, 21, 17, 5, 493, DateTimeKind.Local).AddTicks(3550));
        }
    }
}
