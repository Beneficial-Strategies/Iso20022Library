// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="DeleteLimitV08"/> (camt.012.001.08) per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3H8tzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The DeleteLimit message is sent by a member to the transaction administrator. It is used to
/// request the deletion of one particular, several or all limits set by the member and managed by
/// the transaction administrator. The DeleteLimit message may delete several types of current
/// limits (risk or liquidity management limit), based on multiple requests.
///
/// Usage
/// The member submits a DeleteLimit message identifying which limit(s) it wants to delete
/// (current limit risk/liquidity limit concepts have been merged) based on the type of limit(s),
/// the value of the limit(s), and the identification of the counterparty (bilateral limit). Based
/// on the criteria received, the transaction administrator will execute or reject the requested
/// deletion(s). The transaction administrator may send a Receipt message in reply. To verify the
/// outcome of the request, the member may submit a GetLimit message with the appropriate search
/// criteria.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>LimitDetails</term><description>LimitStructure3Choice_ — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, <c>LimitDetails</c>, and the
/// <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class DeleteLimitV08Validator : AbstractValidator<DeleteLimitV08>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>MessageHeader</c> and <c>LimitDetails</c> building blocks and for the
    /// <c>SupplementaryData</c> collection's item type — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="messageHeaderValidator">
    /// Validator for the required <c>MessageHeader</c> building block (MessageHeader1, 1..1).
    /// </param>
    /// <param name="limitDetailsValidator">
    /// Validator for the required <c>LimitDetails</c> building block (LimitStructure3Choice_, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public DeleteLimitV08Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<LimitStructure3Choice_> limitDetailsValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);
        RuleFor(x => x.LimitDetails).SetValidator(limitDetailsValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>MessageHeader</c>,
    /// <c>LimitDetails</c>, and the <c>SupplementaryData</c> collection are each validated by
    /// their own default validator (<see cref="MessageHeader1Validator"/>,
    /// <see cref="LimitStructure3Choice_Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public DeleteLimitV08Validator()
        : this(
            new MessageHeader1Validator(),
            new LimitStructure3Choice_Validator(),
            new SupplementaryData1Validator()
        ) { }
}
