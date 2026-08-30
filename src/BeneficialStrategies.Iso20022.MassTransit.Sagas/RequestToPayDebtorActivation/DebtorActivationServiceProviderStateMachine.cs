// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.MassTransit.Sagas.RequestToPayDebtorActivation.Events;
using ServiceStatus1Choice = BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;
using OriginalActivation3Choice = BeneficialStrategies.Iso20022.Choices.OriginalActivation3Choice;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.RequestToPayDebtorActivation;

/// <summary>
/// Tracks one debtor's Request-to-Pay activation episode from the Debtor/Payer RTP Service
/// Provider's own perspective. Mirrors
/// <see cref="MassTransit.Sagas.RequestToPayCreditorEnrolment.CreditorEnrolmentServiceProviderStateMachine"/>'s
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

        Event(
            () => AmendmentRequested,
            x =>
                x.CorrelateBy(
                    (state, context) =>
                        MatchesEpisode(
                            state,
                            context.Message.Amendment.OriginalBusinessInstruction,
                            context.Message.Amendment.OriginalActivation
                        )
                )
        );
        Event(
            () => CancellationRequested,
            x =>
                x.CorrelateBy(
                    (state, context) =>
                        MatchesEpisode(
                            state,
                            context.Message.Cancellation.OriginalBusinessInstruction,
                            context.Message.Cancellation.OriginalActivation
                        )
                )
        );
        Event(
            () => StatusReported,
            x =>
                x.CorrelateBy(
                    (state, context) =>
                        MatchesLastRequest(
                            state,
                            context.Message.ActivationStatus.OriginalBusinessInstruction,
                            context.Message.ActivationStatus.OriginalActivationReference
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
    /// Matches an Amendment/Cancellation event to an existing saga instance. See the Creditor
    /// Enrolment state machine's identical method for the rationale — these messages identify the
    /// activation episode itself, so they correlate against
    /// <see cref="DebtorActivationSagaState.OriginalMessageIdentification"/>, never
    /// <see cref="DebtorActivationSagaState.LastMessageIdentification"/>.
    /// </summary>
    private static bool MatchesEpisode(
        DebtorActivationSagaState state,
        OriginalBusinessInstruction1? originalBusinessInstruction,
        OriginalActivation3Choice_? originalActivation
    )
    {
        if (
            originalBusinessInstruction is not null
            && state.OriginalMessageIdentification == originalBusinessInstruction.MessageIdentification.Value
        )
        {
            return true;
        }

        return PartyKeyMatches(state, originalActivation);
    }

    /// <summary>
    /// Matches a StatusReport event to an existing saga instance — correlates against
    /// <see cref="DebtorActivationSagaState.LastMessageIdentification"/>, the most recent
    /// request-type message's id. See the Creditor Enrolment state machine's identical method.
    /// </summary>
    private static bool MatchesLastRequest(
        DebtorActivationSagaState state,
        OriginalBusinessInstruction1? originalBusinessInstruction,
        OriginalActivation3Choice_? originalActivation
    )
    {
        if (
            originalBusinessInstruction is not null
            && state.LastMessageIdentification == originalBusinessInstruction.MessageIdentification.Value
        )
        {
            return true;
        }

        return PartyKeyMatches(state, originalActivation);
    }

    private static bool PartyKeyMatches(
        DebtorActivationSagaState state,
        OriginalActivation3Choice_? originalActivation
    )
    {
        var partyKey = originalActivation switch
        {
            OriginalActivation3Choice.OriginalDebtorIdentification { Value: var debtor } =>
                PartyIdentityKey.From(debtor),
            OriginalActivation3Choice.OriginalActivationData { Value: var data } => PartyIdentityKey.From(
                data.Debtor.Identification
            ),
            _ => null,
        };

        return partyKey is not null && state.PartyIdentityKey == partyKey;
    }
}
