// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="NameAndAddress18"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _0MzpxzEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Information that locates and identifies a party.
/// <list type="table">
///   <item><term>Address</term><description>PostalAddress27 — required (1..1)</description></item>
///   <item><term>Name</term><description>Max140Text — required (1..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Address</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
///
/// Known test-coverage gap (2026-08-21): <see cref="PostalAddress27"/> has no required
/// sub-fields and its own validator applies rules only conditionally on fields that are
/// present — this is correct per spec, not a defect (confirmed against the published ISO 20022
/// schema: there is no constraint requiring any address sub-field to be populated). But it means
/// the test suite's happy-path case (an all-default <c>PostalAddress27</c>) produces zero
/// validation errors whether or not the <c>RuleFor(x => x.Address).SetValidator(...)</c> line
/// below is actually present — the test does not prove this dependency is wired. A future pass
/// should add a case that populates <c>Address.Country</c> with a value rejected by a populated
/// <see cref="IExternalCodeRegistry{TCode}"/> to close this gap.
/// </remarks>
public class NameAndAddress18Validator : AbstractValidator<NameAndAddress18>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public NameAndAddress18Validator(IValidator<PostalAddress27> addressValidator)
    {
        RuleFor(x => x.Address).SetValidator(addressValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public NameAndAddress18Validator()
        : this(new PostalAddress27Validator()) { }
}
