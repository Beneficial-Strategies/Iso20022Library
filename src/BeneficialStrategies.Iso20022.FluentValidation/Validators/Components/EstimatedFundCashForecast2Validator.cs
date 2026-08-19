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
///
/// Dependency injection: the <c>SortingCriteriaDetails</c> collection is validated per-item by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class EstimatedFundCashForecast2Validator : AbstractValidator<EstimatedFundCashForecast2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>SortingCriteriaDetails</c> collection's item type — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="sortingCriteriaDetailsValidator">
    /// Validator for each item of the <c>SortingCriteriaDetails</c> collection (CashSortingCriterion1, 1..∞).
    /// </param>
    public EstimatedFundCashForecast2Validator(
        IValidator<CashSortingCriterion1> sortingCriteriaDetailsValidator
    )
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

        // SortingCriteriaDetails: CashSortingCriterion1, 1..∞ — NotEmpty on the collection, plus
        // its own validator applied per item.
        RuleFor(x => x.SortingCriteriaDetails)
            .NotEmpty()
            .WithMessage(
                "EstimatedFundCashForecast2.SortingCriteriaDetails must contain at least one element (1..∞)."
            );

        RuleForEach(x => x.SortingCriteriaDetails).SetValidator(sortingCriteriaDetailsValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>SortingCriteriaDetails</c>
    /// collection is validated by its own default validator
    /// (<see cref="CashSortingCriterion1Validator"/>). Convenience constructor for callers not
    /// using a DI container.
    /// </summary>
    public EstimatedFundCashForecast2Validator()
        : this(new CashSortingCriterion1Validator()) { }
}
