using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Di_Station.REPO.Migrations
{
    public partial class DietCalorie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "YemekCesidiUrun",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "YemekCesidiUrun",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "YemekCesidiUrun",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "YemekCesidiUrun",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "YemekCesidiUrun",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "YemekCesidiUrun");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "YemekCesidiUrun");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "YemekCesidiUrun");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "YemekCesidiUrun");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "YemekCesidiUrun");
        }
    }
}
