using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _03290207 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Photo_PhotoId",
                table: "Product");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "PhotoId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Photo_PhotoId",
                table: "Product");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "PhotoId",
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
    }
}
