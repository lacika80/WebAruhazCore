using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _03290202 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filter2Product_Filter_FId",
                table: "Filter2Product");

            migrationBuilder.AddColumn<int>(
                name: "FilterFId",
                table: "Filter2Product",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Filter2Product_FilterFId",
                table: "Filter2Product",
                column: "FilterFId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filter2Product_Filter_FilterFId",
                table: "Filter2Product",
                column: "FilterFId",
                principalTable: "Filter",
                principalColumn: "FId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filter2Product_Filter_FilterFId",
                table: "Filter2Product");

            migrationBuilder.DropIndex(
                name: "IX_Filter2Product_FilterFId",
                table: "Filter2Product");

            migrationBuilder.DropColumn(
                name: "FilterFId",
                table: "Filter2Product");

            migrationBuilder.AddForeignKey(
                name: "FK_Filter2Product_Filter_FId",
                table: "Filter2Product",
                column: "FId",
                principalTable: "Filter",
                principalColumn: "FId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
