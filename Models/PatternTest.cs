using System.ComponentModel.DataAnnotations;

namespace ProductTest.Models
{
    public class PatternTest
    {
        public int Id { get; set; }
        [Required]
        public string BrandTitle { get; set; }
        [Required]
        public string Title { get; set; }
        public string Overview { get; set; }
        public string SalesHookLine { get; set; }
        public string Features { get; set; }
        public string Images { get; set; }
        public bool? Active { get; set; }
        public bool? Synonyms { get; set; }
        public bool? Performance { get; set; }
        public bool? LowerNoise { get; set; }
        public bool? HigherMileage { get; set; }
        public bool? UltraHighPerformance { get; set; }
        public bool? Eco { get; set; }
        public bool? SemiSlick { get; set; }
        public bool? Touring { get; set; }
        public bool? AllSeason { get; set; }
        public bool? HighwayTerrain { get; set; }
        public bool? AllTerrain { get; set; }
        public bool? HeavyAllTerrain { get; set; }
        public bool? MudTerrain { get; set; }
        public bool? TreadType { get; set; }
        public bool? QualityCategory { get; set; }
        public bool? ColourSmoke { get; set; }
        public bool? Segment { get; set; }
        public string Key { get; set; }
    }
}