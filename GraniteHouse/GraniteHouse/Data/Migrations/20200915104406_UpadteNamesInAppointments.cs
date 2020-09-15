using Microsoft.EntityFrameworkCore.Migrations;

namespace GraniteHouse.Data.Migrations
{
    public partial class UpadteNamesInAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CutomerEmail",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CutomerName",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CutomerPhoneNumber",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Appointments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerPhoneNumber",
                table: "Appointments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "CustomerPhoneNumber",
                table: "Appointments");

            migrationBuilder.AddColumn<string>(
                name: "CutomerEmail",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CutomerName",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CutomerPhoneNumber",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
