using Microsoft.EntityFrameworkCore.Migrations;

namespace Scheduler.DAL.Migrations
{
    public partial class AddedNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTag_EventTagId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_PriorityTag_PriorityTagId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Reminders_ReminderId",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "ReminderId",
                table: "Events",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PriorityTagId",
                table: "Events",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EventTagId",
                table: "Events",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_Email",
                table: "Users",
                column: "Email");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Users_Login",
                table: "Users",
                column: "Login");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTag_EventTagId",
                table: "Events",
                column: "EventTagId",
                principalTable: "EventTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_PriorityTag_PriorityTagId",
                table: "Events",
                column: "PriorityTagId",
                principalTable: "PriorityTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Reminders_ReminderId",
                table: "Events",
                column: "ReminderId",
                principalTable: "Reminders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTag_EventTagId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_PriorityTag_PriorityTagId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Reminders_ReminderId",
                table: "Events");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_Email",
                table: "Users");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Users_Login",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "ReminderId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PriorityTagId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EventTagId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTag_EventTagId",
                table: "Events",
                column: "EventTagId",
                principalTable: "EventTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_PriorityTag_PriorityTagId",
                table: "Events",
                column: "PriorityTagId",
                principalTable: "PriorityTag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Reminders_ReminderId",
                table: "Events",
                column: "ReminderId",
                principalTable: "Reminders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
