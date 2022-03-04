using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeSecond.Migrations
{
    public partial class die : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "diemotherfuck",
                table: "Grades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "diemotherfuck",
                table: "Grades");
        }
    }
}
