// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="FinancialInstitutionIdentification23"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _v2tzSTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Specifies the details to identify a financial institution.
/// <list type="table">
///   <item><term>BICFI</term><description>BICFIDec2014Identifier — optional (0..1)</description></item>
///   <item><term>ClearingSystemMemberIdentification</term><description>ClearingSystemMemberIdentification2 — optional (0..1)</description></item>
///   <item><term>LEI</term><description>LEIIdentifier — optional (0..1)</description></item>
///   <item><term>Name</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>Other</term><description>GenericFinancialIdentification1 — optional (0..1)</description></item>
///   <item><term>PostalAddress</term><description>PostalAddress27 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>ClearingSystemMemberIdentification</c>, <c>Other</c>, and
/// <c>PostalAddress</c> are each validated by an injected <see cref="IValidator{T}"/> rather than
/// a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class FinancialInstitutionIdentification23Validator
    : AbstractValidator<FinancialInstitutionIdentification23>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>ClearingSystemMemberIdentification</c>, <c>Other</c>, and
    /// <c>PostalAddress</c> building blocks — e.g. resolved from a DI container — instead of this
    /// type constructing its own.
    /// </summary>
    /// <param name="clearingSystemMemberIdentificationValidator">
    /// Validator for the optional <c>ClearingSystemMemberIdentification</c> building block
    /// (ClearingSystemMemberIdentification2, 0..1) — only invoked when present.
    /// </param>
    /// <param name="otherValidator">
    /// Validator for the optional <c>Other</c> building block (GenericFinancialIdentification1,
    /// 0..1) — only invoked when present.
    /// </param>
    /// <param name="postalAddressValidator">
    /// Validator for the optional <c>PostalAddress</c> building block (PostalAddress27, 0..1) —
    /// only invoked when present.
    /// </param>
    public FinancialInstitutionIdentification23Validator(
        IValidator<ClearingSystemMemberIdentification2> clearingSystemMemberIdentificationValidator,
        IValidator<GenericFinancialIdentification1> otherValidator,
        IValidator<PostalAddress27> postalAddressValidator
    )
    {
        // BICFI, LEI, Name: optional scalars, length/pattern enforced by struct constructors —
        // no rule needed.

        When(
            x => x.ClearingSystemMemberIdentification is not null,
            () =>
                RuleFor(x => x.ClearingSystemMemberIdentification)
                    .SetValidator(clearingSystemMemberIdentificationValidator!)
        );

        When(x => x.Other is not null, () => RuleFor(x => x.Other).SetValidator(otherValidator!));

        When(
            x => x.PostalAddress is not null,
            () => RuleFor(x => x.PostalAddress).SetValidator(postalAddressValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>ClearingSystemMemberIdentification</c>,
    /// <c>Other</c>, and <c>PostalAddress</c> are each validated by their own default validator
    /// (<see cref="ClearingSystemMemberIdentification2Validator"/>,
    /// <see cref="GenericFinancialIdentification1Validator"/>, <see cref="PostalAddress27Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public FinancialInstitutionIdentification23Validator()
        : this(
            new ClearingSystemMemberIdentification2Validator(),
            new GenericFinancialIdentification1Validator(),
            new PostalAddress27Validator()
        ) { }
}
