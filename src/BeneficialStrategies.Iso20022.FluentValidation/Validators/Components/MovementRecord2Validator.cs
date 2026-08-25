// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MovementRecord2"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _0BP6ATEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Details of a movement record requested in a single settlement instruction.
/// <list type="table">
///   <item><term>Identification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>SequenceNumber</term><description>Number — optional (0..1)</description></item>
///   <item><term>Amount</term><description>AmountAndDirection5 — required (1..1)</description></item>
///   <item><term>SettlementAgent</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>SettlementAgentAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Participant</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>ParticipantAccount</term><description>CashAccount40 — optional (0..1)</description></item>
///   <item><term>Reference</term><description>Max35Text — optional (0..1); length enforced by struct constructor — no rule needed</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>Amount</c>, <c>SettlementAgent</c>, <c>SettlementAgentAccount</c>,
/// <c>Participant</c>, and <c>ParticipantAccount</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class MovementRecord2Validator : AbstractValidator<MovementRecord2>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// for <c>Amount</c> (required) and the optional <c>SettlementAgent</c>,
    /// <c>SettlementAgentAccount</c>, <c>Participant</c>, and <c>ParticipantAccount</c> building
    /// blocks — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public MovementRecord2Validator(
        IValidator<AmountAndDirection5> amountValidator,
        IValidator<PartyIdentification272> settlementAgentValidator,
        IValidator<CashAccount40> settlementAgentAccountValidator,
        IValidator<PartyIdentification272> participantValidator,
        IValidator<CashAccount40> participantAccountValidator
    )
    {
        // Identification: Max35Text, required — length enforced by struct constructor, no rule needed.
        // Reference: Max35Text, optional — length enforced by struct constructor, no rule needed.
        // SequenceNumber: Number, optional scalar — no rule needed.

        RuleFor(x => x.Amount).SetValidator(amountValidator!);

        When(
            x => x.SettlementAgent is not null,
            () => RuleFor(x => x.SettlementAgent).SetValidator(settlementAgentValidator!)
        );

        When(
            x => x.SettlementAgentAccount is not null,
            () => RuleFor(x => x.SettlementAgentAccount).SetValidator(settlementAgentAccountValidator!)
        );

        When(
            x => x.Participant is not null,
            () => RuleFor(x => x.Participant).SetValidator(participantValidator!)
        );

        When(
            x => x.ParticipantAccount is not null,
            () => RuleFor(x => x.ParticipantAccount).SetValidator(participantAccountValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>Amount</c>,
    /// <c>SettlementAgent</c>/<c>Participant</c> (both <see cref="PartyIdentification272Validator"/>),
    /// and <c>SettlementAgentAccount</c>/<c>ParticipantAccount</c> (both
    /// <see cref="CashAccount40Validator"/>) are each validated by their own default validator.
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public MovementRecord2Validator()
        : this(
            new AmountAndDirection5Validator(),
            new PartyIdentification272Validator(),
            new CashAccount40Validator(),
            new PartyIdentification272Validator(),
            new CashAccount40Validator()
        ) { }
}
