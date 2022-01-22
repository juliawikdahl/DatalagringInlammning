using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entityframework_Inlamning.Migrations
{
    public partial class ChangedToDateTimeDataTypeAndAddedStateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Todaysdate",
                table: "Errands");

            migrationBuilder.RenameColumn(
                name: "Updatedate",
                table: "Errands",
                newName: "State");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "Errands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedTime",
                table: "Errands",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "Errands");

            migrationBuilder.DropColumn(
                name: "UpdatedTime",
                table: "Errands");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Errands",
                newName: "Updatedate");

            migrationBuilder.AddColumn<int>(
                name: "Todaysdate",
                table: "Errands",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
