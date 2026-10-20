// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.Events;
using ServiceStatus1Choice = BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;
using OriginalActivation3Choice = BeneficialStrategies.Iso20022.Choices.OriginalActivation3Choice;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation;

/// <summary>
/// Tracks one debtor's Request-to-Pay activation episode from the Debtor/Payer RTP Service
/// Provider's own perspective. Mirrors
/// <see cref="MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.CreditorEnrolmentServiceProviderStateMachine"/>'s
/// state graph shape, keyed on the Debtor's identity instead of the Creditor's — see that type's
/// remarks for the source-document rationale, which applies identically here.
/// </summary>
public sealed class DebtorActivationServiceProviderStateMachine
    : MassTransitStateMachine<DebtorActivationSagaState>
{
    // ---- States ----
    public State AwaitingActivationResult { get; private set; } = null!;
    public State Activated { get; private set; } = null!;
    public State Rejected { get; private set; } = null!;
    public State AwaitingAmendmentResult { get; private set; } = null!;
    public State AwaitingCancellationResult { get; private set; } = null!;
    public State Cancelled { get; private set; } = null!;

    /// <summary>Extension point only. See the Creditor Enrolment state machine's identical event for the rationale.</summary>
    public Event<Framework.ReviewRequestedMessage> ReviewRequested { get; private set; } = null!;

    /// <summary>See <see cref="ReviewRequested"/>.</summary>
    public Event<Framework.ReviewCompletedMessage> ReviewCompleted { get; private set; } = null!;

    public Event<DebtorActivationRequested> ActivationRequested { get; private set; } = null!;
    public Event<DebtorActivationAmendmentRequested> AmendmentRequested { get; private set; } = null!;
    public Event<DebtorActivationCancellationRequested> CancellationRequested { get; private set; } = null!;
    public Event<DebtorActivationStatusReported> StatusReported { get; private set; } = null!;

    public DebtorActivationServiceProviderStateMachine()
    {
        InstanceState(x => x.CurrentState);

        Event(() => ActivationRequested, x => x.SelectId(context => NewId.NextGuid()));

        // See the Creditor Enrolment state machine's identical event registrations for the full
        // rationale: every state-touching comparison stays INLINE here (never wrapped in a helper
        // call that takes `state` as an argument), because CorrelateBy((state, ctx) => bool) is an
        // Expression<Func<...>> a real EF Core-backed saga repository pushes down to SQL — an
        // opaque method call on `state` can't be translated (confirmed against real MySQL while
        // building RequestToPayDebtorActivation.Demo).
        Event(
            () => AmendmentRequested,
            x =>
                x.CorrelateBy(
                    (state, context) =>
                        state.OriginalMessageIdentification
                            == (OriginalMessageIdOf(context.Message.Amendment.OriginalBusinessInstruction) ?? string.Empty)
                        || (
                            state.PartyIdentityKey != null
                            && state.PartyIdentityKey == PartyKeyOf(context.Message.Amendment.OriginalActivation)
                        )
                )
        );
        Event(
            () => CancellationRequested,
            x =>
                x.CorrelateBy(
                    (state, context) =>
                        state.OriginalMessageIdentification
                            == (OriginalMessageIdOf(context.Message.Cancellation.OriginalBusinessInstruction) ?? string.Empty)
                        || (
                            state.PartyIdentityKey != null
                            && state.PartyIdentityKey == PartyKeyOf(context.Message.Cancellation.OriginalActivation)
                        )
                )
        );
        Event(
            () => StatusReported,
            x =>
                x.CorrelateBy(
                    (state, context) =>
                        state.LastMessageIdentification
                            == (OriginalMessageIdOf(context.Message.ActivationStatus.OriginalBusinessInstruction) ?? string.Empty)
                        || (
                            state.PartyIdentityKey != null
                            && state.PartyIdentityKey == PartyKeyOf(context.Message.ActivationStatus.OriginalActivationReference)
                        )
                )
        );

        Initially(
            When(ActivationRequested)
                .Then(context =>
                {
                    context.Saga.CreatedUtc = DateTime.UtcNow;
                    context.Saga.OriginalMessageIdentification = context.Message.MessageIdentification;
                    context.Saga.LastMessageIdentification = context.Message.MessageIdentification;
                    context.Saga.PartyIdentityKey = PartyIdentityKey.From(
                        context.Message.Activation.Debtor.Identification
                    );
                    context.Saga.Debtor = context.Message.Activation.Debtor;
                    context.Saga.Creditor = context.Message.Activation.Creditor;
                    context.Saga.DebtorSolutionProvider = context.Message.Activation.DebtorSolutionProvider;
                    context.Saga.UltimateDebtor = context.Message.Activation.UltimateDebtor;
                })
                .TransitionTo(AwaitingActivationResult)
        );

        During(
            AwaitingActivationResult,
            When(StatusReported)
                .IfElse(
                    context => IsAccepted(context.Message.ActivationStatus.Status),
                    accepted =>
                        accepted
                            .Then(context => ApplyStatus(context.Saga, context.Message.ActivationStatus))
                            .TransitionTo(Activated),
                    rejected =>
                        rejected
                            .Then(context => ApplyStatus(context.Saga, context.Message.ActivationStatus))
                            .TransitionTo(Rejected)
                )
        );

        During(
            Activated,
            When(AmendmentRequested)
                .Then(context => context.Saga.LastMessageIdentification = context.Message.MessageIdentification)
                .TransitionTo(AwaitingAmendmentResult),
            When(CancellationRequested)
                .Then(context => context.Saga.LastMessageIdentification = context.Message.MessageIdentification)
                .TransitionTo(AwaitingCancellationResult)
        );

        During(
            AwaitingAmendmentResult,
            When(StatusReported)
                .Then(context => ApplyStatus(context.Saga, context.Message.ActivationStatus))
                .IfElse(
                    context => IsAccepted(context.Message.ActivationStatus.Status),
                    accepted => accepted.TransitionTo(Activated),
                    rejected => rejected.TransitionTo(Rejected)
                )
        );

        During(
            AwaitingCancellationResult,
            When(StatusReported)
                .Then(context => ApplyStatus(context.Saga, context.Message.ActivationStatus))
                .TransitionTo(Cancelled)
        );

        SetCompletedWhenFinalized();
    }

    private static bool IsAccepted(ServiceStatus1Choice_ status) =>
        status is ServiceStatus1Choice.Code { Value: ServiceRequestStatus1Code.Accepted };

    private static void ApplyStatus(DebtorActivationSagaState state, ActivationStatus3 activationStatus)
    {
        state.LastStatus =
            activationStatus.Status is ServiceStatus1Choice.Code { Value: var code } ? code : null;
        state.EffectiveActivationDate = activationStatus.EffectiveActivationDate;
    }

    /// <summary>
    /// Extracts the message id an Amendment/Cancellation/StatusReport references, when present.
    /// Deliberately takes only message data (never the saga <c>state</c>) — see the class-level
    /// remarks on the <see cref="AmendmentRequested"/> event registration for why that matters to
    /// SQL-translatable correlation expressions.
    /// </summary>
    private static string? OriginalMessageIdOf(OriginalBusinessInstruction1? originalBusinessInstruction) =>
        originalBusinessInstruction?.MessageIdentification.Value;

    /// <summary>
    /// Extracts the best-effort party-identity fallback key from an Amendment/Cancellation/
    /// StatusReport's original-activation reference, when derivable. Same "message data only,
    /// never <c>state</c>" rule as <see cref="OriginalMessageIdOf"/>.
    /// </summary>
    private static string? PartyKeyOf(OriginalActivation3Choice_? originalActivation) =>
        originalActivation switch
        {
            OriginalActivation3Choice.OriginalDebtorIdentification { Value: var debtor } =>
                PartyIdentityKey.From(debtor),
            OriginalActivation3Choice.OriginalActivationData { Value: var data } => PartyIdentityKey.From(
                data.Debtor.Identification
            ),
            _ => null,
        };
}
