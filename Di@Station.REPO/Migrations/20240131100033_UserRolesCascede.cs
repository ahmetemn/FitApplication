using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Di_Station.REPO.Migrations
{
    public partial class UserRolesCascede : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanıcılar_UserDetail_UserDetailId",
                table: "Kullanıcılar");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanıcılar_UserDetail_UserDetailId",
                table: "Kullanıcılar",
                column: "UserDetailId",
                principalTable: "UserDetail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanıcılar_UserDetail_UserDetailId",
                table: "Kullanıcılar");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanıcılar_UserDetail_UserDetailId",
                table: "Kullanıcılar",
                column: "UserDetailId",
                principalTable: "UserDetail",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
