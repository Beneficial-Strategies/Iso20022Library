// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="DocumentType1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _O2EK4TE0Ee62xuUQ2zyZww
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the type of the document referred in the remittance information.
/// <list type="table">
///   <item><term>CodeOrProprietary</term><description>DocumentType2Choice_ — required (1..1)</description></item>
///   <item><term>Issuer</term><description>Max35Text — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>CodeOrProprietary</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class DocumentType1Validator : AbstractValidator<DocumentType1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>CodeOrProprietary</c> building block — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="codeOrProprietaryValidator">
    /// Validator for the required <c>CodeOrProprietary</c> building block (DocumentType2Choice_,
    /// 1..1).
    /// </param>
    public DocumentType1Validator(IValidator<DocumentType2Choice_> codeOrProprietaryValidator)
    {
        // Issuer: Max35Text, optional — length [1..35] enforced by struct constructor.

        RuleFor(x => x.CodeOrProprietary).SetValidator(codeOrProprietaryValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>CodeOrProprietary</c>
    /// building block is validated by its own default validator
    /// (<see cref="DocumentType2Choice_Validator"/>). Convenience constructor for callers not
    /// using a DI container.
    /// </summary>
    public DocumentType1Validator()
        : this(new DocumentType2Choice_Validator()) { }
}
