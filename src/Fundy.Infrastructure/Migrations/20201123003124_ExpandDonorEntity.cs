using Microsoft.EntityFrameworkCore.Migrations;

namespace Fundy.Infrastructure.Migrations
{
    public partial class ExpandDonorEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Donors");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ToDoItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Donors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Donors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Donors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Donors");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ToDoItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Donors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
