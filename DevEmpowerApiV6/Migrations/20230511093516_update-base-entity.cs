using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevEmpowerApiV6.Migrations
{
    /// <inheritdoc />
    public partial class updatebaseentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Videos",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Videos",
                newName: "ID");
        }
    }
}
