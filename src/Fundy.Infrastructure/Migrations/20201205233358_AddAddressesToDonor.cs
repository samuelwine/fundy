using Microsoft.EntityFrameworkCore.Migrations;

namespace Fundy.Infrastructure.Migrations
{
    public partial class AddAddressesToDonor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_City",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Country",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_County_Province",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Line1",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Line2",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Line3",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Postcode_Zip",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkAddress_City",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkAddress_Country",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkAddress_County_Province",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkAddress_Line1",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkAddress_Line2",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkAddress_Line3",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkAddress_Postcode_Zip",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeAddress_City",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Country",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "HomeAddress_County_Province",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Line1",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Line2",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Line3",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Postcode_Zip",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "WorkAddress_City",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "WorkAddress_Country",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "WorkAddress_County_Province",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "WorkAddress_Line1",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "WorkAddress_Line2",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "WorkAddress_Line3",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "WorkAddress_Postcode_Zip",
                table: "Donors");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
