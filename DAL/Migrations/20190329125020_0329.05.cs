using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _032905 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filter2Product_Filter_FId",
                table: "Filter2Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Filter2Product_Product_ProdId",
                table: "Filter2Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Photo_PhotoId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product2Photo_Photo_PhotoId",
                table: "Product2Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Product2Photo_Product_ProdId",
                table: "Product2Photo");

            migrationBuilder.AddForeignKey(
                name: "FK_Filter2Product_Filter_FId",
                table: "Filter2Product",
                column: "FId",
                principalTable: "Filter",
                principalColumn: "FId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Filter2Product_Product_ProdId",
                table: "Filter2Product",
                column: "ProdId",
                principalTable: "Product",
                principalColumn: "ProdId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Product2Photo_Photo_PhotoId",
                table: "Product2Photo",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product2Photo_Product_ProdId",
                table: "Product2Photo",
                column: "ProdId",
                principalTable: "Product",
                principalColumn: "ProdId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filter2Product_Filter_FId",
                table: "Filter2Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Filter2Product_Product_ProdId",
                table: "Filter2Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Photo_PhotoId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product2Photo_Photo_PhotoId",
                table: "Product2Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Product2Photo_Product_ProdId",
                table: "Product2Photo");

            migrationBuilder.AddForeignKey(
                name: "FK_Filter2Product_Filter_FId",
                table: "Filter2Product",
                column: "FId",
                principalTable: "Filter",
                principalColumn: "FId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Filter2Product_Product_ProdId",
                table: "Filter2Product",
                column: "ProdId",
                principalTable: "Product",
                principalColumn: "ProdId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Product2Photo_Photo_PhotoId",
                table: "Product2Photo",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product2Photo_Product_ProdId",
                table: "Product2Photo",
                column: "ProdId",
                principalTable: "Product",
                principalColumn: "ProdId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
