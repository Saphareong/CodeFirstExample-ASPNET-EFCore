using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeSecond.Migrations
{
    public partial class deleting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Grades");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "Grades",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
