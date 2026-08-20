// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

/// <summary>
/// Validates <see cref="MandateInitiationRequestV08"/> (pain.009.001.08) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3P4fzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The MandateInitiationRequest message is sent by the initiator of the request to their agent.
/// The initiator can either be the debtor or the creditor. The MandateInitiationRequest message
/// is forwarded by the agent of the initiator to the agent of the counterparty. It is used to
/// setup the instruction that allows the debtor agent to accept instructions from the creditor,
/// through the creditor agent, to debit the account of the debtor.
///
/// Usage
/// The MandateInitiationRequest message can contain one or more request(s) to setup a specific
/// mandate. The messages can be exchanged between creditor and creditor agent or debtor and
/// debtor agent and between creditor agent and debtor agent. The message can also be used by an
/// initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateInitiationRequest message can be used in domestic and cross-border scenarios.
///
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader110 — required (1..1)</description></item>
///   <item><term>Mandate</term><description>Mandate23 — required collection (1..∞)</description></item>
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
/// <c>Mandate</c> has <c>minOccurs="1"</c> in the spec (confirmed via MCP — the C# model's
/// <c>ValueList&lt;Mandate23&gt;</c> defaults to an empty collection, which is a compile-time-legal
/// but spec-invalid value) — enforced below with <c>NotEmpty()</c>.
///
/// Dependency injection: <c>GroupHeader</c>, the <c>Mandate</c> collection, and the
/// <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class MandateInitiationRequestV08Validator : AbstractValidator<MandateInitiationRequestV08>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>GroupHeader</c> building block and for the <c>Mandate</c>/
    /// <c>SupplementaryData</c> collections' item types — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="groupHeaderValidator">
    /// Validator for the required <c>GroupHeader</c> building block (GroupHeader110, 1..1).
    /// </param>
    /// <param name="mandateValidator">
    /// Validator for each item of the required <c>Mandate</c> collection (Mandate23, 1..∞).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateInitiationRequestV08Validator(
        IValidator<GroupHeader110> groupHeaderValidator,
        IValidator<Mandate23> mandateValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator);

        RuleFor(x => x.Mandate)
            .NotEmpty()
            .WithName("Mandate")
            .WithMessage("MandateInitiationRequestV08.Mandate must contain at least one entry (minOccurs=1).");
        RuleForEach(x => x.Mandate).SetValidator(mandateValidator);

        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>GroupHeader</c>, the
    /// <c>Mandate</c> collection, and the <c>SupplementaryData</c> collection are each validated
    /// by their own default validator (<see cref="GroupHeader110Validator"/>,
    /// <see cref="Mandate23Validator"/>, <see cref="SupplementaryData1Validator"/>). Convenience
    /// constructor for callers not using a DI container.
    /// </summary>
    public MandateInitiationRequestV08Validator()
        : this(new GroupHeader110Validator(), new Mandate23Validator(), new SupplementaryData1Validator()) { }
}
