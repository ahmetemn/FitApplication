using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Di_Station.REPO.Migrations
{
    public partial class UserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "Kullanıcılar",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Roles",
                table: "Kullanıcılar");
        }
    }
}
