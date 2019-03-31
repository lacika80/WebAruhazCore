using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class teszt3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatName = table.Column<string>(nullable: false),
                    CatsBoss = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActivePhoto = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    PhotoType = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActiveProd = table.Column<bool>(nullable: false, defaultValueSql: "1"),
                    ProdName = table.Column<string>(nullable: false),
                    ProdDescription = table.Column<string>(nullable: true),
                    NetPrice = table.Column<decimal>(type: "decimal(8, 2)", nullable: false, computedColumnSql: "[BrutPrice]/(1+[VAT])"),
                    VAT = table.Column<decimal>(type: "decimal(4, 3)", nullable: false),
                    BrutPrice = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    ProdSeen = table.Column<long>(nullable: false),
                    ProdCreated = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    ProdPriceChanged = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProdId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsAdmin = table.Column<bool>(nullable: false, defaultValueSql: "0"),
                    UserName = table.Column<string>(nullable: false),
                    UserPassword = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Category2Product",
                columns: table => new
                {
                    ProdId = table.Column<int>(nullable: false),
                    CatId = table.Column<int>(nullable: false),
                    C2PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category2Product", x => new { x.CatId, x.ProdId });
                    table.ForeignKey(
                        name: "FK_Category2Product_Category_CatId",
                        column: x => x.CatId,
                        principalTable: "Category",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Category2Product_Product_ProdId",
                        column: x => x.ProdId,
                        principalTable: "Product",
                        principalColumn: "ProdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product2Photo",
                columns: table => new
                {
                    ProdId = table.Column<int>(nullable: false),
                    PhotoId = table.Column<int>(nullable: false),
                    P2PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product2Photo", x => new { x.PhotoId, x.ProdId });
                    table.ForeignKey(
                        name: "FK_Product2Photo_Photo_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photo",
                        principalColumn: "PhotoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product2Photo_Product_ProdId",
                        column: x => x.ProdId,
                        principalTable: "Product",
                        principalColumn: "ProdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Category2Product_ProdId",
                table: "Category2Product",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_Product2Photo_ProdId",
                table: "Product2Photo",
                column: "ProdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category2Product");

            migrationBuilder.DropTable(
                name: "Product2Photo");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Photo");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
