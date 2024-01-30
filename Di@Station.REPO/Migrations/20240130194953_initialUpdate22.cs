using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Di_Station.REPO.Migrations
{
    public partial class initialUpdate22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Kategori_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Kategori_Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogun",
                columns: table => new
                {
                    Ogun_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogun", x => x.Ogun_Id);
                });

            migrationBuilder.CreateTable(
                name: "Porsiyon",
                columns: table => new
                {
                    Porsiyon_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PorsiyonOlcegi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porsiyon", x => x.Porsiyon_Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Urun_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Kalori = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Urun_Id);
                });

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false, computedColumnSql: "DATEDIFF(YEAR, DogumTarihi, GETDATE())"),
                    Kilo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Boy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Meslek = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yemek Cesidi",
                columns: table => new
                {
                    YemekCesidi_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Kalori = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yemek Cesidi", x => x.YemekCesidi_ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KullaniciSifre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.User_Id);
                    table.ForeignKey(
                        name: "FK_Kullanıcılar_UserDetail_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YemekCesidiPorsiyonOgun",
                columns: table => new
                {
                    YemekCesidiPorsiyonOgun_Id = table.Column<int>(name: "YemekCesidiPorsiyonOgun_Id ", type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YemekCesidi_ID = table.Column<int>(type: "integer", nullable: false),
                    Porsiyon_Id = table.Column<int>(type: "int", nullable: false),
                    OgunId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekCesidiPorsiyonOgun", x => x.YemekCesidiPorsiyonOgun_Id);
                    table.ForeignKey(
                        name: "FK_YemekCesidiPorsiyonOgun_Ogun_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogun",
                        principalColumn: "Ogun_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_YemekCesidiPorsiyonOgun_Porsiyon_Porsiyon_Id",
                        column: x => x.Porsiyon_Id,
                        principalTable: "Porsiyon",
                        principalColumn: "Porsiyon_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_YemekCesidiPorsiyonOgun_Yemek Cesidi_YemekCesidi_ID",
                        column: x => x.YemekCesidi_ID,
                        principalTable: "Yemek Cesidi",
                        principalColumn: "YemekCesidi_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YemekCesidiUrun",
                columns: table => new
                {
                    YemekCesiId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekCesidiUrun", x => new { x.YemekCesiId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_YemekCesidiUrun_Urunler_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Urunler",
                        principalColumn: "Urun_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_YemekCesidiUrun_Yemek Cesidi_YemekCesiId",
                        column: x => x.YemekCesiId,
                        principalTable: "Yemek Cesidi",
                        principalColumn: "YemekCesidi_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YemekKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    KategoriId = table.Column<int>(type: "integer", nullable: false),
                    YemekCesidi_Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekKategori", x => new { x.Id, x.KategoriId, x.YemekCesidi_Id });
                    table.ForeignKey(
                        name: "FK_YemekKategori_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "Kategori_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_YemekKategori_Yemek Cesidi_YemekCesidi_Id",
                        column: x => x.YemekCesidi_Id,
                        principalTable: "Yemek Cesidi",
                        principalColumn: "YemekCesidi_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserOgunYemekCesit",
                columns: table => new
                {
                    UserOgunYemekCesidiId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    YemekCesidiPorsiyonOgun_Id = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOgunYemekCesit", x => x.UserOgunYemekCesidiId);
                    table.ForeignKey(
                        name: "FK_UserOgunYemekCesit_Kullanıcılar_UserId",
                        column: x => x.UserId,
                        principalTable: "Kullanıcılar",
                        principalColumn: "User_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserOgunYemekCesit_YemekCesidiPorsiyonOgun_YemekCesidiPorsiyonOgun_Id",
                        column: x => x.YemekCesidiPorsiyonOgun_Id,
                        principalTable: "YemekCesidiPorsiyonOgun",
                        principalColumn: "YemekCesidiPorsiyonOgun_Id ",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanıcılar_UserDetailId",
                table: "Kullanıcılar",
                column: "UserDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserOgunYemekCesit_UserId",
                table: "UserOgunYemekCesit",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOgunYemekCesit_YemekCesidiPorsiyonOgun_Id",
                table: "UserOgunYemekCesit",
                column: "YemekCesidiPorsiyonOgun_Id");

            migrationBuilder.CreateIndex(
                name: "IX_YemekCesidiPorsiyonOgun_OgunId",
                table: "YemekCesidiPorsiyonOgun",
                column: "OgunId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekCesidiPorsiyonOgun_Porsiyon_Id",
                table: "YemekCesidiPorsiyonOgun",
                column: "Porsiyon_Id");

            migrationBuilder.CreateIndex(
                name: "IX_YemekCesidiPorsiyonOgun_YemekCesidi_ID",
                table: "YemekCesidiPorsiyonOgun",
                column: "YemekCesidi_ID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekCesidiUrun_ProductId",
                table: "YemekCesidiUrun",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekKategori_KategoriId",
                table: "YemekKategori",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekKategori_YemekCesidi_Id",
                table: "YemekKategori",
                column: "YemekCesidi_Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserOgunYemekCesit");

            migrationBuilder.DropTable(
                name: "YemekCesidiUrun");

            migrationBuilder.DropTable(
                name: "YemekKategori");

            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "YemekCesidiPorsiyonOgun");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "Ogun");

            migrationBuilder.DropTable(
                name: "Porsiyon");

            migrationBuilder.DropTable(
                name: "Yemek Cesidi");
        }
    }
}
