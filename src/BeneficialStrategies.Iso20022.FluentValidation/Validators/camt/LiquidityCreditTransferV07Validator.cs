// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="LiquidityCreditTransferV07"/> (camt.050.001.07) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3PRnTEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The LiquidityCreditTransfer message is sent by a member to the transaction administrator. It
/// is used to request a transfer of funds between two accounts belonging to the same member or
/// the same group of accounts, and being held at the transaction administrator.
///
/// Usage
/// At any time during operating hours, to perform appropriate liquidity management, the member
/// can request the transaction administrator to execute a transfer of funds between two accounts
/// it maintains for the member — for instance, as an action resulting from a Get/Return Account
/// pair of messages, when transactions are unbalanced for the business day, or to unlock pending
/// transactions at end of day. Transfers are processed only when the balance in the account to be
/// debited remains positive after the transfer. The transaction administrator may send a Receipt
/// message in reply; the member may verify the outcome via a GetTransaction or GetAccount message.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>LiquidityCreditTransfer</term><description>LiquidityCreditTransfer4 — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, <c>LiquidityCreditTransfer</c>, and the
/// <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class LiquidityCreditTransferV07Validator : AbstractValidator<LiquidityCreditTransferV07>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>MessageHeader</c> and <c>LiquidityCreditTransfer</c> building blocks
    /// and for the <c>SupplementaryData</c> collection's item type — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="messageHeaderValidator">
    /// Validator for the required <c>MessageHeader</c> building block (MessageHeader1, 1..1).
    /// </param>
    /// <param name="liquidityCreditTransferValidator">
    /// Validator for the required <c>LiquidityCreditTransfer</c> building block
    /// (LiquidityCreditTransfer4, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public LiquidityCreditTransferV07Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<LiquidityCreditTransfer4> liquidityCreditTransferValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);
        RuleFor(x => x.LiquidityCreditTransfer).SetValidator(liquidityCreditTransferValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>MessageHeader</c>,
    /// <c>LiquidityCreditTransfer</c>, and the <c>SupplementaryData</c> collection are each
    /// validated by their own default validator (<see cref="MessageHeader1Validator"/>,
    /// <see cref="LiquidityCreditTransfer4Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public LiquidityCreditTransferV07Validator()
        : this(
            new MessageHeader1Validator(),
            new LiquidityCreditTransfer4Validator(),
            new SupplementaryData1Validator()
        ) { }
}
