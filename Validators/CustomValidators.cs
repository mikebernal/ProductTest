using System.Text.RegularExpressions;
using FluentValidation;

namespace ProductTest.Validators {
    public static class CustomValidators {
        public static IRuleBuilderOptions<T, bool?> isBool<T>(this IRuleBuilder<T, bool?> ruleBuilder) {
            return ruleBuilder.Must(x => x == false || x == true).WithMessage("Value must be boolean.");
        }
        public static IRuleBuilderOptions<T, string> NotStartWithWhiteSpace<T>(this IRuleBuilder<T, string> ruleBuilder) {
            return ruleBuilder.Must(m => m != null && !m.StartsWith(" ")).WithMessage("'{PropertyName}' should not start with whitespace");
        }
        public static IRuleBuilderOptions<T, string> NotEndWithWhiteSpace<T>(this IRuleBuilder<T, string> ruleBuilder) {
            return ruleBuilder.Must(m => m != null && !m.EndsWith(" ")).WithMessage("'{PropertyName}' should not end with whitespace");
        }
        public static IRuleBuilderOptions<T, string> isInvalidFileName<T>(this IRuleBuilder<T, string> ruleBuilder) {
            return ruleBuilder.Matches("/&https?://[^\\/:*?\"<>|].(jpg|jpeg|png)$/ig").WithMessage("\\/:*?\"<>| characters are not allowed in using the filename");
        }
        public static IRuleBuilderOptions<T, string> isValidSpeed<T>(this IRuleBuilder<T, string> ruleBuilder) {
            return ruleBuilder.Matches("(?i)[jklmnpqrstuhvwxy]").WithMessage("Speed symbols must be one of the following: [J, K, L, M, N, P, Q, R, S, T, U, H, V, W, X, Y, VR, ZR] case insensitive.");
        }
    }
}