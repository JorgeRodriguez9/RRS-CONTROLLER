using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RRS_Controller.Migrations
{
    /// <inheritdoc />
    public partial class migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Document",
                table: "INSTITUTIONS");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "INSTITUTIONS",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "INSTITUTIONS");

            migrationBuilder.AddColumn<int>(
                name: "Document",
                table: "INSTITUTIONS",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
