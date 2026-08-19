// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="FundCashForecast2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _VBdFudp-Ed-ak6NoX_4Aeg_386757279
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
///       SortingCriteriaDetails/ForecastBreakdownDetails/CashInForecastDetails/ExceptionalCashFlowIndicator
///       or
///       SortingCriteriaDetails/ForecastBreakdownDetails/CashOutForecastDetails/ExceptionalCashFlowIndicator,
///       or both, must be present.
///     </description>
///   </item>
/// </list>
/// Traced and confirmed enforceable: <see cref="CashSortingCriterion2"/>.ForecastBreakdownDetails
/// is <see cref="ForecastParameter2"/>, which has both <c>CashInForecastDetails</c>
/// (<see cref="CashInForecast1"/>) and <c>CashOutForecastDetails</c> (<see cref="CashOutForecast1"/>)
/// collections, and each element type carries its own nullable <c>ExceptionalCashFlowIndicator</c>.
///
/// Dependency injection: the <c>SortingCriteriaDetails</c> collection is validated per-item by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class FundCashForecast2Validator : AbstractValidator<FundCashForecast2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>SortingCriteriaDetails</c> collection's item type — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="sortingCriteriaDetailsValidator">
    /// Validator for each item of the <c>SortingCriteriaDetails</c> collection (CashSortingCriterion2, 1..∞).
    /// </param>
    public FundCashForecast2Validator(IValidator<CashSortingCriterion2> sortingCriteriaDetailsValidator)
    {
        // ── Cross-field constraints ───────────────────────────────────────────────

        RuleFor(x => x)
            .Must(x =>
                !x.ExceptionalNetCashFlowIndicator
                || x.SortingCriteriaDetails.Any(s =>
                    s.ForecastBreakdownDetails.Any(f =>
                        f.CashInForecastDetails.Any(c => c.ExceptionalCashFlowIndicator?.BoolValue == true)
                        || f.CashOutForecastDetails.Any(c => c.ExceptionalCashFlowIndicator?.BoolValue == true)
                    )
                )
            )
            .WithName("ExceptionalCashFlowIndicatorRule")
            .WithMessage(
                "If ExceptionalNetCashFlowIndicator is Yes, then either "
                    + "SortingCriteriaDetails/ForecastBreakdownDetails/CashInForecastDetails/ExceptionalCashFlowIndicator "
                    + "or .../CashOutForecastDetails/ExceptionalCashFlowIndicator, or both, must "
                    + "be present (ExceptionalCashFlowIndicatorRule)."
            );

        // ── Field-level rules ──────────────────────────────────────────────────────

        // TradeDateTime (DateAndDateTimeChoice, 1..1), FinancialInstrumentDetails
        // (FinancialInstrument5, 1..1), ExceptionalNetCashFlowIndicator (YesNoIndicator, 1..1):
        // required and already `required` C# properties — no rule needed.

        // PreviousTradeDateTime (DateAndDateTimeChoice, 0..1), TotalNAV, PreviousTotalNAV
        // (ActiveOrHistoricCurrencyAndAmount, 0..1), TotalUnitsNumber, PreviousTotalUnitsNumber
        // (FinancialInstrumentQuantity1, 0..1), TotalNAVChangeRate (PercentageRate, 0..1),
        // InvestmentCurrency (ActiveOrHistoricCurrencyCode, 0..∞), NetCashForecastDetails
        // (NetCashForecast1, 0..∞): no validator exists yet for these component fields; nested
        // fields unvalidated.

        // SortingCriteriaDetails: CashSortingCriterion2, 1..∞ — NotEmpty on the collection, plus
        // its own validator applied per item.
        RuleFor(x => x.SortingCriteriaDetails)
            .NotEmpty()
            .WithMessage("FundCashForecast2.SortingCriteriaDetails must contain at least one element (1..∞).");

        RuleForEach(x => x.SortingCriteriaDetails).SetValidator(sortingCriteriaDetailsValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>SortingCriteriaDetails</c>
    /// collection is validated by its own default validator
    /// (<see cref="CashSortingCriterion2Validator"/>). Convenience constructor for callers not
    /// using a DI container.
    /// </summary>
    public FundCashForecast2Validator()
        : this(new CashSortingCriterion2Validator()) { }
}
