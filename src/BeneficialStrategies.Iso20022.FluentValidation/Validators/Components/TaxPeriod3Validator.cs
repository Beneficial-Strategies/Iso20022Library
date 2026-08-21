// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TaxPeriod3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _oB4Gpd4lEeqt1ZcLzWyWFw
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Period of time details related to the tax payment.
/// <list type="table">
///   <item><term>Year</term><description>ISOYear — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Type</term><description>TaxRecordPeriod1Code — optional (0..1), closed enum, fully enforced</description></item>
///   <item><term>FromToDate</term><description>DatePeriod2 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>FromToDate</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class TaxPeriod3Validator : AbstractValidator<TaxPeriod3>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public TaxPeriod3Validator(IValidator<DatePeriod2> fromToDateValidator)
    {
        When(x => x.FromToDate is not null, () => RuleFor(x => x.FromToDate).SetValidator(fromToDateValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TaxPeriod3Validator()
        : this(new DatePeriod2Validator()) { }
}
