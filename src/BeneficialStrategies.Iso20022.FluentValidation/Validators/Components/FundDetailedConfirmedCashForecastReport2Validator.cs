// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="FundDetailedConfirmedCashForecastReport2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _RPmku9p-Ed-ak6NoX_4Aeg_-256800213
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
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2016-09-08.")]
public class FundDetailedConfirmedCashForecastReport2Validator : AbstractValidator<FundDetailedConfirmedCashForecastReport2>
{
    /// <summary>
    /// Initializes a new instance of the validator for <see cref="FundDetailedConfirmedCashForecastReport2"/>.
    /// </summary>
    public FundDetailedConfirmedCashForecastReport2Validator()
    {
        // ConsolidatedNetCashForecast (NetCashForecast3, 0..1): no validator exists yet; nested
        // fields unvalidated.
        // Extension: Extension1, 0..∞ — any size including empty is valid, no rule needed.

        // FundCashForecastDetails: FundCashForecast4, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.FundCashForecastDetails)
            .NotEmpty()
            .WithMessage(
                "FundDetailedConfirmedCashForecastReport2.FundCashForecastDetails must contain at least one element (1..∞)."
            );
    }
}
