// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CreditorReferenceType3"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _7xH-hTEsEe6GxLzpkVnWYg
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Specifies the type of creditor reference.
/// <list type="table">
///   <item><term>CodeOrProprietary</term><description>CreditorReferenceType2Choice_ — required (1..1)</description></item>
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
public class CreditorReferenceType3Validator : AbstractValidator<CreditorReferenceType3>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator —
    /// e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public CreditorReferenceType3Validator(IValidator<CreditorReferenceType2Choice_> codeOrProprietaryValidator)
    {
        RuleFor(x => x.CodeOrProprietary).SetValidator(codeOrProprietaryValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public CreditorReferenceType3Validator()
        : this(new CreditorReferenceType2Choice_Validator()) { }
}
