// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

/// <summary>
/// Validates <see cref="MandateAmendmentRequestV08"/> (pain.010.001.08) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3P4TzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The MandateAmendmentRequest message is sent by the initiator of the request to their agent
/// and/or counterparty. The initiator can either be the debtor or the creditor (or, where
/// appropriate, the debtor agent). It is forwarded by the agent of the initiator to the agent of
/// the counterparty, and is used to request the amendment of specific information in an existing
/// mandate. The message must reflect the new data of the element(s) to be amended and, at a
/// minimum, a unique reference to the existing mandate. If accepted, this message together with
/// the MandateAcceptanceReport message confirming the acceptance is considered a valid amendment
/// on an existing mandate, agreed upon by all parties — the amended mandate is from then on
/// considered the valid mandate.
///
/// Usage
/// The MandateAmendmentRequest message can contain one or more request(s) to amend a specific
/// mandate. The messages can be exchanged between creditor and creditor agent or debtor and
/// debtor agent and between creditor agent and debtor agent. The message can also be used by an
/// initiating party that has authority to send it on behalf of the creditor or debtor, in both
/// domestic and cross-border scenarios. If all elements in the existing mandate need to be
/// amended, or the underlying contract is different, this message should not be used — the
/// existing mandate has to be cancelled and a new mandate initiated instead.
///
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader110 — required (1..1)</description></item>
///   <item><term>UnderlyingAmendmentDetails</term><description>MandateAmendment8 — optional (0..∞)</description></item>
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
/// Dependency injection: <c>GroupHeader</c>, the <c>UnderlyingAmendmentDetails</c> collection,
/// and the <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class MandateAmendmentRequestV08Validator : AbstractValidator<MandateAmendmentRequestV08>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>GroupHeader</c> building block and for the
    /// <c>UnderlyingAmendmentDetails</c>/<c>SupplementaryData</c> collections' item types — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="groupHeaderValidator">
    /// Validator for the required <c>GroupHeader</c> building block (GroupHeader110, 1..1).
    /// </param>
    /// <param name="underlyingAmendmentDetailsValidator">
    /// Validator for each item of the <c>UnderlyingAmendmentDetails</c> collection
    /// (MandateAmendment8, 0..∞).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateAmendmentRequestV08Validator(
        IValidator<GroupHeader110> groupHeaderValidator,
        IValidator<MandateAmendment8> underlyingAmendmentDetailsValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator);
        RuleForEach(x => x.UnderlyingAmendmentDetails).SetValidator(underlyingAmendmentDetailsValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>GroupHeader</c>, the
    /// <c>UnderlyingAmendmentDetails</c> collection, and the <c>SupplementaryData</c> collection
    /// are each validated by their own default validator (<see cref="GroupHeader110Validator"/>,
    /// <see cref="MandateAmendment8Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateAmendmentRequestV08Validator()
        : this(
            new GroupHeader110Validator(),
            new MandateAmendment8Validator(),
            new SupplementaryData1Validator()
        ) { }
}
