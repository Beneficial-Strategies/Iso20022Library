// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TaxAmount3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _n-65U94lEeqt1ZcLzWyWFw
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Set of elements used to provide information on the tax amount(s) of tax record.
/// <list type="table">
///   <item><term>Rate</term><description>PercentageRate — optional (0..1), fully struct-enforced</description></item>
///   <item><term>TaxableBaseAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>TotalAmount</term><description>ActiveOrHistoricCurrencyAndAmount — optional (0..1), Amounts-namespace exemption</description></item>
///   <item><term>Details</term><description>TaxRecordDetails3 collection — optional (0..n)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Details</c> is validated by an injected <see cref="IValidator{T}"/>
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class TaxAmount3Validator : AbstractValidator<TaxAmount3>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public TaxAmount3Validator(IValidator<TaxRecordDetails3> detailsValidator)
    {
        RuleForEach(x => x.Details).SetValidator(detailsValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TaxAmount3Validator()
        : this(new TaxRecordDetails3Validator()) { }
}
