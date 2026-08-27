// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="FundDetailedConfirmedCashForecastReport1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Uu-Omtp-Ed-ak6NoX_4Aeg_1656814301
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
///
/// Dependency injection: the <c>FundCashForecastDetails</c> collection is validated per-item by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2016-09-08.")]
public class FundDetailedConfirmedCashForecastReport1Validator : AbstractValidator<FundDetailedConfirmedCashForecastReport1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>FundCashForecastDetails</c> collection's item type — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="fundCashForecastDetailsValidator">
    /// Validator for each item of the <c>FundCashForecastDetails</c> collection (FundCashForecast2, 1..∞).
    /// </param>
    public FundDetailedConfirmedCashForecastReport1Validator(
        IValidator<FundCashForecast2> fundCashForecastDetailsValidator
    )
    {
        // Extension: Extension1, 0..∞ — any size including empty is valid, no rule needed.

        // FundCashForecastDetails: FundCashForecast2, 1..∞ — NotEmpty on the collection, plus its
        // own validator applied per item.
        RuleFor(x => x.FundCashForecastDetails)
            .NotEmpty()
            .WithMessage(
                "FundDetailedConfirmedCashForecastReport1.FundCashForecastDetails must contain at least one element (1..∞)."
            );

        RuleForEach(x => x.FundCashForecastDetails).SetValidator(fundCashForecastDetailsValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>FundCashForecastDetails</c>
    /// collection is validated by its own default validator (<see cref="FundCashForecast2Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public FundDetailedConfirmedCashForecastReport1Validator()
        : this(new FundCashForecast2Validator()) { }
}
