// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.pain;

/// <summary>
/// Validates <see cref="MandateSuspensionRequestV04"/> (pain.018.001.04) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3P4jTEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The MandateSuspensionRequest message is sent by the initiator of the request to its agent.
/// The initiator can either be the debtor, debtor agent, creditor, or creditor agent. It is used
/// to request the suspension of an existing mandate until the suspension is lifted.
///
/// Usage
/// The MandateSuspensionRequest message can contain one or more suspension requests. Messages
/// can be exchanged between creditor and creditor agent or debtor and debtor agent and between
/// creditor agent and debtor agent. The message can be used in domestic and cross-border
/// scenarios.
///
/// <list type="table">
///   <item><term>GroupHeader</term><description>GroupHeader110 — required (1..1)</description></item>
///   <item><term>UnderlyingSuspensionDetails</term><description>MandateSuspension4 — optional (0..∞)</description></item>
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
/// Dependency injection: <c>GroupHeader</c>, the <c>UnderlyingSuspensionDetails</c> collection,
/// and the <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class MandateSuspensionRequestV04Validator : AbstractValidator<MandateSuspensionRequestV04>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>GroupHeader</c> building block and for the
    /// <c>UnderlyingSuspensionDetails</c>/<c>SupplementaryData</c> collections' item types — e.g.
    /// resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="groupHeaderValidator">
    /// Validator for the required <c>GroupHeader</c> building block (GroupHeader110, 1..1).
    /// </param>
    /// <param name="underlyingSuspensionDetailsValidator">
    /// Validator for each item of the <c>UnderlyingSuspensionDetails</c> collection
    /// (MandateSuspension4, 0..∞).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public MandateSuspensionRequestV04Validator(
        IValidator<GroupHeader110> groupHeaderValidator,
        IValidator<MandateSuspension4> underlyingSuspensionDetailsValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.GroupHeader).SetValidator(groupHeaderValidator);
        RuleForEach(x => x.UnderlyingSuspensionDetails).SetValidator(underlyingSuspensionDetailsValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>GroupHeader</c>, the
    /// <c>UnderlyingSuspensionDetails</c> collection, and the <c>SupplementaryData</c> collection
    /// are each validated by their own default validator (<see cref="GroupHeader110Validator"/>,
    /// <see cref="MandateSuspension4Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MandateSuspensionRequestV04Validator()
        : this(
            new GroupHeader110Validator(),
            new MandateSuspension4Validator(),
            new SupplementaryData1Validator()
        ) { }
}
