using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnerBikes.Migrations
{
    public partial class AddThumbnailTransmissionEngine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Engine",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Transmission",
                table: "Bikes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Engine",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Bikes");
        }
    }
}
