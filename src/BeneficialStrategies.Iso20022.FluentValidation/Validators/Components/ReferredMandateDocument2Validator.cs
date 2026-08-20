// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ReferredMandateDocument2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _O661sTE0Ee62xuUQ2zyZww
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Identifies the documents referred to in the remittance information.
/// <list type="table">
///   <item><term>Type</term><description>DocumentType1 — optional (0..1)</description></item>
///   <item><term>Number</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>CreditorReference</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>RelatedDate</term><description>DateAndType1 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>RelatedDate</c> and <c>Type</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class ReferredMandateDocument2Validator : AbstractValidator<ReferredMandateDocument2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>RelatedDate</c> and <c>Type</c> building blocks — e.g. resolved from a
    /// DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="relatedDateValidator">
    /// Validator for the optional <c>RelatedDate</c> building block (DateAndType1, 0..1) — only
    /// invoked when present.
    /// </param>
    /// <param name="typeValidator">
    /// Validator for the optional <c>Type</c> building block (DocumentType1, 0..1) — only
    /// invoked when present.
    /// </param>
    public ReferredMandateDocument2Validator(
        IValidator<DateAndType1> relatedDateValidator,
        IValidator<DocumentType1> typeValidator
    )
    {
        // Number, CreditorReference: optional scalars, length enforced by struct constructors —
        // no rule needed.

        When(
            x => x.RelatedDate is not null,
            () => RuleFor(x => x.RelatedDate).SetValidator(relatedDateValidator!)
        );

        When(x => x.Type is not null, () => RuleFor(x => x.Type).SetValidator(typeValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>RelatedDate</c> and <c>Type</c>
    /// are each validated by their own default validator (<see cref="DateAndType1Validator"/>,
    /// <see cref="DocumentType1Validator"/>). Convenience constructor for callers not using a DI
    /// container.
    /// </summary>
    public ReferredMandateDocument2Validator()
        : this(new DateAndType1Validator(), new DocumentType1Validator()) { }
}
