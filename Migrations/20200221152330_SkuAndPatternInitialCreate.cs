using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductTest.Migrations
{
    public partial class SkuAndPatternInitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patterns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Overview = table.Column<string>(nullable: true),
                    SalesHook = table.Column<string>(nullable: true),
                    Features = table.Column<string>(nullable: true),
                    Images = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Synonyms = table.Column<string>(nullable: true),
                    Performance = table.Column<bool>(nullable: false),
                    LowerNoise = table.Column<bool>(nullable: false),
                    HigherMilage = table.Column<bool>(nullable: false),
                    UltraHighPerformance = table.Column<bool>(nullable: false),
                    Eco = table.Column<bool>(nullable: false),
                    SemiSlick = table.Column<bool>(nullable: false),
                    Touring = table.Column<bool>(nullable: false),
                    AllSeason = table.Column<bool>(nullable: false),
                    HighwayTerrain = table.Column<bool>(nullable: false),
                    AllTerrain = table.Column<bool>(nullable: false),
                    HeavyAllTerrain = table.Column<bool>(nullable: false),
                    MudTerrain = table.Column<bool>(nullable: false),
                    TreadType = table.Column<string>(nullable: true),
                    QualityCategory = table.Column<string>(nullable: true),
                    ColourSmoke = table.Column<bool>(nullable: false),
                    Segment = table.Column<string>(nullable: true),
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
                    BrandTitle = table.Column<string>(nullable: true),
                    PatternTitle = table.Column<string>(nullable: true),
                    Sku = table.Column<string>(nullable: true),
                    Width = table.Column<int>(nullable: false),
                    AspectRatio = table.Column<int>(nullable: false),
                    RimSize = table.Column<int>(nullable: false),
                    LoadRating1 = table.Column<int>(nullable: false),
                    LoadRating2 = table.Column<int>(nullable: false),
                    Speed = table.Column<char>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Active = table.Column<int>(nullable: false),
                    Homologation1 = table.Column<int>(nullable: false),
                    Homologation2 = table.Column<int>(nullable: false),
                    RunFlat = table.Column<int>(nullable: false),
                    MOE = table.Column<int>(nullable: false),
                    SUV = table.Column<int>(nullable: false),
                    Seal = table.Column<int>(nullable: false),
                    NoiseCancelling = table.Column<int>(nullable: false),
                    LightTruck = table.Column<int>(nullable: false),
                    Commercial = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patterns");

            migrationBuilder.DropTable(
                name: "Skus");
        }
    }
}
