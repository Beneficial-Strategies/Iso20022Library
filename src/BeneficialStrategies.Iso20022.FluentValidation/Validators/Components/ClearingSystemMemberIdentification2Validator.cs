// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ClearingSystemMemberIdentification2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _TMehHNp-Ed-ak6NoX_4Aeg_151445359
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Unique identification, as assigned by a clearing system, to unambiguously identify a member of
/// the clearing system.
/// <list type="table">
///   <item><term>ClearingSystemIdentification</term><description>ClearingSystemIdentification2Choice_ — optional (0..1)</description></item>
///   <item><term>MemberIdentification</term><description>Max35Text — required (1..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>ClearingSystemIdentification</c> building block is validated by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class ClearingSystemMemberIdentification2Validator
    : AbstractValidator<ClearingSystemMemberIdentification2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>ClearingSystemIdentification</c> building block — e.g. resolved from a
    /// DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="clearingSystemIdentificationValidator">
    /// Validator for the optional <c>ClearingSystemIdentification</c> building block
    /// (ClearingSystemIdentification2Choice_, 0..1) — only invoked when present.
    /// </param>
    public ClearingSystemMemberIdentification2Validator(
        IValidator<ClearingSystemIdentification2Choice_> clearingSystemIdentificationValidator
    )
    {
        // MemberIdentification: Max35Text, required (1..1) and already `required` C# property —
        // length [1..35] enforced by struct constructor.

        When(
            x => x.ClearingSystemIdentification is not null,
            () =>
                RuleFor(x => x.ClearingSystemIdentification)
                    .SetValidator(clearingSystemIdentificationValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the
    /// <c>ClearingSystemIdentification</c> building block is validated by its own default
    /// validator (<see cref="ClearingSystemIdentification2Choice_Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public ClearingSystemMemberIdentification2Validator()
        : this(new ClearingSystemIdentification2Choice_Validator()) { }
}
