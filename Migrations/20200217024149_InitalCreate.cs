using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductTest.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandTitle = table.Column<string>(nullable: true),
                    PatternTitle = table.Column<string>(nullable: true),
                    Sku = table.Column<string>(nullable: true),
                    Width = table.Column<string>(nullable: true),
                    AspectRatio = table.Column<string>(nullable: true),
                    RimSize = table.Column<string>(nullable: true),
                    LoadRating1 = table.Column<string>(nullable: true),
                    LoadRating2 = table.Column<string>(nullable: true),
                    Speed = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true),
                    Homologation1 = table.Column<string>(nullable: true),
                    Homologation2 = table.Column<string>(nullable: true),
                    RunFlat = table.Column<string>(nullable: true),
                    MOE = table.Column<string>(nullable: true),
                    SUV = table.Column<string>(nullable: true),
                    Seal = table.Column<string>(nullable: true),
                    NoiseCancelling = table.Column<string>(nullable: true),
                    LightTruck = table.Column<string>(nullable: true),
                    Commercial = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skus");
        }
    }
}
