using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleEric.Migrations
{
    /// <inheritdoc />
    public partial class AddYearsToClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Years",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Years",
                table: "Clients");
        }
    }
}
