// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TaxRecord3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _n9ZPV94lEeqt1ZcLzWyWFw
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Set of elements used to define the tax record.
/// <list type="table">
///   <item><term>Type</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Category</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>CategoryDetails</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>DebtorStatus</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>CertificateIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>FormsCode</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Period</term><description>TaxPeriod3 — optional (0..1)</description></item>
///   <item><term>TaxAmount</term><description>TaxAmount3 — optional (0..1)</description></item>
///   <item><term>AdditionalInformation</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Period</c> and <c>TaxAmount</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class TaxRecord3Validator : AbstractValidator<TaxRecord3>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public TaxRecord3Validator(
        IValidator<TaxPeriod3> periodValidator,
        IValidator<TaxAmount3> taxAmountValidator
    )
    {
        When(x => x.Period is not null, () => RuleFor(x => x.Period).SetValidator(periodValidator!));
        When(x => x.TaxAmount is not null, () => RuleFor(x => x.TaxAmount).SetValidator(taxAmountValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TaxRecord3Validator()
        : this(new TaxPeriod3Validator(), new TaxAmount3Validator()) { }
}
