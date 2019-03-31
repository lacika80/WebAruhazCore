using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _03290206 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product",
                column: "CatId",
                principalTable: "Category",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CatId",
                table: "Product",
                column: "CatId",
                principalTable: "Category",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
