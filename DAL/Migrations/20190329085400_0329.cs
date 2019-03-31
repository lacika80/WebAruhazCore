using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _0329 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category2Product");

            migrationBuilder.DropColumn(
                name: "CatName",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "CatsBoss",
                table: "Category",
                newName: "PhotoId");

            migrationBuilder.RenameColumn(
                name: "CatId",
                table: "Category",
                newName: "CatIdId");

            migrationBuilder.AddColumn<int>(
                name: "CatId",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActiveCat",
                table: "Category",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "PhotoId1",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Filter",
                columns: table => new
                {
                    FId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FName = table.Column<string>(nullable: false),
                    FsBoss = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filter", x => x.FId);
                });

            migrationBuilder.CreateTable(
                name: "Filter2Product",
                columns: table => new
                {
                    ProdId = table.Column<int>(nullable: false),
                    FId = table.Column<int>(nullable: false),
                    F2PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filter2Product", x => new { x.FId, x.ProdId });
                    table.ForeignKey(
                        name: "FK_Filter2Product_Filter_FId",
                        column: x => x.FId,
                        principalTable: "Filter",
                        principalColumn: "FId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Filter2Product_Product_ProdId",
                        column: x => x.ProdId,
                        principalTable: "Product",
                        principalColumn: "ProdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CatId",
                table: "Product",
                column: "CatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_PhotoId",
                table: "Product",
                column: "PhotoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_PhotoId",
                table: "Category",
                column: "PhotoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_PhotoId1",
                table: "Category",
                column: "PhotoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Filter2Product_ProdId",
                table: "Filter2Product",
                column: "ProdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Photo_PhotoId1",
                table: "Category",
                column: "PhotoId1",
                principalTable: "Photo",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product",
                column: "CatId",
                principalTable: "Category",
                principalColumn: "CatIdId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Photo_PhotoId",
                table: "Product",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Photo_PhotoId1",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Photo_PhotoId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Filter2Product");

            migrationBuilder.DropTable(
                name: "Filter");

            migrationBuilder.DropIndex(
                name: "IX_Product_CatId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_PhotoId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Category_PhotoId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_PhotoId1",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "CatId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsActiveCat",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "PhotoId1",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "PhotoId",
                table: "Category",
                newName: "CatsBoss");

            migrationBuilder.RenameColumn(
                name: "CatIdId",
                table: "Category",
                newName: "CatId");

            migrationBuilder.AddColumn<string>(
                name: "CatName",
                table: "Category",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Category2Product",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false),
                    ProdId = table.Column<int>(nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_Category2Product_ProdId",
                table: "Category2Product",
                column: "ProdId");
        }
    }
}
