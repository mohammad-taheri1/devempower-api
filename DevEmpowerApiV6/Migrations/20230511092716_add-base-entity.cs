using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevEmpowerApiV6.Migrations
{
    /// <inheritdoc />
    public partial class addbaseentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Videos",
                newName: "ID");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Videos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Videos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Videos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Videos");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Videos",
                newName: "Id");
        }
    }
}
