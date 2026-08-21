// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DocumentLineInformation2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _eZxMgTE4Ee62xuUQ2zyZww
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides document line information.
/// <list type="table">
///   <item><term>Amount</term><description>RemittanceAmount4 — optional (0..1)</description></item>
///   <item><term>Description</term><description>Max2048Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>Identification</term><description>DocumentLineIdentification1 collection — required, min 1 (1..n)</description></item>
/// </list>
///
/// Known model defect: <c>Identification</c> is <c>ValueList&lt;T&gt; = []</c>, which allows an
/// empty collection at the C# level even though the spec requires Min=1..&#8734;. Enforced here via
/// an explicit <c>NotEmpty</c> rule (see docs/multiplicity-audit-2026-08.md and
/// docs/multiplicity-defect2-2026-08.tsv for the tracked defect).
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Amount</c> and <c>Identification</c> are each validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below. (Upgraded 2026-08-21 from an earlier abbreviated version that only
/// enforced the multiplicity gap above — <see cref="RemittanceAmount4Validator"/> and
/// <see cref="DocumentLineIdentification1Validator"/> did not exist yet at that time.)
/// </remarks>
public class DocumentLineInformation2Validator : AbstractValidator<DocumentLineInformation2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public DocumentLineInformation2Validator(
        IValidator<RemittanceAmount4> amountValidator,
        IValidator<DocumentLineIdentification1> identificationValidator
    )
    {
        When(x => x.Amount is not null, () => RuleFor(x => x.Amount).SetValidator(amountValidator!));

        RuleFor(x => x.Identification)
            .NotEmpty()
            .WithMessage("DocumentLineInformation2.Identification must contain at least one element (1..∞).");
        RuleForEach(x => x.Identification).SetValidator(identificationValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public DocumentLineInformation2Validator()
        : this(new RemittanceAmount4Validator(), new DocumentLineIdentification1Validator()) { }
}
