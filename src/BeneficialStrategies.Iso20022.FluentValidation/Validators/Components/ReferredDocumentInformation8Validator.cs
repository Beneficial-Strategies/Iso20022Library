// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ReferredDocumentInformation8"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _OzVnATE0Ee62xuUQ2zyZww
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides the identification and the content of the referred document.
/// <list type="table">
///   <item><term>LineDetails</term><description>DocumentLineInformation2 collection — optional (0..n)</description></item>
///   <item><term>Number</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>RelatedDate</term><description>DateAndType1 — optional (0..1)</description></item>
///   <item><term>Type</term><description>DocumentType1 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>LineDetails</c>, <c>RelatedDate</c>, and <c>Type</c> are each
/// validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see
/// the two constructors below.
/// </remarks>
public class ReferredDocumentInformation8Validator : AbstractValidator<ReferredDocumentInformation8>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public ReferredDocumentInformation8Validator(
        IValidator<DocumentLineInformation2> lineDetailsValidator,
        IValidator<DateAndType1> relatedDateValidator,
        IValidator<DocumentType1> typeValidator
    )
    {
        RuleForEach(x => x.LineDetails).SetValidator(lineDetailsValidator!);
        When(x => x.RelatedDate is not null, () => RuleFor(x => x.RelatedDate).SetValidator(relatedDateValidator!));
        When(x => x.Type is not null, () => RuleFor(x => x.Type).SetValidator(typeValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public ReferredDocumentInformation8Validator()
        : this(new DocumentLineInformation2Validator(), new DateAndType1Validator(), new DocumentType1Validator()) { }
}
