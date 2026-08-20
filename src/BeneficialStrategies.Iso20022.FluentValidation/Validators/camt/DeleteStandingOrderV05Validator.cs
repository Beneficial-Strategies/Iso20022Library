// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="DeleteStandingOrderV05"/> (camt.071.001.05) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3IjfzEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// The DeleteStandingOrder message is sent by the system member to delete one or more standing
/// orders within the static data held by the system transaction administrator.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>StandingOrderDetails</term><description>StandingOrderOrAll4Choice_ — required (1..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, <c>StandingOrderDetails</c>, and the
/// <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class DeleteStandingOrderV05Validator : AbstractValidator<DeleteStandingOrderV05>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>MessageHeader</c> and <c>StandingOrderDetails</c> building blocks and
    /// for the <c>SupplementaryData</c> collection's item type — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="messageHeaderValidator">
    /// Validator for the required <c>MessageHeader</c> building block (MessageHeader1, 1..1).
    /// </param>
    /// <param name="standingOrderDetailsValidator">
    /// Validator for the required <c>StandingOrderDetails</c> building block
    /// (StandingOrderOrAll4Choice_, 1..1).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public DeleteStandingOrderV05Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<StandingOrderOrAll4Choice_> standingOrderDetailsValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);
        RuleFor(x => x.StandingOrderDetails).SetValidator(standingOrderDetailsValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>MessageHeader</c>,
    /// <c>StandingOrderDetails</c>, and the <c>SupplementaryData</c> collection are each
    /// validated by their own default validator (<see cref="MessageHeader1Validator"/>,
    /// <see cref="StandingOrderOrAll4Choice_Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public DeleteStandingOrderV05Validator()
        : this(
            new MessageHeader1Validator(),
            new StandingOrderOrAll4Choice_Validator(),
            new SupplementaryData1Validator()
        ) { }
}
