// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="CaseStatusReportRequestV05"/> (camt.038.001.05) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3CdDzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The CaseStatusReportRequest message is sent by a case creator or case assigner to a case
/// assignee. This message is used to request the status of a case.
///
/// Usage
/// The CaseStatusReportRequest message must be answered with a CaseStatusReport message. It can
/// be used to request the status of a: request to cancel payment case; request to modify payment
/// case; unable to apply case; claim non receipt case. The CaseStatusReportRequest message covers
/// one and only one case at a time — if a case creator or case assigner needs the status of
/// several cases, then multiple CaseStatusReportRequest messages must be sent. The
/// CaseStatusReportRequest message may be forwarded to subsequent case assignee(s) in the case
/// processing chain. The processing of a case generates NotificationOfCaseAssignment and/or
/// ResolutionOfInvestigation messages to the case creator/case assigner — they alone should
/// provide collaborating parties sufficient information about the progress of the investigation.
/// The CaseStatusReportRequest must therefore only be used when no information has been received
/// from the case assignee within the expected time frame. An agent may suspend an investigation
/// by classifying it as overdue if, after sending the request for the status of the
/// investigation, it does not receive any response after a long time. Agents may set their
/// individual threshold wait-time.
///
/// <list type="table">
///   <item><term>RequestHeader</term><description>ReportHeader7 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case6 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>RequestHeader</c>, <c>Case</c>, and the <c>SupplementaryData</c>
/// collection are each validated by an injected <see cref="IValidator{T}"/> rather than a
/// hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class CaseStatusReportRequestV05Validator : AbstractValidator<CaseStatusReportRequestV05>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>RequestHeader</c> and <c>Case</c> building blocks and for the
    /// <c>SupplementaryData</c> collection's item type — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="requestHeaderValidator">
    /// Validator for the required <c>RequestHeader</c> building block (ReportHeader7, 1..1).
    /// </param>
    /// <param name="caseValidator">
    /// Validator for the required <c>Case</c> building block (Case6, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public CaseStatusReportRequestV05Validator(
        IValidator<ReportHeader7> requestHeaderValidator,
        IValidator<Case6> caseValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.RequestHeader).SetValidator(requestHeaderValidator);
        RuleFor(x => x.Case).SetValidator(caseValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>RequestHeader</c>, <c>Case</c>,
    /// and the <c>SupplementaryData</c> collection are each validated by their own default
    /// validator (<see cref="ReportHeader7Validator"/>, <see cref="Case6Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public CaseStatusReportRequestV05Validator()
        : this(new ReportHeader7Validator(), new Case6Validator(), new SupplementaryData1Validator()) { }
}
