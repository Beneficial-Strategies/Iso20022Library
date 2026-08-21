// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="CreateLimitV02"/> (camt.101.001.02) per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _R3GHiTEZEe6kQ-WGAhcVPQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The CreateLimit message is sent by a member to the transaction administrator. It is used to
/// create one or several limits set by the member and managed by the transaction administrator.
///
/// Usage
/// Based on the criteria defined in the CreateLimit message, the transaction administrator will
/// execute or reject the requested creation and respond with a Receipt message as a reply to the
/// request.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>LimitData</term><description>LimitStructure6 — optional collection (0..∞)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..∞)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, the <c>LimitData</c> collection, and the
/// <c>SupplementaryData</c> collection are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors
/// below.
/// </remarks>
public class CreateLimitV02Validator : AbstractValidator<CreateLimitV02>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>MessageHeader</c> building block and for the <c>LimitData</c>/
    /// <c>SupplementaryData</c> collections' item types — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="messageHeaderValidator">
    /// Validator for the required <c>MessageHeader</c> building block (MessageHeader1, 1..1).
    /// </param>
    /// <param name="limitDataValidator">
    /// Validator for each item of the <c>LimitData</c> collection (LimitStructure6, 0..∞).
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for each item of the <c>SupplementaryData</c> collection (SupplementaryData1, 0..∞).
    /// </param>
    public CreateLimitV02Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<LimitStructure6> limitDataValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);
        RuleForEach(x => x.LimitData).SetValidator(limitDataValidator);
        RuleForEach(x => x.SupplementaryData).SetValidator(supplementaryDataValidator);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>MessageHeader</c>,
    /// <c>LimitData</c>, and <c>SupplementaryData</c> are each validated by their own default
    /// validator (<see cref="MessageHeader1Validator"/>, <see cref="LimitStructure6Validator"/>,
    /// <see cref="SupplementaryData1Validator"/>). Convenience constructor for callers not using a
    /// DI container.
    /// </summary>
    public CreateLimitV02Validator()
        : this(
            new MessageHeader1Validator(),
            new LimitStructure6Validator(),
            new SupplementaryData1Validator()
        ) { }
}
