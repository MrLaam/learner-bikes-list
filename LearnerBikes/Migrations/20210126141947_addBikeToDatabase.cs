using Microsoft.EntityFrameworkCore.Migrations;

namespace LearnerBikes.Migrations
{
    public partial class addBikeToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DryWeight = table.Column<int>(type: "int", nullable: false),
                    WetWeight = table.Column<int>(type: "int", nullable: false),
                    TankCapacity = table.Column<double>(type: "float", nullable: false),
                    BikeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeatHeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinYear = table.Column<int>(type: "int", nullable: false),
                    MaxYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bikes");
        }
    }
}
