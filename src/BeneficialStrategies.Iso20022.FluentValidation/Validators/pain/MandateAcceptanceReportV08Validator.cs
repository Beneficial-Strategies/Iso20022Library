// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

/// <summary>
/// Validates <see cref="MandateAcceptanceReportV08"/> (pain.012.001.08) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3P4PzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or
/// creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent
/// of the initiator of the MandateRequest message (debtor or creditor). It is used to confirm
/// the acceptance or rejection of a MandateRequest message. Where acceptance is part of the full
/// process flow, a MandateRequest message only becomes valid after a confirmation of acceptance
/// is received through a MandateAcceptanceReport message from the agent of the receiver.
///
/// Usage
/// The MandateAcceptanceReport message can contain one or more confirmation(s) of acceptance or
/// rejection of a specific Mandate Request. Messages can be exchanged between debtor agent and
/// creditor agent and between debtor agent and debtor and creditor agent and creditor. The
/// message can be used in domestic and cross-border scenarios.
///
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader110 — required (1..1)</description></item>
///   <item><term>UnderlyingAcceptanceDetails</term><description>MandateAcceptance8 — optional (0..∞)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>SupplementaryDataRule</term>
///     <description>
///       The SupplementaryData building block at message level must not be used to provide
///       additional information about a transaction. The SupplementaryData element at transaction
///       level should be used for that purpose. Not independently enforceable by this library —
///       no structural signal distinguishes message-level-content-about-a-transaction from
///       genuinely message-level content at the C# model level. Same treatment as the sibling
///       message <see cref="MandateCopyRequestV04Validator"/>, which carries the identical rule.
///     </description>
///   </item>
/// </list>
///
/// Dependency injection: <c>GroupHeader</c>, the <c>UnderlyingAcceptanceDetails</c> collection,
/// and the <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class MandateAcceptanceReportV08Validator : AbstractValidator<MandateAcceptanceReportV08>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>GroupHeader</c> building block and for the
    /// <c>UnderlyingAcceptanceDetails</c>/<c>SupplementaryData</c> collections' item types — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="groupHeaderValidator">
    /// Validator for the required <c>GroupHeader</c> building block (GroupHeader110, 1..1).
    /// </param>
    /// <param name="underlyingAcceptanceDetailsValidator">
    /// Validator for each item of the <c>UnderlyingAcceptanceDetails</c> collection
    /// (MandateAcceptance8, 0..∞).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateAcceptanceReportV08Validator(
        IValidator<GroupHeader110> groupHeaderValidator,
        IValidator<MandateAcceptance8> underlyingAcceptanceDetailsValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator);
        RuleForEach(x => x.UnderlyingAcceptanceDetails).SetValidator(underlyingAcceptanceDetailsValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>GroupHeader</c>, the
    /// <c>UnderlyingAcceptanceDetails</c> collection, and the <c>SupplementaryData</c> collection
    /// are each validated by their own default validator (<see cref="GroupHeader110Validator"/>,
    /// <see cref="MandateAcceptance8Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateAcceptanceReportV08Validator()
        : this(
            new GroupHeader110Validator(),
            new MandateAcceptance8Validator(),
            new SupplementaryData1Validator()
        ) { }
}
