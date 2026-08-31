// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation;

/// <summary>
/// Saga instance state for one debtor's Request-to-Pay activation episode, tracked from the
/// Debtor/Payer RTP Service Provider's own perspective — the mirror of
/// <see cref="MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.CreditorEnrolmentSagaState"/> for
/// this sub-process. See that type's remarks for why this is an ordinary mutable class.
/// </summary>
public sealed class DebtorActivationSagaState : Framework.Iso20022SagaStateBase
{
    /// <summary>The Debtor, captured from the initiating event's <c>Activation.Debtor</c>.</summary>
    public RTPPartyIdentification2? Debtor { get; set; }

    /// <summary>Captured from the initiating event's <c>Activation.Creditor</c>.</summary>
    public RTPPartyIdentification2? Creditor { get; set; }

    /// <summary>Captured from the initiating event's <c>Activation.DebtorSolutionProvider</c>.</summary>
    public RTPPartyIdentification2? DebtorSolutionProvider { get; set; }

    /// <summary>Captured from the initiating event's <c>Activation.UltimateDebtor</c>, when present.</summary>
    public RTPPartyIdentification2? UltimateDebtor { get; set; }

    /// <summary>
    /// The outcome of the most recently processed <c>DebtorActivationStatusReported</c> event.
    /// See <see cref="MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.CreditorEnrolmentSagaState.LastStatus"/>
    /// for why the <c>Proprietary</c> variant is not interpreted.
    /// </summary>
    public ServiceRequestStatus1Code? LastStatus { get; set; }

    /// <summary>The effective activation date from the most recently processed status report, when populated.</summary>
    public DateAndDateTime2Choice_? EffectiveActivationDate { get; set; }

    /// <summary>
    /// Extension point for a caller-supplied review/compliance step. This package never sets or
    /// reads this field itself — the source ISO document does not specify any such step for this
    /// flow. See <c>ReviewRequested</c>/<c>ReviewCompleted</c> on
    /// <see cref="DebtorActivationServiceProviderStateMachine"/>.
    /// </summary>
    public bool? ReviewApproved { get; set; }

    /// <summary>See <see cref="ReviewApproved"/>.</summary>
    public string? ReviewNote { get; set; }
}
