// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TaxRecordDetails3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _oAWcqd4lEeqt1ZcLzWyWFw
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides information on the individual tax amount(s) per period of the tax record.
/// <list type="table">
///   <item><term>Period</term><description>TaxPeriod3 — optional (0..1)</description></item>
///   <item><term>Amount</term><description>ActiveOrHistoricCurrencyAndAmount — required (1..1), Amounts-namespace exemption (see <see cref="AmountType4Choice_Validator"/>'s own remarks)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Period</c> is validated by an injected <see cref="IValidator{T}"/>
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class TaxRecordDetails3Validator : AbstractValidator<TaxRecordDetails3>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public TaxRecordDetails3Validator(IValidator<TaxPeriod3> periodValidator)
    {
        When(x => x.Period is not null, () => RuleFor(x => x.Period).SetValidator(periodValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TaxRecordDetails3Validator()
        : this(new TaxPeriod3Validator()) { }
}
