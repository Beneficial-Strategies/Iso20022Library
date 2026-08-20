// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="Case6"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _w5_1MTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Provides further details to identify an investigation case.
/// <list type="table">
///   <item><term>Identification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>Creator</term><description>Party50Choice_ — required (1..1)</description></item>
///   <item><term>ReopenCaseIndication</term><description>YesNoIndicator — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Creator</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class Case6Validator : AbstractValidator<Case6>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Creator</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="creatorValidator">
    /// Validator for the required <c>Creator</c> building block (Party50Choice_, 1..1).
    /// </param>
    public Case6Validator(IValidator<Party50Choice_> creatorValidator)
    {
        // Identification: Max35Text, required (1..1) and already `required` C# property — length
        // [1..35] enforced by struct constructor.
        // ReopenCaseIndication: YesNoIndicator, optional — no additional constraint beyond the
        // type itself.

        RuleFor(x => x.Creator).SetValidator(creatorValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Creator</c> building block
    /// is validated by its own default validator (<see cref="Party50Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public Case6Validator()
        : this(new Party50Choice_Validator()) { }
}
