// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="RequestForDuplicateV07"/> (camt.033.001.07) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3SU1zEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-19). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The RequestForDuplicate message is sent by the case assignee to the case creator or case
/// assigner. This message is used to request a copy of the original payment instruction
/// considered in the case.
///
/// Usage
/// The RequestForDuplicate message must be answered with a Duplicate message; must be used when a
/// case assignee requests a copy of the original payment instruction (e.g. it cannot trace the
/// payment instruction from the elements in the case assignment message); covers one and only one
/// instruction at a time — if several copies are needed, multiple RequestForDuplicate messages
/// must be sent; and must be used exclusively between the case assignee and its case
/// creator/case assigner.
///
/// <list type="table">
///   <item><term>Assignment</term><description>CaseAssignment6 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case6 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>Assignment</c>, the optional <c>Case</c> building block, and the
/// <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class RequestForDuplicateV07Validator : AbstractValidator<RequestForDuplicateV07>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Assignment</c> building block, the optional <c>Case</c> building
    /// block, and the <c>SupplementaryData</c> collection's item type — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="assignmentValidator">
    /// Validator for the required <c>Assignment</c> building block (CaseAssignment6, 1..1).
    /// </param>
    /// <param name="caseValidator">
    /// Validator for the optional <c>Case</c> building block (Case6, 0..1) — only invoked when
    /// present.
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public RequestForDuplicateV07Validator(
        IValidator<CaseAssignment6> assignmentValidator,
        IValidator<Case6> caseValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.Assignment).SetValidator(assignmentValidator);

        When(x => x.Case is not null, () => RuleFor(x => x.Case).SetValidator(caseValidator!));

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Assignment</c>, <c>Case</c>, and
    /// the <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="CaseAssignment6Validator"/>, <see cref="Case6Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public RequestForDuplicateV07Validator()
        : this(new CaseAssignment6Validator(), new Case6Validator(), new SupplementaryData1Validator()) { }
}
