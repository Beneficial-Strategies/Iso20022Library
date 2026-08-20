// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="DebitAuthorisationResponseV06"/> (camt.036.001.06) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3H8pzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The DebitAuthorisationResponse message is sent by an account owner to its account servicing
/// institution. This message is used to approve or reject a debit authorisation request.
///
/// Usage
/// The DebitAuthorisationResponse message: is used to reply to a Debit Authorisation Request
/// message; covers one and only one payment instruction at a time — if an account owner needs to
/// reply to several DebitAuthorisationRequest messages, then multiple DebitAuthorisationResponse
/// messages must be sent; indicates whether the account owner agrees with the request by means of
/// a code, and also allows further details to be given about the debit authorisation, such as
/// acceptable amount and value date for the debit; must be used exclusively between the account
/// owner and the account servicing institution — it must not be used in place of a Resolution Of
/// Investigation message between subsequent agents.
///
/// <list type="table">
///   <item><term>Assignment</term><description>CaseAssignment6 — required (1..1)</description></item>
///   <item><term>Case</term><description>Case6 — optional (0..1)</description></item>
///   <item><term>Confirmation</term><description>DebitAuthorisationConfirmation2 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>Assignment</c>, the optional <c>Case</c> building block,
/// <c>Confirmation</c>, and the <c>SupplementaryData</c> collection are each validated by an
/// injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class DebitAuthorisationResponseV06Validator : AbstractValidator<DebitAuthorisationResponseV06>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>Assignment</c> and <c>Confirmation</c> building blocks, the optional
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
    /// <param name="confirmationValidator">
    /// Validator for the required <c>Confirmation</c> building block
    /// (DebitAuthorisationConfirmation2, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public DebitAuthorisationResponseV06Validator(
        IValidator<CaseAssignment6> assignmentValidator,
        IValidator<Case6> caseValidator,
        IValidator<DebitAuthorisationConfirmation2> confirmationValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.Assignment).SetValidator(assignmentValidator);

        When(x => x.Case is not null, () => RuleFor(x => x.Case).SetValidator(caseValidator!));

        RuleFor(x => x.Confirmation).SetValidator(confirmationValidator);

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Assignment</c>, <c>Case</c>,
    /// <c>Confirmation</c>, and the <c>SupplementaryData</c> collection are each validated by
    /// their own default validator (<see cref="CaseAssignment6Validator"/>,
    /// <see cref="Case6Validator"/>, <see cref="DebitAuthorisationConfirmation2Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public DebitAuthorisationResponseV06Validator()
        : this(
            new CaseAssignment6Validator(),
            new Case6Validator(),
            new DebitAuthorisationConfirmation2Validator(),
            new SupplementaryData1Validator()
        ) { }
}
