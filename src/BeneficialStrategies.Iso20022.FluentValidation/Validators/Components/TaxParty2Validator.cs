// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="TaxParty2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _PdBMwdp-Ed-ak6NoX_4Aeg_920823246
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Details about the entity involved in the tax paid or to be paid.
/// <list type="table">
///   <item><term>TaxIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>RegistrationIdentification</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>TaxType</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Authorisation</term><description>TaxAuthorisation1 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Authorisation</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class TaxParty2Validator : AbstractValidator<TaxParty2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public TaxParty2Validator(IValidator<TaxAuthorisation1> authorisationValidator)
    {
        When(
            x => x.Authorisation is not null,
            () => RuleFor(x => x.Authorisation).SetValidator(authorisationValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public TaxParty2Validator()
        : this(new TaxAuthorisation1Validator()) { }
}
