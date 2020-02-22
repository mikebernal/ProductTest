using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductTest.Migrations
{
    public partial class InitialCreate : Migration
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
                    Active = table.Column<string>(nullable: true),
                    Synonyms = table.Column<string>(nullable: true),
                    Performance = table.Column<string>(nullable: true),
                    LowerNoise = table.Column<string>(nullable: true),
                    HigherMilage = table.Column<string>(nullable: true),
                    UltraHighPerformance = table.Column<string>(nullable: true),
                    Eco = table.Column<string>(nullable: true),
                    SemiSlick = table.Column<string>(nullable: true),
                    Touring = table.Column<string>(nullable: true),
                    AllSeason = table.Column<string>(nullable: true),
                    HighwayTerrain = table.Column<string>(nullable: true),
                    AllTerrain = table.Column<string>(nullable: true),
                    HeavyAllTerrain = table.Column<string>(nullable: true),
                    MudTerrain = table.Column<string>(nullable: true),
                    TreadType = table.Column<string>(nullable: true),
                    QualityCategory = table.Column<string>(nullable: true),
                    ColourSmoke = table.Column<string>(nullable: true),
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
                    Width = table.Column<string>(nullable: true),
                    AspectRatio = table.Column<string>(nullable: true),
                    RimSize = table.Column<string>(nullable: true),
                    LoadRating1 = table.Column<string>(nullable: true),
                    LoadRating2 = table.Column<string>(nullable: true),
                    Speed = table.Column<char>(nullable: false),
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
                name: "Patterns");

            migrationBuilder.DropTable(
                name: "Skus");
        }
    }
}
