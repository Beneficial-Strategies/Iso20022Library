// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="CaseAssignment6"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _voTj0DEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-19).
///
/// Represents the assignment of a case to a party.
/// <list type="table">
///   <item><term>Identification</term><description>Max35Text — required (1..1)</description></item>
///   <item><term>Assigner</term><description>Party50Choice_ — required (1..1)</description></item>
///   <item><term>Assignee</term><description>Party50Choice_ — required (1..1)</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Assigner</c> and <c>Assignee</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below. Both properties share the same validated type, so one injected validator serves both.
/// </remarks>
public class CaseAssignment6Validator : AbstractValidator<CaseAssignment6>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Assigner</c>/<c>Assignee</c> building blocks — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="partyValidator">
    /// Validator for the required <c>Assigner</c> and <c>Assignee</c> building blocks (both
    /// Party50Choice_, 1..1).
    /// </param>
    public CaseAssignment6Validator(IValidator<Party50Choice_> partyValidator)
    {
        // Identification, CreationDateTime: required (1..1) and already `required` C#
        // properties — length/format enforced by struct constructors.

        RuleFor(x => x.Assigner).SetValidator(partyValidator);
        RuleFor(x => x.Assignee).SetValidator(partyValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Assigner</c> and <c>Assignee</c>
    /// are each validated by their own default validator (<see cref="Party50Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public CaseAssignment6Validator()
        : this(new Party50Choice_Validator()) { }
}
