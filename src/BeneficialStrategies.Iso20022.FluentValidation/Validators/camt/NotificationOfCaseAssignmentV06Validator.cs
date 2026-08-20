// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="NotificationOfCaseAssignmentV06"/> (camt.030.001.06) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3QfgTEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The NotificationOfCaseAssignment message is sent by a case assignee to a case creator/case
/// assigner. This message is used to inform the case assigner that the assignee is reassigning
/// the case to the next agent in the transaction processing chain for further action, or that the
/// assignee will work on the case himself without re-assigning it, indicating that the
/// re-assignment has reached its end-point.
///
/// Usage
/// The NotificationOfCaseAssignment message is used to notify the case creator or case assigner
/// of further action undertaken by the case assignee in a: request to cancel payment case;
/// request to modify payment case; unable to apply case; claim non receipt case. The message
/// covers one and only one case at a time (if the case assignee needs to inform a case creator or
/// case assigner about several cases, then multiple messages must be sent); except when used to
/// indicate that an agent is doing the correction himself, this message must be forwarded by all
/// subsequent case assigner(s) until it reaches the case creator; it must not be used in place of
/// a ResolutionOfInvestigation or a CaseStatusReport message. When the assignee does not reassign
/// the case to another party, the case assignment should contain the same case assignment
/// elements as received in the original query.
///
/// <list type="table">
///   <item><term>Header</term><description>ReportHeader7 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case6 — required (1..1)</description></item>
///   <item><term>Assignment</term><description>CaseAssignment6 — required (1..1)</description></item>
///   <item><term>Notification</term><description>CaseForwardingNotification3 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>Header</c>, <c>Case</c>, <c>Assignment</c>, <c>Notification</c>, and
/// the <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class NotificationOfCaseAssignmentV06Validator : AbstractValidator<NotificationOfCaseAssignmentV06>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for every required building block and for the <c>SupplementaryData</c> collection's item
    /// type — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="headerValidator">
    /// Validator for the required <c>Header</c> building block (ReportHeader7, 1..1).
    /// </param>
    /// <param name="caseValidator">
    /// Validator for the required <c>Case</c> building block (Case6, 1..1).
    /// </param>
    /// <param name="assignmentValidator">
    /// Validator for the required <c>Assignment</c> building block (CaseAssignment6, 1..1).
    /// </param>
    /// <param name="notificationValidator">
    /// Validator for the required <c>Notification</c> building block
    /// (CaseForwardingNotification3, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public NotificationOfCaseAssignmentV06Validator(
        IValidator<ReportHeader7> headerValidator,
        IValidator<Case6> caseValidator,
        IValidator<CaseAssignment6> assignmentValidator,
        IValidator<CaseForwardingNotification3> notificationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.Header).SetValidator(headerValidator);
        RuleFor(x => x.Case).SetValidator(caseValidator);
        RuleFor(x => x.Assignment).SetValidator(assignmentValidator);
        RuleFor(x => x.Notification).SetValidator(notificationValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every required building block and
    /// the <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="ReportHeader7Validator"/>, <see cref="Case6Validator"/>,
    /// <see cref="CaseAssignment6Validator"/>, <see cref="CaseForwardingNotification3Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public NotificationOfCaseAssignmentV06Validator()
        : this(
            new ReportHeader7Validator(),
            new Case6Validator(),
            new CaseAssignment6Validator(),
            new CaseForwardingNotification3Validator(),
            new SupplementaryData1Validator()
        ) { }
}
