// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

/// <summary>
/// Validates <see cref="MandateCopyRequestV04"/> (pain.017.001.04) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3P4bzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-19). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The MandateCopyRequest message is sent by the initiator of the request to their agent. The
/// initiator can either be the debtor or the creditor. It is forwarded by the agent of the
/// initiator to the agent of the counterparty. A MandateCopyRequest message is used to request a
/// copy of an existing mandate; if accepted, the mandate copy is sent using a
/// MandateAcceptanceReport message.
///
/// Usage
/// The MandateCopyRequest message can contain one or more copy requests. Messages can be
/// exchanged between creditor and creditor agent, debtor and debtor agent, or between creditor
/// agent and debtor agent. It can also be used by an initiating party with authority to send it
/// on behalf of the creditor or debtor, in both domestic and cross-border scenarios.
///
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader110 — required (1..1)</description></item>
///   <item><term>UnderlyingCopyRequestDetails</term><description>MandateCopy4 — optional (0..∞)</description></item>
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
///       genuinely message-level content at the C# model level.
///     </description>
///   </item>
/// </list>
///
/// Dependency injection: <c>GroupHeader</c>, the <c>UnderlyingCopyRequestDetails</c> collection,
/// and the <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class MandateCopyRequestV04Validator : AbstractValidator<MandateCopyRequestV04>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>GroupHeader</c> building block and for the
    /// <c>UnderlyingCopyRequestDetails</c>/<c>SupplementaryData</c> collections' item types — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="groupHeaderValidator">
    /// Validator for the required <c>GroupHeader</c> building block (GroupHeader110, 1..1).
    /// </param>
    /// <param name="underlyingCopyRequestDetailsValidator">
    /// Validator for each item of the <c>UnderlyingCopyRequestDetails</c> collection (MandateCopy4,
    /// 0..∞).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateCopyRequestV04Validator(
        IValidator<GroupHeader110> groupHeaderValidator,
        IValidator<MandateCopy4> underlyingCopyRequestDetailsValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator);
        RuleForEach(x => x.UnderlyingCopyRequestDetails)
            .SetValidator(underlyingCopyRequestDetailsValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>GroupHeader</c>, the
    /// <c>UnderlyingCopyRequestDetails</c> collection, and the <c>SupplementaryData</c> collection
    /// are each validated by their own default validator (<see cref="GroupHeader110Validator"/>,
    /// <see cref="MandateCopy4Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateCopyRequestV04Validator()
        : this(
            new GroupHeader110Validator(),
            new MandateCopy4Validator(),
            new SupplementaryData1Validator()
        ) { }
}
