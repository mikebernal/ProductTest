using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;
using ProductTest.Models;
using ProductTest.Validators;

namespace ProductTest.Data
{
  public class PatternValidator : AbstractValidator<PatternTest>
  {
    public PatternValidator()
    {
        RuleFor(x => x.BrandTitle).NotEmpty().Length(1, 20).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        RuleFor(x => x.Title).NotEmpty().Length(1, 20).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        RuleFor(x => x.Overview).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        RuleFor(x => x.SalesHookLine).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        RuleFor(x => x.Features).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        RuleFor(x => x.Images).isInvalidFileName();
        RuleFor(x => x.Active).isBool();
        RuleFor(x => x.Synonyms).isBool();
        RuleFor(x => x.Performance).isBool();
        RuleFor(x => x.LowerNoise).isBool();
        RuleFor(x => x.HigherMileage).isBool();
        RuleFor(x => x.UltraHighPerformance).isBool();
        RuleFor(x => x.Eco).isBool();
        RuleFor(x => x.SemiSlick).isBool();
        RuleFor(x => x.Touring).isBool();
        RuleFor(x => x.AllSeason).isBool();
        RuleFor(x => x.AllTerrain).isBool();
        RuleFor(x => x.HeavyAllTerrain).isBool();
        RuleFor(x => x.MudTerrain).isBool();
        RuleFor(x => x.TreadType).isBool();
        RuleFor(x => x.QualityCategory).isBool();
        RuleFor(x => x.ColourSmoke).isBool();
        RuleFor(x => x.Segment).isBool();
        RuleFor(x => x.Key).NotStartWithWhiteSpace().NotEndWithWhiteSpace();

    }
  }
}