// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="OrganisationIdentification39"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _bKD8BTFIEe651u5xu3f5iw
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Unique and unambiguous way to identify an organisation.
/// <list type="table">
///   <item><term>AnyBIC</term><description>AnyBICDec2014Identifier — optional (0..1)</description></item>
///   <item><term>LEI</term><description>LEIIdentifier — optional (0..1)</description></item>
///   <item><term>Other</term><description>GenericOrganisationIdentification3 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Other</c> collection is validated per-item by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class OrganisationIdentification39Validator : AbstractValidator<OrganisationIdentification39>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the <c>Other</c> collection's item type — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="otherValidator">
    /// Validator for each item of the <c>Other</c> collection (GenericOrganisationIdentification3,
    /// 0..∞).
    /// </param>
    public OrganisationIdentification39Validator(
        IValidator<GenericOrganisationIdentification3> otherValidator
    )
    {
        // AnyBIC, LEI: optional scalars, format/length enforced by struct constructors — no rule
        // needed.

        RuleForEach(x => x.Other).SetValidator(otherValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Other</c> collection is
    /// validated by its own default validator
    /// (<see cref="GenericOrganisationIdentification3Validator"/>). Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public OrganisationIdentification39Validator()
        : this(new GenericOrganisationIdentification3Validator()) { }
}
