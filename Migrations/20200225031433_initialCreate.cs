using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductTest.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BooleanTests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooleanTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patterns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandTitle = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Overview = table.Column<string>(nullable: true),
                    SalesHookLine = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Synonyms = table.Column<bool>(nullable: true),
                    Performance = table.Column<bool>(nullable: true),
                    LowerNoise = table.Column<bool>(nullable: true),
                    HigherMileage = table.Column<bool>(nullable: true),
                    UltraHighPerformance = table.Column<bool>(nullable: true),
                    Eco = table.Column<bool>(nullable: true),
                    SemiSlick = table.Column<bool>(nullable: true),
                    Touring = table.Column<bool>(nullable: true),
                    AllSeason = table.Column<bool>(nullable: true),
                    HighwayTerrain = table.Column<bool>(nullable: true),
                    AllTerrain = table.Column<bool>(nullable: true),
                    HeavyAllTerrain = table.Column<bool>(nullable: true),
                    MudTerrain = table.Column<bool>(nullable: true),
                    TreadType = table.Column<bool>(nullable: true),
                    QualityCategory = table.Column<bool>(nullable: true),
                    ColourSmoke = table.Column<bool>(nullable: true),
                    Segment = table.Column<bool>(nullable: true),
                    Key = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patterns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandTitle = table.Column<string>(nullable: false),
                    PatternTitle = table.Column<string>(nullable: false),
                    Sku = table.Column<string>(nullable: false),
                    Width = table.Column<int>(nullable: true),
                    AspectRatio = table.Column<int>(nullable: true),
                    RimSize = table.Column<int>(nullable: true),
                    LoadRating1 = table.Column<int>(nullable: true),
                    LoadRating2 = table.Column<int>(nullable: true),
                    Speed = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Homologation1 = table.Column<string>(nullable: true),
                    Homologation2 = table.Column<string>(nullable: true),
                    RunFlat = table.Column<bool>(nullable: true),
                    MOE = table.Column<bool>(nullable: true),
                    SUV = table.Column<bool>(nullable: true),
                    Seal = table.Column<bool>(nullable: true),
                    NoiseCancelling = table.Column<bool>(nullable: true),
                    LightTruck = table.Column<bool>(nullable: true),
                    Commercial = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Age = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooleanTests");

            migrationBuilder.DropTable(
                name: "Patterns");

            migrationBuilder.DropTable(
                name: "Skus");

            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
