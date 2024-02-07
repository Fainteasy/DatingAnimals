using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class hello : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Interest",
                table: "Users",
                newName: "Interests");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Users",
                newName: "Genre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Interests",
                table: "Users",
                newName: "Interest");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Users",
                newName: "Gender");
        }
    }
}
