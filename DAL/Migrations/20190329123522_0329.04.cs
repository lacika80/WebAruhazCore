using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _032904 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_PhotoId",
                table: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_Product_PhotoId",
                table: "Product",
                column: "PhotoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_PhotoId",
                table: "Product");

            migrationBuilder.CreateIndex(
                name: "IX_Product_PhotoId",
                table: "Product",
                column: "PhotoId",
                unique: true);
        }
    }
}
