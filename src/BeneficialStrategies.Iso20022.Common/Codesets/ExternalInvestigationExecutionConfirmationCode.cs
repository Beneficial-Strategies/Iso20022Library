// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the result of an investigation, as published in an external investigation execution confirmation code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RNLFpYmxEeeKR__nUfxjwA")]
[Description(
    @"Specifies the result of an investigation, as published in an external investigation execution confirmation code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationExecutionConfirmation1Code))]
public enum ExternalInvestigationExecutionConfirmationCode
{
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_RNLFqImxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest,

    /// <summary>
    /// Used when a requested modification is successful.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_RNLFr4mxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested modification is successful.")]
    ModifiedAsPerRequest,

    /// <summary>
    /// Used when a creditor accepts the debit authorisation.
    /// Encoded/decoded by serializers as &quot;ACDA&quot;.
    /// </summary>
    [EnumMember(Value = "ACDA")]
    [IsoId("_RNLFtImxEeeKR__nUfxjwA")]
    [Description(@"Used when a creditor accepts the debit authorisation.")]
    AcceptedDebitAuthorisation,

    /// <summary>
    /// Used when the result of an investigation is, or will be, the initiation of a payment instruction.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_RNLFuImxEeeKR__nUfxjwA")]
    [Description(
        @"Used when the result of an investigation is, or will be, the initiation of a payment instruction."
    )]
    PaymentInitiated,

    /// <summary>
    /// Used when a transfer of funds has been initiated (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;ICOV&quot;.
    /// </summary>
    [EnumMember(Value = "ICOV")]
    [IsoId("_RNLFpomxEeeKR__nUfxjwA")]
    [Description(
        @"Used when a transfer of funds has been initiated (a cover payment) to resolve a case."
    )]
    CoverInitiated,

    /// <summary>
    /// Used when a transfer of funds has been modified (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;MCOV&quot;.
    /// </summary>
    [EnumMember(Value = "MCOV")]
    [IsoId("_RNLFtYmxEeeKR__nUfxjwA")]
    [Description(
        @"Used when a transfer of funds has been modified (a cover payment) to resolve a case."
    )]
    CoverModified,

    /// <summary>
    /// Used when a payment instruction (eg. MT103) has been initiated to resolve a case.
    /// Encoded/decoded by serializers as &quot;IPYI&quot;.
    /// </summary>
    [EnumMember(Value = "IPYI")]
    [IsoId("_RNLFp4mxEeeKR__nUfxjwA")]
    [Description(
        @"Used when a payment instruction (eg. MT103) has been initiated to resolve a case."
    )]
    PaymentInstructionInitiated,

    /// <summary>
    /// Used when additional information has been sent to the beneficiary of a payment.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_RNLFuYmxEeeKR__nUfxjwA")]
    [Description(
        @"Used when additional information has been sent to the beneficiary of a payment."
    )]
    AdditionalInformationSent,

    /// <summary>
    /// Used when a payment has been checked and was correctly executed without any intervention.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_RNLFqomxEeeKR__nUfxjwA")]
    [Description(
        @"Used when a payment has been checked and was correctly executed without any intervention."
    )]
    ConfirmationOfPayment,

    /// <summary>
    /// Used when a payment will be cancelled to solve an investigation case.
    /// Encoded/decoded by serializers as &quot;CWFW&quot;.
    /// </summary>
    [EnumMember(Value = "CWFW")]
    [IsoId("_RNLFromxEeeKR__nUfxjwA")]
    [Description(@"Used when a payment will be cancelled to solve an investigation case.")]
    CancellationWillFollow,

    /// <summary>
    /// Used when the payment will be modified to solve an investigation case.
    /// Encoded/decoded by serializers as &quot;MWFW&quot;.
    /// </summary>
    [EnumMember(Value = "MWFW")]
    [IsoId("_RNLFsYmxEeeKR__nUfxjwA")]
    [Description(@"Used when the payment will be modified to solve an investigation case.")]
    ModificationWillFollow,

    /// <summary>
    /// Used when sender wants to respond to an assignment with an Unable To Apply workflow.
    /// Encoded/decoded by serializers as &quot;UWFW&quot;.
    /// </summary>
    [EnumMember(Value = "UWFW")]
    [IsoId("_RNLFsImxEeeKR__nUfxjwA")]
    [Description(
        @"Used when sender wants to respond to an assignment with an Unable To Apply workflow."
    )]
    UnableToApplyWillFollow,

    /// <summary>
    /// Used when a requested cancellation has been partially executed.
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_RNLFs4mxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested cancellation has been partially executed.")]
    PartiallyExecutedCancellationRequest,

    /// <summary>
    /// Used when a requested cancellation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_RNLFsomxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested cancellation has been rejected.")]
    RejectedCancellationRequest,

    /// <summary>
    /// Used when a requested cancellation is pending.
    /// Encoded/decoded by serializers as &quot;PDCR&quot;.
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_RNLFtomxEeeKR__nUfxjwA")]
    [Description(@"Used when a requested cancellation is pending.")]
    PendingCancellationRequest,

    /// <summary>
    /// Used when the entry in the statement is correct.
    /// Encoded/decoded by serializers as &quot;SMTC&quot;.
    /// </summary>
    [EnumMember(Value = "SMTC")]
    [IsoId("_RNLFq4mxEeeKR__nUfxjwA")]
    [Description(@"Used when the entry in the statement is correct.")]
    StatementEntryCorrect,

    /// <summary>
    /// Used when the entry in the statement is incorrect and further information is provided with the resolution.
    /// Encoded/decoded by serializers as &quot;SMTI&quot;.
    /// </summary>
    [EnumMember(Value = "SMTI")]
    [IsoId("_RNLFt4mxEeeKR__nUfxjwA")]
    [Description(
        @"Used when the entry in the statement is incorrect and further information is provided with the resolution."
    )]
    StatementEntryIncorrect,

    /// <summary>
    /// Further charges details are provided to resolve the case.
    /// Encoded/decoded by serializers as &quot;CHRG&quot;.
    /// </summary>
    [EnumMember(Value = "CHRG")]
    [IsoId("_RNLFrImxEeeKR__nUfxjwA")]
    [Description(@"Further charges details are provided to resolve the case.")]
    ChargesDetailsProvided,

    /// <summary>
    /// Further purpose details are provided to resolve the case.
    /// Encoded/decoded by serializers as &quot;PURP&quot;.
    /// </summary>
    [EnumMember(Value = "PURP")]
    [IsoId("_RNLFrYmxEeeKR__nUfxjwA")]
    [Description(@"Further purpose details are provided to resolve the case.")]
    PurposeDetailsProvided,

    /// <summary>
    /// Used when the requested check for a possible duplicate instruction is confirmed.
    /// Encoded/decoded by serializers as &quot;IDUP&quot;.
    /// </summary>
    [EnumMember(Value = "IDUP")]
    [IsoId("_RNLFqYmxEeeKR__nUfxjwA")]
    [Description(
        @"Used when the requested check for a possible duplicate instruction is confirmed."
    )]
    InstructionIsDuplicate,

    /// <summary>
    /// The claim for non-receipt of a payment instruction is accepted.
    /// Encoded/decoded by serializers as &quot;ACNR&quot;.
    /// </summary>
    [EnumMember(Value = "ACNR")]
    [IsoId("_uZRepvRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for non-receipt of a payment instruction is accepted.")]
    AcceptedClaimNonReceipt,

    /// <summary>
    /// The claim for value date correction is accepted.
    /// Encoded/decoded by serializers as &quot;ACVA&quot;.
    /// </summary>
    [EnumMember(Value = "ACVA")]
    [IsoId("_uZaokPRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for value date correction is accepted.")]
    AcceptedValueDateAdjustment,

    /// <summary>
    /// The original value date was correct.
    /// Encoded/decoded by serializers as &quot;CVAA&quot;.
    /// </summary>
    [EnumMember(Value = "CVAA")]
    [IsoId("_uZkZkPRYEeuLhpyIdtJzwg")]
    [Description(@"The original value date was correct.")]
    CorrectValueDateAlreadyApplied,

    /// <summary>
    /// The cancellation request has been forwarded to the next agent for execution.|Usage: This code should only be utilised where a Case Id is not present.
    /// Encoded/decoded by serializers as &quot;FTNA&quot;.
    /// </summary>
    [EnumMember(Value = "FTNA")]
    [IsoId("_uZkZlvRYEeuLhpyIdtJzwg")]
    [Description(
        @"The cancellation request has been forwarded to the next agent for execution.|Usage: This code should only be utilised where a Case Id is not present."
    )]
    CancellationRequestForwardedToTheNextAgent,

    /// <summary>
    /// The claim for non-receipt of a payment instruction is rejected.
    /// Encoded/decoded by serializers as &quot;RJNR&quot;.
    /// </summary>
    [EnumMember(Value = "RJNR")]
    [IsoId("_uaKPcPRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for non-receipt of a payment instruction is rejected.")]
    RejectedClaimNonReceipt,

    /// <summary>
    /// The claim for value date correction is rejected.
    /// Encoded/decoded by serializers as &quot;RJVA&quot;.
    /// </summary>
    [EnumMember(Value = "RJVA")]
    [IsoId("_uaKPc_RYEeuLhpyIdtJzwg")]
    [Description(@"The claim for value date correction is rejected.")]
    RejectedValueDateAdjustment,

    /// <summary>
    /// Process a  Batch Cancellation &quot;using an incorrect batch sequence number”.
    /// Encoded/decoded by serializers as &quot;IDNE&quot;.
    /// </summary>
    [EnumMember(Value = "IDNE")]
    [IsoId("_4MHTIATqEey95qpfbNuEwg")]
    [Description(@"Process a  Batch Cancellation ""using an incorrect batch sequence number”.")]
    InstructionDoesNotExist,

    /// <summary>
    /// Process a cancellation request with incorrect reference to original batch.
    /// Encoded/decoded by serializers as &quot;IVCR&quot;.
    /// </summary>
    [EnumMember(Value = "IVCR")]
    [IsoId("_DehbgATrEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request with incorrect reference to original batch.")]
    InvalidCancellationRequest,

    /// <summary>
    /// Process a cancellation request but batch already settled.
    /// Encoded/decoded by serializers as &quot;BIAS&quot;.
    /// </summary>
    [EnumMember(Value = "BIAS")]
    [IsoId("_NHI7kATrEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request but batch already settled.")]
    BatchInstructionAlreadySettled,

    /// <summary>
    /// Used when no additional information is available.
    /// Encoded/decoded by serializers as &quot;NINF&quot;.
    /// </summary>
    [EnumMember(Value = "NINF")]
    [IsoId("_pWiy8CemEe2VkIu7jTuNaA")]
    [Description(@"Used when no additional information is available.")]
    NoInformationAvailable,

    /// <summary>
    /// Used to inform that a response to an investigation is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_H78O8CenEe2VkIu7jTuNaA")]
    [Description(@"Used to inform that a response to an investigation is pending.")]
    Pending,
}
