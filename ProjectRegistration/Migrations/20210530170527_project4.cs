using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectRegistration.Migrations
{
    public partial class project4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apikey",
                table: "Projects",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apikey",
                table: "Projects");
        }
    }
}
