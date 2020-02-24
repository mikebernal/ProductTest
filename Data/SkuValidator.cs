using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;
using ProductTest.Models;

namespace ProductTest.Data
{

  public class SkuValidator : AbstractValidator<SkuTest>
  {
    public SkuValidator()
    {
        RuleFor(x => x.BrandTitle).NotEmpty().Length(1, 20);
        RuleFor(x => x.PatternTitle).NotEmpty().Length(1, 20);
        RuleFor(x => x.Sku).NotEmpty().Length(13, 15);
        RuleFor(x => x.Width);
        RuleFor(x => x.AspectRatio);
        RuleFor(x => x.RimSize);
        RuleFor(x => x.LoadRating1);
        RuleFor(x => x.LoadRating2);
        RuleFor(x => x.Speed).Length(0, 2).Matches("/[jklmnopqrstuvwyz](vr|zr)/ig");
        RuleFor(x => x.Description);
        RuleFor(x => x.Active).Must(x => x == false || x == true);
        RuleFor(x => x.Homologation1);
        RuleFor(x => x.Homologation2);
        RuleFor(x => x.RunFlat).Must(x => x == false || x == true);
        RuleFor(x => x.MOE).Must(x => x == false || x == true);
        RuleFor(x => x.SUV).Must(x => x == false || x == true);
        RuleFor(x => x.Seal).Must(x => x == false || x == true);
        RuleFor(x => x.NoiseCancelling).Must(x => x == false || x == true);
        RuleFor(x => x.LightTruck).Must(x => x == false || x == true);
        RuleFor(x => x.Commercial).Must(x => x == false || x == true);

    }

  }
}