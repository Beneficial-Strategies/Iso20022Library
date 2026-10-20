// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment.Events;
using ServiceStatus1Choice = BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;
using OriginalEnrolment3Choice = BeneficialStrategies.Iso20022.Choices.OriginalEnrolment3Choice;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayCreditorEnrolment;

/// <summary>
/// Tracks one creditor's Request-to-Pay enrolment episode from the Creditor/Payee RTP Service
/// Provider's own perspective — the one actor in the Creditor Enrolment sub-process (per the
/// source ISO 20022 Message Definition Report's sequence diagrams) that genuinely needs
/// multi-message lifecycle tracking. The Directory Provider and the Creditor/Payee's own
/// originating system are reactive pass-throughs in the source document and are not modeled here.
/// </summary>
/// <remarks>
/// State graph derived from the RTP Service Request-to-Pay MDR Part 1 (Creditor Enrolment
/// sub-process, section 5.1/6.1) — <c>AwaitingEnrolmentResult</c>/<c>Enrolled</c>/<c>Rejected</c>
/// map to the document's own Request→StatusReport pattern; the Amendment/Cancellation states
/// mirror the same pattern since the document's own diagrams show Amendment and Cancellation
/// sharing the identical message-flow shape as the initial Request. Two things are deliberately
/// left unimplemented rather than invented: outbound forwarding (sending the request on to the
/// Directory Provider is real integration logic specific to a deployment's topology) and
/// <see cref="ReviewRequested"/>/<see cref="ReviewCompleted"/> (the source document does not
/// specify any review/approval/compliance step for this flow — these are named hook points with
/// zero logic, not something claimed to be "from the standard").
/// </remarks>
public sealed class CreditorEnrolmentServiceProviderStateMachine
    : MassTransitStateMachine<CreditorEnrolmentSagaState>
{
    // ---- States ----
    public State AwaitingEnrolmentResult { get; private set; } = null!;
    public State Enrolled { get; private set; } = null!;
    public State Rejected { get; private set; } = null!;
    public State AwaitingAmendmentResult { get; private set; } = null!;
    public State AwaitingCancellationResult { get; private set; } = null!;
    public State Cancelled { get; private set; } = null!;

    // ---- Named-but-empty extension-point events. See class-level remarks: nothing in this
    // package populates or reacts to these — a consumer of this toolkit wires their own
    // activities to them if their deployment needs a review/approval/OFAC-style step here. ----

    /// <summary>
    /// Extension point only — never raised or consumed by this package. A caller may bind their
    /// own review/compliance activity to this event. Payload is
    /// <see cref="Framework.ReviewRequestedMessage"/> — a minimal placeholder (just the saga
    /// <c>CorrelationId</c>), not derived from the ISO spec; MassTransit requires a concrete
    /// message type here (a bare <c>object</c> is rejected at state-machine construction time), so
    /// this exists to give the hook a real type rather than leaving it undeclared. A caller
    /// needing richer review context defines and publishes their own event instead.
    /// </summary>
    public Event<Framework.ReviewRequestedMessage> ReviewRequested { get; private set; } = null!;

    /// <summary>See <see cref="ReviewRequested"/>.</summary>
    public Event<Framework.ReviewCompletedMessage> ReviewCompleted { get; private set; } = null!;

    // ---- Events correlated to the 4 fan-out event types ----
    public Event<CreditorEnrolmentRequested> EnrolmentRequested { get; private set; } = null!;
    public Event<CreditorEnrolmentAmendmentRequested> AmendmentRequested { get; private set; } = null!;
    public Event<CreditorEnrolmentCancellationRequested> CancellationRequested { get; private set; } = null!;
    public Event<CreditorEnrolmentStatusReported> StatusReported { get; private set; } = null!;

    public CreditorEnrolmentServiceProviderStateMachine()
    {
        InstanceState(x => x.CurrentState);

        // The initiating event: always starts a brand-new saga instance with a synthesized id.
        // ISO 20022 has no equivalent identifier for this message family — see Framework/Iso20022SagaStateBase.cs.
        Event(() => EnrolmentRequested, x => x.SelectId(context => NewId.NextGuid()));

        // Every subsequent event correlates via a custom predicate against stored
        // LastMessageIdentification/PartyIdentityKey — never a shared ISO business-transaction
        // id, because none exists.
        //
        // IMPORTANT for implementers: CorrelateBy((state, ctx) => bool) takes an
        // Expression<Func<TSaga, ConsumeContext<TMessage>, bool>> — a real EF Core-backed saga
        // repository (EntityFrameworkSagaRepository) pushes this down to SQL via IQueryable, not
        // just compiles-and-invokes it the way the in-memory repository does. That means every
        // sub-expression touching `state` must be plain property/member access the SQL translator
        // can understand directly — NOT a call to a helper method that takes `state` as an
        // argument. A method call like `Matches(state, ...)` is an opaque node to the translator:
        // it can't see that only a trivial comparison inside actually depends on `state`, so the
        // whole expression is rejected with "could not be translated" at runtime (confirmed against
        // real MySQL while building the RequestToPayDebtorActivation.Demo app — the in-memory-only
        // test suite never caught this, since compiling-and-invoking has no such restriction).
        // The fix used throughout this file: keep every `state.X == ...` comparison INLINE in the
        // lambda, and only call out to a helper (OriginalMessageIdOf/PartyKeyOf below) for the
        // context-only value production — those helpers take just the message data, never `state`,
        // so MassTransit's own partial evaluation can fold them to plain constants before the
        // translator ever sees them.
        Event(
            () => AmendmentRequested,
            x =>
                x.CorrelateBy(
                    (state, context) =>
                        state.OriginalMessageIdentification
                            == (OriginalMessageIdOf(context.Message.Amendment.OriginalBusinessInstruction) ?? string.Empty)
                        || (
                            state.PartyIdentityKey != null
                            && state.PartyIdentityKey == PartyKeyOf(context.Message.Amendment.OriginalEnrolment)
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
                            && state.PartyIdentityKey == PartyKeyOf(context.Message.Cancellation.OriginalEnrolment)
                        )
                )
        );
        Event(
            () => StatusReported,
            x =>
                x.CorrelateBy(
                    (state, context) =>
                        state.LastMessageIdentification
                            == (OriginalMessageIdOf(context.Message.EnrolmentStatus.OriginalBusinessInstruction) ?? string.Empty)
                        || (
                            state.PartyIdentityKey != null
                            && state.PartyIdentityKey == PartyKeyOf(context.Message.EnrolmentStatus.OriginalEnrolmentReference)
                        )
                )
        );

        Initially(
            When(EnrolmentRequested)
                .Then(context =>
                {
                    context.Saga.CreatedUtc = DateTime.UtcNow;
                    context.Saga.OriginalMessageIdentification = context.Message.MessageIdentification;
                    context.Saga.LastMessageIdentification = context.Message.MessageIdentification;
                    context.Saga.PartyIdentityKey = PartyIdentityKey.From(
                        context.Message.Enrolment.Creditor.Identification
                    );
                    context.Saga.Creditor = context.Message.Enrolment.Creditor;
                    context.Saga.MerchantCategoryCode = context.Message.Enrolment.MerchantCategoryCode;
                    context.Saga.UltimateCreditor = context.Message.Enrolment.UltimateCreditor;
                })
                .TransitionTo(AwaitingEnrolmentResult)
        );

        During(
            AwaitingEnrolmentResult,
            When(StatusReported)
                .IfElse(
                    context => IsAccepted(context.Message.EnrolmentStatus.Status),
                    accepted =>
                        accepted
                            .Then(context => ApplyStatus(context.Saga, context.Message.EnrolmentStatus))
                            .TransitionTo(Enrolled),
                    rejected =>
                        rejected
                            .Then(context => ApplyStatus(context.Saga, context.Message.EnrolmentStatus))
                            .TransitionTo(Rejected)
                )
        );

        During(
            Enrolled,
            When(AmendmentRequested)
                .Then(context => context.Saga.LastMessageIdentification = context.Message.MessageIdentification)
                .TransitionTo(AwaitingAmendmentResult),
            When(CancellationRequested)
                .Then(context => context.Saga.LastMessageIdentification = context.Message.MessageIdentification)
                .TransitionTo(AwaitingCancellationResult)
        );

        // An amendment's own result folds back into Enrolled/Rejected — the source document
        // treats Amendment as reusing the same Request/StatusReport flow shape, not a separate
        // terminal outcome.
        During(
            AwaitingAmendmentResult,
            When(StatusReported)
                .Then(context => ApplyStatus(context.Saga, context.Message.EnrolmentStatus))
                .IfElse(
                    context => IsAccepted(context.Message.EnrolmentStatus.Status),
                    accepted => accepted.TransitionTo(Enrolled),
                    rejected => rejected.TransitionTo(Rejected)
                )
        );

        During(
            AwaitingCancellationResult,
            When(StatusReported)
                .Then(context => ApplyStatus(context.Saga, context.Message.EnrolmentStatus))
                .TransitionTo(Cancelled)
        );

        SetCompletedWhenFinalized();
    }

    /// <summary>
    /// True when <paramref name="status"/> carries the <c>Code</c> variant with
    /// <see cref="ServiceRequestStatus1Code.Accepted"/>. Any other shape (the <c>Proprietary</c>
    /// variant, or a <c>Rejected</c> code) is treated as not-accepted — see
    /// <see cref="CreditorEnrolmentSagaState.LastStatus"/>'s own remarks on why <c>Proprietary</c>
    /// isn't interpreted.
    /// </summary>
    private static bool IsAccepted(ServiceStatus1Choice_ status) =>
        status is ServiceStatus1Choice.Code { Value: ServiceRequestStatus1Code.Accepted };

    private static void ApplyStatus(CreditorEnrolmentSagaState state, EnrolmentStatus3 enrolmentStatus)
    {
        state.LastStatus =
            enrolmentStatus.Status is ServiceStatus1Choice.Code { Value: var code } ? code : null;
        state.EffectiveEnrolmentDate = enrolmentStatus.EffectiveEnrolmentDate;
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
    /// StatusReport's original-enrolment reference, when derivable. Same "message data only, never
    /// <c>state</c>" rule as <see cref="OriginalMessageIdOf"/>. See
    /// <see cref="Framework.PartyIdentityKey"/>'s remarks on why this path is best-effort.
    /// </summary>
    private static string? PartyKeyOf(OriginalEnrolment3Choice_? originalEnrolment) =>
        originalEnrolment switch
        {
            OriginalEnrolment3Choice.OriginalCreditorIdentification { Value: var creditor } =>
                PartyIdentityKey.From(creditor),
            OriginalEnrolment3Choice.OriginalEnrolmentData { Value: var data } => PartyIdentityKey.From(
                data.Creditor.Identification
            ),
            _ => null,
        };
}
