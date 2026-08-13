// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="FundDetailedConfirmedCashForecastReport3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _HSgygQatEeS3lpTattq7hg
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>FundCashForecastDetails</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// No cross-field constraints found for this component (no "constraint" declaration rows
/// under its ISO dictionary entry).
/// </remarks>
public sealed class FundDetailedConfirmedCashForecastReport3Validator
    : AbstractValidator<FundDetailedConfirmedCashForecastReport3>
{
    public FundDetailedConfirmedCashForecastReport3Validator()
    {
        // FundOrSubFundDetails (Fund4, 0..1), ConsolidatedNetCashForecast (NetCashForecast3,
        // 0..1): no validator exists yet; nested fields unvalidated.
        // Extension: Extension1, 0..∞ — any size including empty is valid, no rule needed.

        // FundCashForecastDetails: FundCashForecast6, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.FundCashForecastDetails)
            .NotEmpty()
            .WithMessage(
                "FundDetailedConfirmedCashForecastReport3.FundCashForecastDetails must contain at least one element (1..∞)."
            );
    }
}
