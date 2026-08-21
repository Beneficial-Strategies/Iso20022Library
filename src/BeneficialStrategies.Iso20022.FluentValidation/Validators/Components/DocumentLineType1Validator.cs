// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DocumentLineType1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _cX4kMablEeKvUvwX_r3tzA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Specifies the type of the document line identification.
/// <list type="table">
///   <item><term>CodeOrProprietary</term><description>DocumentLineType1Choice_ — required (1..1)</description></item>
///   <item><term>Issuer</term><description>Max35Text — optional (0..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>CodeOrProprietary</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class DocumentLineType1Validator : AbstractValidator<DocumentLineType1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public DocumentLineType1Validator(IValidator<DocumentLineType1Choice_> codeOrProprietaryValidator)
    {
        RuleFor(x => x.CodeOrProprietary).SetValidator(codeOrProprietaryValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public DocumentLineType1Validator()
        : this(new DocumentLineType1Choice_Validator()) { }
}
