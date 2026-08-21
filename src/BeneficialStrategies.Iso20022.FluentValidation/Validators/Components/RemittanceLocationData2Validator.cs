// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="RemittanceLocationData2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _0KjnBTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Provides additional details on the remittance advice.
/// <list type="table">
///   <item><term>ElectronicAddress</term><description>Max2048Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Method</term><description>RemittanceLocationMethod2Code — required (1..1), closed enum, fully enforced</description></item>
///   <item><term>PostalAddress</term><description>NameAndAddress18 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>PostalAddress</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
///
/// Known test-coverage gap (2026-08-21): the test suite's happy-path case does not populate
/// <c>PostalAddress</c> at all, so the <see cref="NameAndAddress18Validator"/> wiring below is
/// unproven — see that type's own remarks for the underlying reason (an all-default
/// <see cref="PostalAddress27"/> has nothing to violate regardless of wiring, which is correct
/// per spec, not a defect).
/// </remarks>
public class RemittanceLocationData2Validator : AbstractValidator<RemittanceLocationData2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public RemittanceLocationData2Validator(IValidator<NameAndAddress18> postalAddressValidator)
    {
        When(
            x => x.PostalAddress is not null,
            () => RuleFor(x => x.PostalAddress).SetValidator(postalAddressValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public RemittanceLocationData2Validator()
        : this(new NameAndAddress18Validator()) { }
}
