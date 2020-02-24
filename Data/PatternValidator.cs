using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;
using ProductTest.Models;

namespace ProductTest.Data
{
  public class PatternValidator : AbstractValidator<PatternTest>
  {
    public PatternValidator()
    {
        RuleFor(x => x.BrandTitle).NotEmpty().Length(1, 20);
        RuleFor(x => x.Title).NotEmpty().Length(1, 20);
        RuleFor(x => x.Overview);
        RuleFor(x => x.SalesHookLine);
        RuleFor(x => x.Features);
        RuleFor(x => x.Images);
        RuleFor(x => x.Active).Must(x => x == false || x == true);
        RuleFor(x => x.Synonyms).Must(x => x == false || x == true);
        RuleFor(x => x.Performance).Must(x => x == false || x == true);
        RuleFor(x => x.LowerNoise).Must(x => x == false || x == true);
        RuleFor(x => x.HigherMileage).Must(x => x == false || x == true);
        RuleFor(x => x.UltraHighPerformance).Must(x => x == false || x == true);
        RuleFor(x => x.Eco).Must(x => x == false || x == true);
        RuleFor(x => x.SemiSlick).Must(x => x == false || x == true);
        RuleFor(x => x.Touring).Must(x => x == false || x == true);
        RuleFor(x => x.AllSeason).Must(x => x == false || x == true);
        RuleFor(x => x.AllTerrain).Must(x => x == false || x == true);
        RuleFor(x => x.HeavyAllTerrain).Must(x => x == false || x == true);
        RuleFor(x => x.MudTerrain).Must(x => x == false || x == true);
        RuleFor(x => x.TreadType).Must(x => x == false || x == true);
        RuleFor(x => x.QualityCategory).Must(x => x == false || x == true);
        RuleFor(x => x.ColourSmoke).Must(x => x == false || x == true);
        RuleFor(x => x.Segment).Must(x => x == false || x == true);
        RuleFor(x => x.Key);


    }
  }
}