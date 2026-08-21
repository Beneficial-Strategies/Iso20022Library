// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="RegulatoryAuthority2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _Pc3bxNp-Ed-ak6NoX_4Aeg_-1526379440
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Entity requiring the regulatory reporting information.
/// <list type="table">
///   <item><term>Name</term><description>Max140Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Country</term><description>CountryCode — optional (0..1) — checked against an injected <see cref="IExternalCodeRegistry{TCode}"/> via <see cref="CountryCodeValidator"/></description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Country</c> is validated by an injected <see cref="IValidator{T}"/>
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class RegulatoryAuthority2Validator : AbstractValidator<RegulatoryAuthority2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public RegulatoryAuthority2Validator(IValidator<CountryCode> countryValidator)
    {
        When(
            x => x.Country is not null,
            () => RuleFor(x => x.Country!.Value).SetValidator(countryValidator)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public RegulatoryAuthority2Validator()
        : this(new CountryCodeValidator()) { }
}
