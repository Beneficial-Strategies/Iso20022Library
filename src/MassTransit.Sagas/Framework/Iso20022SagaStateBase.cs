// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.Framework;

/// <summary>
/// Fields every ISO 20022 RTP-service-provider saga in this package needs. Factored out because
/// the Creditor Enrolment and Debtor Activation sagas are structurally identical at this level —
/// both keyed off an <c>EnrolmentHeader3</c>/<c>ActivationHeader3</c>-shaped header with no
/// ISO-native business-transaction id to correlate on. This is deliberately not a speculative
/// "general ISO 20022 saga" abstraction — there are only two real families behind it, and it
/// captures exactly what they share, nothing more.
/// </summary>
/// <remarks>
/// Properties are ordinary mutable <c>{ get; set; }</c>, not this project's usual
/// <c>required</c> init-only convention (see root CLAUDE.md's constructor/property guidance) —
/// deliberately, because <see cref="MassTransit.SagaStateMachineInstance"/> itself requires a
/// settable <see cref="CorrelationId"/>, and MassTransit's state-machine activities mutate saga
/// instances in place (<c>context.Saga.SomeField = ...</c>) before a repository persists them.
/// This is the same class of exception CLAUDE.md documents for W3C-aliased types: an external
/// contract dictates the shape, not an oversight.
/// </remarks>
public abstract class Iso20022SagaStateBase : SagaStateMachineInstance
{
    /// <summary>
    /// MassTransit's own saga instance key. Synthesized fresh when the initiating Request line
    /// item is fanned out — ISO 20022 has no equivalent identifier for this message family.
    /// </summary>
    public Guid CorrelationId { get; set; }

    /// <summary>
    /// The state machine's current state name. Required by MassTransit's own saga-persistence
    /// convention (<c>InstanceState(x =&gt; x.CurrentState)</c>).
    /// </summary>
    public string CurrentState { get; set; } = string.Empty;

    /// <summary>
    /// <c>Header.MessageIdentification</c> of the most recently received *request-type* message in
    /// this episode (the initiating Request, or a later Amendment/Cancellation) — never a
    /// StatusReport's own id. A StatusReport's <c>OriginalBusinessInstruction1.MessageIdentification</c>
    /// always references whichever request it is reporting status for, so this is the field
    /// <c>StatusReported</c> correlation checks against.
    /// </summary>
    public string LastMessageIdentification { get; set; } = string.Empty;

    /// <summary>
    /// <c>Header.MessageIdentification</c> of the very first (initiating) Request in this episode —
    /// set once when the saga is created and never overwritten afterward. Amendment/Cancellation
    /// messages identify the enrolment/activation episode itself (not "the most recent message"),
    /// so their <c>OriginalBusinessInstruction1.MessageIdentification</c> references this id even
    /// after one or more StatusReports have since moved <see cref="LastMessageIdentification"/> on.
    /// </summary>
    public string OriginalMessageIdentification { get; set; } = string.Empty;

    /// <summary>
    /// Canonicalized party-identity key (see <see cref="PartyIdentityKey"/>) used as the fallback
    /// correlation path when a later message re-identifies the party instead of chaining off
    /// <see cref="LastMessageIdentification"/>. Best-effort — see <see cref="PartyIdentityKey"/>'s
    /// own remarks on why a party's identity has no single guaranteed scalar field.
    /// </summary>
    public string? PartyIdentityKey { get; set; }

    /// <summary>
    /// UTC time this saga instance was created. Operational/diagnostic only — no ISO source.
    /// </summary>
    public DateTime CreatedUtc { get; set; }
}
