// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="BranchData5"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _v0bUQTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Information that locates and identifies a specific branch of a financial institution.
/// <list type="table">
///   <item><term>Identification</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>LEI</term><description>LEIIdentifier — optional (0..1)</description></item>
///   <item><term>Name</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>PostalAddress</term><description>PostalAddress27 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>PostalAddress</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class BranchData5Validator : AbstractValidator<BranchData5>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>PostalAddress</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="postalAddressValidator">
    /// Validator for the optional <c>PostalAddress</c> building block (PostalAddress27, 0..1) —
    /// only invoked when present.
    /// </param>
    public BranchData5Validator(IValidator<PostalAddress27> postalAddressValidator)
    {
        // Identification, LEI, Name: optional scalars, length/pattern enforced by struct
        // constructors — no rule needed.

        When(
            x => x.PostalAddress is not null,
            () => RuleFor(x => x.PostalAddress).SetValidator(postalAddressValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>PostalAddress</c> building
    /// block is validated by its own default validator (<see cref="PostalAddress27Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public BranchData5Validator()
        : this(new PostalAddress27Validator()) { }
}
