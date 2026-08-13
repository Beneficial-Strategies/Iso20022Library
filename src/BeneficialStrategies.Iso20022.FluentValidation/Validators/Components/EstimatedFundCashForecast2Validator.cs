// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="EstimatedFundCashForecast2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _VCWdldp-Ed-ak6NoX_4Aeg_-373893977
/// Spec source: queried via ISO 20022 MCP server (2026-08-13).
/// Multiplicity enforced at runtime (the C# model's ValueList&lt;T&gt;/SimpleValueList&lt;T&gt;
/// has no compile-time bound in either direction):
/// <list type="table">
///   <item><term>SortingCriteriaDetails</term><description>Min=1</description></item>
/// </list>
/// See docs/multiplicity-audit-2026-08.md.
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>ExceptionalCashFlowIndicatorRule</term>
///     <description>
///       If ExceptionalNetCashFlowIndicator is "true" or "1" (Yes), then either
///       SortingCriteriaDetails/ForecastBreakdownDetails/EstimatedCashInForecastDetails/ExceptionalCashFlowIndicator
///       or
///       SortingCriteriaDetails/ForecastBreakdownDetails/EstimatedCashOutForecastDetails/ExceptionalCashFlowIndicator,
///       or both, must be present.
///     </description>
///   </item>
/// </list>
/// Traced and confirmed enforceable: <see cref="CashSortingCriterion1"/>.ForecastBreakdownDetails
/// is <see cref="ForecastParameter1"/>, which has both
/// <c>EstimatedCashInForecastDetails</c> (<see cref="CashInForecast1"/>) and
/// <c>EstimatedCashOutForecastDetails</c> (<see cref="CashOutForecast1"/>) collections, and each
/// element type carries its own nullable <c>ExceptionalCashFlowIndicator</c>.
/// </remarks>
public sealed class EstimatedFundCashForecast2Validator : AbstractValidator<EstimatedFundCashForecast2>
{
    public EstimatedFundCashForecast2Validator()
    {
        // ── Cross-field constraints ───────────────────────────────────────────────

        RuleFor(x => x)
            .Must(x =>
                !x.ExceptionalNetCashFlowIndicator
                || x.SortingCriteriaDetails.Any(s =>
                    s.ForecastBreakdownDetails.Any(f =>
                        f.EstimatedCashInForecastDetails.Any(c => c.ExceptionalCashFlowIndicator?.BoolValue == true)
                        || f.EstimatedCashOutForecastDetails.Any(c => c.ExceptionalCashFlowIndicator?.BoolValue == true)
                    )
                )
            )
            .WithName("ExceptionalCashFlowIndicatorRule")
            .WithMessage(
                "If ExceptionalNetCashFlowIndicator is Yes, then either "
                    + "SortingCriteriaDetails/ForecastBreakdownDetails/EstimatedCashInForecastDetails/ExceptionalCashFlowIndicator "
                    + "or .../EstimatedCashOutForecastDetails/ExceptionalCashFlowIndicator, or both, "
                    + "must be present (ExceptionalCashFlowIndicatorRule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // TradeDateTime, PreviousTradeDateTime (DateAndDateTimeChoice, 1..1),
        // FinancialInstrumentDetails (FinancialInstrument5, 1..1), ExceptionalNetCashFlowIndicator
        // (YesNoIndicator, 1..1): required and already `required` C# properties — no rule
        // needed.

        // EstimatedTotalNAV, PreviousEstimatedTotalNAV (ActiveOrHistoricCurrencyAndAmount, 0..1),
        // EstimatedTotalUnitsNumber, PreviousEstimatedTotalUnitsNumber
        // (FinancialInstrumentQuantity1, 0..1), EstimatedTotalNAVChangeRate (PercentageRate,
        // 0..1), InvestmentCurrency (ActiveOrHistoricCurrencyCode, 0..∞),
        // EstimatedNetCashForecastDetails (NetCashForecast1, 0..∞): no validator exists yet for
        // these component fields; nested fields unvalidated.

        // SortingCriteriaDetails: CashSortingCriterion1, 1..∞ — NEEDS NotEmpty RULE.
        RuleFor(x => x.SortingCriteriaDetails)
            .NotEmpty()
            .WithMessage(
                "EstimatedFundCashForecast2.SortingCriteriaDetails must contain at least one element (1..∞)."
            );
    }
}
