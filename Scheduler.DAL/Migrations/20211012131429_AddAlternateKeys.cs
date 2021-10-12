using Microsoft.EntityFrameworkCore.Migrations;

namespace Scheduler.DAL.Migrations
{
    public partial class AddAlternateKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tag",
                value: "Work");

            migrationBuilder.UpdateData(
                table: "EventTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tag",
                value: "Family");

            migrationBuilder.UpdateData(
                table: "EventTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tag",
                value: "Study");

            migrationBuilder.UpdateData(
                table: "EventTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tag",
                value: "Vacation");

            migrationBuilder.UpdateData(
                table: "PriorityTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tag",
                value: "Important");

            migrationBuilder.UpdateData(
                table: "PriorityTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tag",
                value: "Not important");

            migrationBuilder.UpdateData(
                table: "PriorityTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tag",
                value: "Medium priority");

            migrationBuilder.UpdateData(
                table: "PriorityTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tag",
                value: "In process");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Once");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Daily");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "Weekly");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: "Monthly");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: "Yearly");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "EventTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tag",
                value: "Робота");

            migrationBuilder.UpdateData(
                table: "EventTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tag",
                value: "Сім’я");

            migrationBuilder.UpdateData(
                table: "EventTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tag",
                value: "Навчання");

            migrationBuilder.UpdateData(
                table: "EventTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tag",
                value: "Відпочинок");

            migrationBuilder.UpdateData(
                table: "PriorityTag",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tag",
                value: "Важливо");

            migrationBuilder.UpdateData(
                table: "PriorityTag",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tag",
                value: "Некритично");

            migrationBuilder.UpdateData(
                table: "PriorityTag",
                keyColumn: "Id",
                keyValue: 3,
                column: "Tag",
                value: "Середній пріоритет");

            migrationBuilder.UpdateData(
                table: "PriorityTag",
                keyColumn: "Id",
                keyValue: 4,
                column: "Tag",
                value: "В процесі");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: "Один раз");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: "Щодня");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: "Щотижня");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: "Щомісяця");

            migrationBuilder.UpdateData(
                table: "RepeatType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: "Щороку");
        }
    }
}
