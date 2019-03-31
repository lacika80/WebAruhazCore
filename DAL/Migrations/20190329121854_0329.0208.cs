using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _03290208 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Filter2Product_Filter_FilterFId",
                table: "Filter2Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Photo_PhotoId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product2Photo",
                table: "Product2Photo");

            migrationBuilder.DropIndex(
                name: "IX_Product2Photo_ProdId",
                table: "Product2Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filter2Product",
                table: "Filter2Product");

            migrationBuilder.DropIndex(
                name: "IX_Filter2Product_FilterFId",
                table: "Filter2Product");

            migrationBuilder.DropIndex(
                name: "IX_Filter2Product_ProdId",
                table: "Filter2Product");

            migrationBuilder.DropColumn(
                name: "P2PId",
                table: "Product2Photo");

            migrationBuilder.DropColumn(
                name: "F2PId",
                table: "Filter2Product");

            migrationBuilder.DropColumn(
                name: "FilterFId",
                table: "Filter2Product");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetPrice",
                table: "Product",
                type: "decimal(8, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)",
                oldComputedColumnSql: "[BrutPrice]/(1+[VAT])");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product2Photo",
                table: "Product2Photo",
                columns: new[] { "ProdId", "PhotoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filter2Product",
                table: "Filter2Product",
                columns: new[] { "ProdId", "FId" });

            migrationBuilder.CreateIndex(
                name: "IX_Product2Photo_PhotoId",
                table: "Product2Photo",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Filter2Product_FId",
                table: "Filter2Product",
                column: "FId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filter2Product_Filter_FId",
                table: "Filter2Product",
                column: "FId",
                principalTable: "Filter",
                principalColumn: "FId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product",
                column: "CatId",
                principalTable: "Category",
                principalColumn: "CatId",
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
                name: "FK_Filter2Product_Filter_FId",
                table: "Filter2Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Photo_PhotoId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product2Photo",
                table: "Product2Photo");

            migrationBuilder.DropIndex(
                name: "IX_Product2Photo_PhotoId",
                table: "Product2Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Filter2Product",
                table: "Filter2Product");

            migrationBuilder.DropIndex(
                name: "IX_Filter2Product_FId",
                table: "Filter2Product");

            migrationBuilder.AddColumn<int>(
                name: "P2PId",
                table: "Product2Photo",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "F2PId",
                table: "Filter2Product",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "FilterFId",
                table: "Filter2Product",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetPrice",
                table: "Product",
                type: "decimal(8, 2)",
                nullable: false,
                computedColumnSql: "[BrutPrice]/(1+[VAT])",
                oldClrType: typeof(decimal),
                oldType: "decimal(8, 2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product2Photo",
                table: "Product2Photo",
                columns: new[] { "PhotoId", "ProdId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Filter2Product",
                table: "Filter2Product",
                columns: new[] { "FId", "ProdId" });

            migrationBuilder.CreateIndex(
                name: "IX_Product2Photo_ProdId",
                table: "Product2Photo",
                column: "ProdId");

            migrationBuilder.CreateIndex(
                name: "IX_Filter2Product_FilterFId",
                table: "Filter2Product",
                column: "FilterFId");

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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Filter2Product_Filter_FilterFId",
                table: "Filter2Product",
                column: "FilterFId",
                principalTable: "Filter",
                principalColumn: "FId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product",
                column: "CatId",
                principalTable: "Category",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Photo_PhotoId",
                table: "Product",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
