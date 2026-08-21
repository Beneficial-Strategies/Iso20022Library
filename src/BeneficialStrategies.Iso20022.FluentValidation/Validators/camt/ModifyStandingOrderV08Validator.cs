// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="ModifyStandingOrderV08"/> (camt.024.001.08) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3QfXzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The ModifyStandingOrder message is sent by a member to the transaction administrator. It is
/// used to request a change in the features of a permanent order for the transfer of funds
/// between two accounts belonging to the same member and being held at the transaction
/// administrator.
///
/// Usage
/// There should be one standing order per (direct) member and per business day. The
/// ModifyStandingOrder message must not be used to request a transfer of funds between accounts
/// during the working day — the liquidity transfer messages must be used for that purpose. The
/// message first identifies the standing order to be modified and then provides the details of
/// the new standing order. The elements that can be modified are: amount; account to be
/// credited; account to be debited; account owner (for on behalf scenario); frequency of
/// payment; daytime or overnight processing; and the dates when the standing order begins and
/// ceases to be effective. The transaction administrator will execute or reject the requested
/// modifications and may send a Receipt message in reply. To verify the outcome of the request,
/// the member may submit a GetStandingOrder message with the appropriate search criteria.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>StandingOrderIdentification</term><description>StandingOrderIdentification8 — required (1..1)</description></item>
///   <item><term>NewStandingOrderValueSet</term><description>StandingOrder10 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, <c>StandingOrderIdentification</c>,
/// <c>NewStandingOrderValueSet</c>, and the <c>SupplementaryData</c> collection are each
/// validated by an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see
/// the two constructors below.
/// </remarks>
public class ModifyStandingOrderV08Validator : AbstractValidator<ModifyStandingOrderV08>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for every required building block and for the <c>SupplementaryData</c> collection's item
    /// type — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="messageHeaderValidator">
    /// Validator for the required <c>MessageHeader</c> building block (MessageHeader1, 1..1).
    /// </param>
    /// <param name="standingOrderIdentificationValidator">
    /// Validator for the required <c>StandingOrderIdentification</c> building block
    /// (StandingOrderIdentification8, 1..1).
    /// </param>
    /// <param name="newStandingOrderValueSetValidator">
    /// Validator for the required <c>NewStandingOrderValueSet</c> building block
    /// (StandingOrder10, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public ModifyStandingOrderV08Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<StandingOrderIdentification8> standingOrderIdentificationValidator,
        IValidator<StandingOrder10> newStandingOrderValueSetValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);
        RuleFor(x => x.StandingOrderIdentification).SetValidator(standingOrderIdentificationValidator);
        RuleFor(x => x.NewStandingOrderValueSet).SetValidator(newStandingOrderValueSetValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: every required building block and
    /// the <c>SupplementaryData</c> collection are each validated by their own default validator
    /// (<see cref="MessageHeader1Validator"/>, <see cref="StandingOrderIdentification8Validator"/>,
    /// <see cref="StandingOrder10Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public ModifyStandingOrderV08Validator()
        : this(
            new MessageHeader1Validator(),
            new StandingOrderIdentification8Validator(),
            new StandingOrder10Validator(),
            new SupplementaryData1Validator()
        ) { }
}
