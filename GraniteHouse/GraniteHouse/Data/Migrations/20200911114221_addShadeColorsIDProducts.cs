using Microsoft.EntityFrameworkCore.Migrations;

namespace GraniteHouse.Data.Migrations
{
    public partial class addShadeColorsIDProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShadeColorsId",
                table: "Products",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShadeColorsId",
                table: "Products",
                column: "ShadeColorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ShadeColors_ShadeColorsId",
                table: "Products",
                column: "ShadeColorsId",
                principalTable: "ShadeColors",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ShadeColors_ShadeColorsId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ShadeColorsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShadeColorsId",
                table: "Products");
        }
    }
}
