using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharedCalendar.Migrations
{
    /// <inheritdoc />
    public partial class AddingStartAndEndTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "CalendarEvents",
                newName: "StartDateTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                table: "CalendarEvents",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDateTime",
                table: "CalendarEvents");

            migrationBuilder.RenameColumn(
                name: "StartDateTime",
                table: "CalendarEvents",
                newName: "Date");
        }
    }
}
