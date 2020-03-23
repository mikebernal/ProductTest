using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentValidation;
using ProductTest.Models;
using ProductTest.Validators;

namespace ProductTest.Data {
  public class SkuValidator : AbstractValidator<SkuTest> {
    public SkuValidator() {
        RuleFor(x => x.BrandTitle).NotEmpty().Length(1, 20).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        RuleFor(x => x.PatternTitle).NotEmpty().Length(1, 20).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        RuleFor(x => x.Sku).NotEmpty().Length(12, 15).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        RuleFor(x => x.Width);
        RuleFor(x => x.AspectRatio);
        RuleFor(x => x.RimSize);
        RuleFor(x => x.LoadRating1);
        RuleFor(x => x.LoadRating2);
        RuleFor(x => x.Speed).NotStartWithWhiteSpace().NotEndWithWhiteSpace();
        RuleFor(x => x.Description);
        RuleFor(x => x.Active).isBool();
        RuleFor(x => x.Homologation1);
        RuleFor(x => x.Homologation2);
        RuleFor(x => x.RunFlat).isBool();
        RuleFor(x => x.MOE).isBool();
        RuleFor(x => x.SUV).isBool();
        RuleFor(x => x.Seal).isBool();
        RuleFor(x => x.NoiseCancelling).isBool();
        RuleFor(x => x.LightTruck).isBool();
        RuleFor(x => x.Commercial).isBool();
    }

  }

}