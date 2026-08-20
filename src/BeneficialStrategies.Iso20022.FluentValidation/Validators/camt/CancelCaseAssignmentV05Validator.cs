// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="CancelCaseAssignmentV05"/> (camt.032.001.05) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3Cc7zEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-19). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The CancelCaseAssignment message is sent by a case creator or case assigner to a case
/// assignee. This message is used to request the cancellation of a case.
///
/// Usage
/// The CancelCaseAssignment message is used to stop the processing of a case at a case assignee
/// when a case assignment is incorrect or when the root cause for the case disappears. It covers
/// one and only one case at a time — if several case assignments need to be cancelled, multiple
/// CancelCaseAssignment messages must be sent. It must not be used for other purposes (e.g. a
/// failed RequestToModifyPayment must be cancelled via CustomerPaymentCancellationRequest or
/// FIToFIPaymentCancellationRequest, not this message).
///
/// <list type="table">
///   <item><term>Assignment</term><description>CaseAssignment6 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case6 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>Assignment</c>, <c>Case</c>, and the <c>SupplementaryData</c>
/// collection are each validated by an injected <see cref="IValidator{T}"/> rather than a
/// hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class CancelCaseAssignmentV05Validator : AbstractValidator<CancelCaseAssignmentV05>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Assignment</c> and <c>Case</c> building blocks and for the
    /// <c>SupplementaryData</c> collection's item type — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="assignmentValidator">
    /// Validator for the required <c>Assignment</c> building block (CaseAssignment6, 1..1).
    /// </param>
    /// <param name="caseValidator">
    /// Validator for the required <c>Case</c> building block (Case6, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public CancelCaseAssignmentV05Validator(
        IValidator<CaseAssignment6> assignmentValidator,
        IValidator<Case6> caseValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.Assignment).SetValidator(assignmentValidator);
        RuleFor(x => x.Case).SetValidator(caseValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Assignment</c>, <c>Case</c>, and
    /// the <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="CaseAssignment6Validator"/>, <see cref="Case6Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public CancelCaseAssignmentV05Validator()
        : this(new CaseAssignment6Validator(), new Case6Validator(), new SupplementaryData1Validator()) { }
}
