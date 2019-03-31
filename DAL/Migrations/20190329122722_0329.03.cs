using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _032903 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_CatId",
                table: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CatId",
                table: "Product",
                column: "CatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_CatId",
                table: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CatId",
                table: "Product",
                column: "CatId",
                unique: true);
        }
    }
}
