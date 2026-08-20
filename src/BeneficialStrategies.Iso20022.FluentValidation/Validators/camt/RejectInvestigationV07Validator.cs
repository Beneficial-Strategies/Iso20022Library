// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="RejectInvestigationV07"/> (camt.031.001.07) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3SUnTEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The RejectInvestigation message is sent by a case assignee to a case creator or case assigner
/// to reject a case given to him.
///
/// Usage
/// The RejectInvestigation message is used to notify the case creator or case assigner the
/// rejection of an assignment by the case assignee in a: request to cancel payment case; request
/// to modify payment case; unable to apply case; claim non receipt case. Rejecting a case
/// assignment occurs when: the case assignee is unable to trace the original payment instruction;
/// the case assignee is unable, or does not have authority, to process the assigned case
/// (indicate "You have by-passed a party"); the case assignee has received a non expected
/// message, and rejects the message with a wrong message indicator; the case assignee has not yet
/// received the ResolutionOfInvestigation message and the case has already been reopened; the
/// case assignee rejects a non-cash related query. The RejectInvestigation message covers one and
/// only one case at a time — if the case assignee needs to reject several case assignments, then
/// multiple RejectInvestigation messages must be sent. The RejectInvestigation message must be
/// forwarded by all subsequent case assignee(s) until it reaches the case assigner and must not
/// be used in place of a ResolutionOfInvestigation or CaseStatusReport message.
///
/// <list type="table">
///   <item><term>Assignment</term><description>CaseAssignment6 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case6 — optional (0..1)</description></item>
///   <item><term>Justification</term><description>InvestigationRejectionJustification1 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>Assignment</c>, the optional <c>Case</c> building block,
/// <c>Justification</c>, and the <c>SupplementaryData</c> collection are each validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class RejectInvestigationV07Validator : AbstractValidator<RejectInvestigationV07>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Assignment</c> and <c>Justification</c> building blocks, the optional
    /// <c>Case</c> building block, and the <c>SupplementaryData</c> collection's item type — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="assignmentValidator">
    /// Validator for the required <c>Assignment</c> building block (CaseAssignment6, 1..1).
    /// </param>
    /// <param name="caseValidator">
    /// Validator for the optional <c>Case</c> building block (Case6, 0..1) — only invoked when
    /// present.
    /// </param>
    /// <param name="justificationValidator">
    /// Validator for the required <c>Justification</c> building block
    /// (InvestigationRejectionJustification1, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public RejectInvestigationV07Validator(
        IValidator<CaseAssignment6> assignmentValidator,
        IValidator<Case6> caseValidator,
        IValidator<InvestigationRejectionJustification1> justificationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.Assignment).SetValidator(assignmentValidator);

        When(x => x.Case is not null, () => RuleFor(x => x.Case).SetValidator(caseValidator!));

        RuleFor(x => x.Justification).SetValidator(justificationValidator);

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Assignment</c>, <c>Case</c>,
    /// <c>Justification</c>, and the <c>SupplementaryData</c> collection are each validated by
    /// their own default validator (<see cref="CaseAssignment6Validator"/>,
    /// <see cref="Case6Validator"/>, <see cref="InvestigationRejectionJustification1Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public RejectInvestigationV07Validator()
        : this(
            new CaseAssignment6Validator(),
            new Case6Validator(),
            new InvestigationRejectionJustification1Validator(),
            new SupplementaryData1Validator()
        ) { }
}
