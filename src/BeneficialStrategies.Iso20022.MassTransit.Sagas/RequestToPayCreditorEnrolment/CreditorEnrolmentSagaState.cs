// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas.RequestToPayCreditorEnrolment;

/// <summary>
/// Saga instance state for one creditor's Request-to-Pay enrolment episode, tracked from the
/// Creditor/Payee RTP Service Provider's own perspective.
/// </summary>
/// <remarks>
/// All business-snapshot fields below are nullable/default-populated at construction and filled
/// in by the state machine's own activities as events arrive — see
/// <see cref="Framework.Iso20022SagaStateBase"/>'s remarks on why this class is an ordinary
/// mutable class, not this project's usual <c>required</c> init-only record convention.
/// </remarks>
public sealed class CreditorEnrolmentSagaState : Framework.Iso20022SagaStateBase
{
    /// <summary>
    /// The Creditor, captured from the initiating <c>CreditorEnrolmentRequested</c> event's
    /// <c>Enrolment.Creditor</c>.
    /// </summary>
    public RTPPartyIdentification2? Creditor { get; set; }

    /// <summary>Captured from the initiating event's <c>Enrolment.MerchantCategoryCode</c>.</summary>
    public MerchantCategoryCodeIdentifier? MerchantCategoryCode { get; set; }

    /// <summary>Captured from the initiating event's <c>Enrolment.UltimateCreditor</c>, when present.</summary>
    public RTPPartyIdentification2? UltimateCreditor { get; set; }

    /// <summary>
    /// The outcome of the most recently processed <c>CreditorEnrolmentStatusReported</c> event.
    /// Deliberately narrowed to the <c>Code</c> variant of <c>ServiceStatus1Choice_</c> — the
    /// <c>Proprietary</c> variant has no ISO-specified closed vocabulary a state graph can branch
    /// on, so a status report using it is recorded here as <see langword="null"/> rather than
    /// interpreted.
    /// </summary>
    public ServiceRequestStatus1Code? LastStatus { get; set; }

    /// <summary>
    /// The effective enrolment date from the most recently processed status report, when
    /// populated. Kept as the raw ISO choice type rather than converted to a single
    /// <see cref="DateTime"/>, to preserve the Date-vs-DateTime distinction the wire format
    /// itself carries.
    /// </summary>
    public DateAndDateTime2Choice_? EffectiveEnrolmentDate { get; set; }

    /// <summary>
    /// Extension point for a caller-supplied review/compliance step. This package never sets or
    /// reads this field itself — the source ISO document does not specify any review/approval
    /// step for this flow. See <c>ReviewRequested</c>/<c>ReviewCompleted</c> on
    /// <see cref="CreditorEnrolmentServiceProviderStateMachine"/>.
    /// </summary>
    public bool? ReviewApproved { get; set; }

    /// <summary>See <see cref="ReviewApproved"/>.</summary>
    public string? ReviewNote { get; set; }
}
