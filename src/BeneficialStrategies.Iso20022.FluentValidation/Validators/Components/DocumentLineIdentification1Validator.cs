// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DocumentLineIdentification1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _1QJJIabjEeKvUvwX_r3tzA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Identifies the documents referred to in the remittance information.
/// <list type="table">
///   <item><term>Type</term><description>DocumentLineType1 — optional (0..1)</description></item>
///   <item><term>Number</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
///   <item><term>RelatedDate</term><description>ISODate — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Type</c> is validated by an injected <see cref="IValidator{T}"/>
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class DocumentLineIdentification1Validator : AbstractValidator<DocumentLineIdentification1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public DocumentLineIdentification1Validator(IValidator<DocumentLineType1> typeValidator)
    {
        When(x => x.Type is not null, () => RuleFor(x => x.Type).SetValidator(typeValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public DocumentLineIdentification1Validator()
        : this(new DocumentLineType1Validator()) { }
}
