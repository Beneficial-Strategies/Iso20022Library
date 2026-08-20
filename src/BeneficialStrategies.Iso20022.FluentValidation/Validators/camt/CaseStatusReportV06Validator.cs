// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="CaseStatusReportV06"/> (camt.039.001.06) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3CdHTEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The CaseStatusReport message is sent by a case assignee to a case creator or case assigner.
/// This message is used to report on the status of a case.
///
/// Usage
/// A CaseStatusReport message is sent in reply to a CaseStatusReportRequest message. This message
/// covers one and only one case at a time (if a case assignee needs to report on several cases,
/// then multiple CaseStatusReport messages must be sent); may be forwarded to subsequent case
/// assigner(s) until it reaches the end point; is able to indicate the fact that a case has been
/// assigned to a party downstream in the payment processing chain; may not be used in place of a
/// ResolutionOfInvestigation (except when the request for a status is received at the time the
/// assigner has already resolved the case — a ResolutionOfInvestigation may be sent instead) or
/// NotificationOfCaseAssignment message.
///
/// <list type="table">
///   <item><term>Header</term><description>ReportHeader7 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case6 — required (1..1)</description></item>
///   <item><term>Status</term><description>CaseStatus2 — required (1..1)</description></item>
///   <item><term>NewAssignment</term><description>CaseAssignment6 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>Header</c>, <c>Case</c>, <c>Status</c>, the optional
/// <c>NewAssignment</c> building block, and the <c>SupplementaryData</c> collection are each
/// validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see
/// the two constructors below.
/// </remarks>
public class CaseStatusReportV06Validator : AbstractValidator<CaseStatusReportV06>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Header</c>, <c>Case</c>, and <c>Status</c> building blocks, the
    /// optional <c>NewAssignment</c> building block, and the <c>SupplementaryData</c>
    /// collection's item type — e.g. resolved from a DI container — instead of this type
    /// constructing its own.
    /// </summary>
    /// <param name="headerValidator">
    /// Validator for the required <c>Header</c> building block (ReportHeader7, 1..1).
    /// </param>
    /// <param name="caseValidator">
    /// Validator for the required <c>Case</c> building block (Case6, 1..1).
    /// </param>
    /// <param name="statusValidator">
    /// Validator for the required <c>Status</c> building block (CaseStatus2, 1..1).
    /// </param>
    /// <param name="newAssignmentValidator">
    /// Validator for the optional <c>NewAssignment</c> building block (CaseAssignment6, 0..1) —
    /// only invoked when present.
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public CaseStatusReportV06Validator(
        IValidator<ReportHeader7> headerValidator,
        IValidator<Case6> caseValidator,
        IValidator<CaseStatus2> statusValidator,
        IValidator<CaseAssignment6> newAssignmentValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.Header).SetValidator(headerValidator);
        RuleFor(x => x.Case).SetValidator(caseValidator);
        RuleFor(x => x.Status).SetValidator(statusValidator);

        When(
            x => x.NewAssignment is not null,
            () => RuleFor(x => x.NewAssignment).SetValidator(newAssignmentValidator!)
        );

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Header</c>, <c>Case</c>,
    /// <c>Status</c>, <c>NewAssignment</c>, and the <c>SupplementaryData</c> collection are each
    /// validated by their own default validator (<see cref="ReportHeader7Validator"/>,
    /// <see cref="Case6Validator"/>, <see cref="CaseStatus2Validator"/>,
    /// <see cref="CaseAssignment6Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public CaseStatusReportV06Validator()
        : this(
            new ReportHeader7Validator(),
            new Case6Validator(),
            new CaseStatus2Validator(),
            new CaseAssignment6Validator(),
            new SupplementaryData1Validator()
        ) { }
}
