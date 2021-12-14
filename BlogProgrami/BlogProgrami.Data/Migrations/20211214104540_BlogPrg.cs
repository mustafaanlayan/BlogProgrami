using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProgrami.Data.Migrations
{
    public partial class BlogPrg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifeDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Notlar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifeDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Notlar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullaniciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Soyadi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SifreHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifeDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Notlar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullaniciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kullaniciler_Roller_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Makaleler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Icerik = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OkunmaSayisi = table.Column<int>(type: "int", nullable: false),
                    YorumSayisi = table.Column<int>(type: "int", nullable: false),
                    MetaTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAciklama = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Etiket = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifeDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Notlar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makaleler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Makaleler_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Makaleler_Kullaniciler_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullaniciler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yazi = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifeDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Notlar = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorumlar_Makaleler_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Makaleler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Aciklama", "Adi", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifeDateTime", "ModifedByName", "Notlar" },
                values: new object[,]
                {
                    { 1, "C# Programlama Dili", "Csharp", "InitialCreate", new DateTime(2021, 12, 14, 13, 45, 38, 843, DateTimeKind.Local).AddTicks(794), true, false, new DateTime(2021, 12, 14, 13, 45, 38, 843, DateTimeKind.Local).AddTicks(819), "InitialCreate", "C# Blok Kategorisi" },
                    { 2, "C++ Programlama Dili", "Cplus", "InitialCreate", new DateTime(2021, 12, 14, 13, 45, 38, 843, DateTimeKind.Local).AddTicks(846), true, false, new DateTime(2021, 12, 14, 13, 45, 38, 843, DateTimeKind.Local).AddTicks(848), "InitialCreate", "C++ Blok Kategorisi" },
                    { 3, "Java Programlama Dili", "Java", "InitialCreate", new DateTime(2021, 12, 14, 13, 45, 38, 843, DateTimeKind.Local).AddTicks(857), true, false, new DateTime(2021, 12, 14, 13, 45, 38, 843, DateTimeKind.Local).AddTicks(859), "InitialCreate", "JavaBlok Kategorisi" }
                });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "Id", "Aciklama", "Adi", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifeDateTime", "ModifedByName", "Notlar" },
                values: new object[] { 1, "Admin Rolü Tüm Haklara Sahiptir", "Admin", "InitialCreate", new DateTime(2021, 12, 14, 13, 45, 38, 849, DateTimeKind.Local).AddTicks(8395), true, false, new DateTime(2021, 12, 14, 13, 45, 38, 849, DateTimeKind.Local).AddTicks(8417), "InitialCreate", "Admin Rolüdür" });

            migrationBuilder.InsertData(
                table: "Kullaniciler",
                columns: new[] { "Id", "Aciklama", "Adi", "CreatedByName", "CreatedDate", "Email", "IsActive", "IsDeleted", "KullaniciAdi", "ModifeDateTime", "ModifedByName", "Notlar", "Resim", "RoleId", "SifreHash", "Soyadi" },
                values: new object[] { 1, "ilk Admin Kullanıcısı", "Mustafa", "InitialCreate", new DateTime(2021, 12, 14, 13, 45, 38, 861, DateTimeKind.Local).AddTicks(5580), "mustafaanlayan@tgmail.com", true, false, "mustafaanlayan", new DateTime(2021, 12, 14, 13, 45, 38, 861, DateTimeKind.Local).AddTicks(5606), "InitialCreate", "Admin Kullanıcısı", "Defaultİmage", 1, new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 }, "ANLAYAN" });

            migrationBuilder.InsertData(
                table: "Makaleler",
                columns: new[] { "Id", "Baslik", "CategoryId", "CreatedByName", "CreatedDate", "Date", "Etiket", "Icerik", "IsActive", "IsDeleted", "KullaniciId", "MetaTag", "ModifeDateTime", "ModifedByName", "Notlar", "OkunmaSayisi", "Resim", "SeoAciklama", "YorumSayisi" },
                values: new object[] { 1, "C# 9.0", 1, "InitialCreate", new DateTime(2021, 12, 14, 13, 45, 38, 837, DateTimeKind.Local).AddTicks(387), new DateTime(2021, 12, 14, 13, 45, 38, 836, DateTimeKind.Local).AddTicks(8554), "C#", "gdeggwhhwhwhewhwhwhwhhwhjwhwehhwehwehwehhwehwhwhh", true, false, 1, "C#,C#9", new DateTime(2021, 12, 14, 13, 45, 38, 837, DateTimeKind.Local).AddTicks(1319), "InitialCreate", "JavaBlok Kategorisi", 100, "Default.jpeg", "C# 9.0", 1 });

            migrationBuilder.InsertData(
                table: "Makaleler",
                columns: new[] { "Id", "Baslik", "CategoryId", "CreatedByName", "CreatedDate", "Date", "Etiket", "Icerik", "IsActive", "IsDeleted", "KullaniciId", "MetaTag", "ModifeDateTime", "ModifedByName", "Notlar", "OkunmaSayisi", "Resim", "SeoAciklama", "YorumSayisi" },
                values: new object[] { 2, "C# 9.0", 2, "InitialCreate", new DateTime(2021, 12, 14, 13, 45, 38, 837, DateTimeKind.Local).AddTicks(3803), new DateTime(2021, 12, 14, 13, 45, 38, 837, DateTimeKind.Local).AddTicks(3800), "c#", "gdeggwhhwhwhewhwhwhwhhwhjwhwehhwehwehwehhwehwhwhh", true, false, 1, "C#,C#9", new DateTime(2021, 12, 14, 13, 45, 38, 837, DateTimeKind.Local).AddTicks(3806), "InitialCreate", "JavaBlok Kategorisi", 100, "Default.jpeg", "C# 9.0", 1 });

            migrationBuilder.InsertData(
                table: "Yorumlar",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifeDateTime", "ModifedByName", "Notlar", "Yazi" },
                values: new object[] { 1, 1, "InitialCreate", new DateTime(2021, 12, 14, 13, 45, 38, 846, DateTimeKind.Local).AddTicks(7357), true, false, new DateTime(2021, 12, 14, 13, 45, 38, 846, DateTimeKind.Local).AddTicks(7382), "InitialCreate", "JavaBlok Kategorisi", "hhushshaıusıusahsusjhjsakjsajsjskj" });

            migrationBuilder.CreateIndex(
                name: "IX_Kullaniciler_Email",
                table: "Kullaniciler",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kullaniciler_KullaniciAdi",
                table: "Kullaniciler",
                column: "KullaniciAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kullaniciler_RoleId",
                table: "Kullaniciler",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Makaleler_CategoryId",
                table: "Makaleler",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Makaleler_KullaniciId",
                table: "Makaleler",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_ArticleId",
                table: "Yorumlar",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yorumlar");

            migrationBuilder.DropTable(
                name: "Makaleler");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Kullaniciler");

            migrationBuilder.DropTable(
                name: "Roller");
        }
    }
}
