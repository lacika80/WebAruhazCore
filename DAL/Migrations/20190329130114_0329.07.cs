using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _032907 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Photo_PhotoId1",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_PhotoId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_PhotoId1",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "PhotoId1",
                table: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_Category_PhotoId",
                table: "Category",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Photo_PhotoId",
                table: "Category",
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

            migrationBuilder.DropIndex(
                name: "IX_Category_PhotoId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "PhotoId1",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_PhotoId",
                table: "Category",
                column: "PhotoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_PhotoId1",
                table: "Category",
                column: "PhotoId1");

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
        }
    }
}
