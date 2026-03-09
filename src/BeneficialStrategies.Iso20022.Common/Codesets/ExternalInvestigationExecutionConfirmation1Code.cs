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
[IsoId("_iF0dsImxEeeKR__nUfxjwA")]
[Description(@"Specifies the result of an investigation, as published in an external investigation execution confirmation code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalInvestigationExecutionConfirmationCode))]
public enum ExternalInvestigationExecutionConfirmation1Code
{
    /// <summary>
    /// Used when a creditor accepts the debit authorisation.
    /// Encoded/decoded by serializers as &quot;ACDA&quot;.
    /// </summary>
    [EnumMember(Value = "ACDA")]
    [IsoId("_uZRepfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a creditor accepts the debit authorisation.")]
    AcceptedDebitAuthorisation = ExternalInvestigationExecutionConfirmationCode.AcceptedDebitAuthorisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The claim for non-receipt of a payment instruction is accepted.
    /// Encoded/decoded by serializers as &quot;ACNR&quot;.
    /// </summary>
    [EnumMember(Value = "ACNR")]
    [IsoId("_uZReqPRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for non-receipt of a payment instruction is accepted.")]
    AcceptedClaimNonReceipt = ExternalInvestigationExecutionConfirmationCode.AcceptedClaimNonReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The claim for value date correction is accepted.
    /// Encoded/decoded by serializers as &quot;ACVA&quot;.
    /// </summary>
    [EnumMember(Value = "ACVA")]
    [IsoId("_uZaokvRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for value date correction is accepted.")]
    AcceptedValueDateAdjustment = ExternalInvestigationExecutionConfirmationCode.AcceptedValueDateAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Further charges details are provided to resolve the case.
    /// Encoded/decoded by serializers as &quot;CHRG&quot;.
    /// </summary>
    [EnumMember(Value = "CHRG")]
    [IsoId("_uZaolfRYEeuLhpyIdtJzwg")]
    [Description(@"Further charges details are provided to resolve the case.")]
    ChargesDetailsProvided = ExternalInvestigationExecutionConfirmationCode.ChargesDetailsProvided, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_uZaomPRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest = ExternalInvestigationExecutionConfirmationCode.CancelledAsPerRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a payment has been checked and was correctly executed without any intervention.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uZaom_RYEeuLhpyIdtJzwg")]
    [Description(@"Used when a payment has been checked and was correctly executed without any intervention.")]
    ConfirmationOfPayment = ExternalInvestigationExecutionConfirmationCode.ConfirmationOfPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The original value date was correct.
    /// Encoded/decoded by serializers as &quot;CVAA&quot;.
    /// </summary>
    [EnumMember(Value = "CVAA")]
    [IsoId("_uZkZkvRYEeuLhpyIdtJzwg")]
    [Description(@"The original value date was correct.")]
    CorrectValueDateAlreadyApplied = ExternalInvestigationExecutionConfirmationCode.CorrectValueDateAlreadyApplied, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a payment will be cancelled to solve an investigation case.
    /// Encoded/decoded by serializers as &quot;CWFW&quot;.
    /// </summary>
    [EnumMember(Value = "CWFW")]
    [IsoId("_uZkZlfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a payment will be cancelled to solve an investigation case.")]
    CancellationWillFollow = ExternalInvestigationExecutionConfirmationCode.CancellationWillFollow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The cancellation request has been forwarded to the next agent for execution.|Usage: This code should only be utilised where a Case Id is not present.
    /// Encoded/decoded by serializers as &quot;FTNA&quot;.
    /// </summary>
    [EnumMember(Value = "FTNA")]
    [IsoId("_uZkZmPRYEeuLhpyIdtJzwg")]
    [Description(@"The cancellation request has been forwarded to the next agent for execution.|Usage: This code should only be utilised where a Case Id is not present.")]
    CancellationRequestForwardedToTheNextAgent = ExternalInvestigationExecutionConfirmationCode.CancellationRequestForwardedToTheNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a transfer of funds has been initiated (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;ICOV&quot;.
    /// </summary>
    [EnumMember(Value = "ICOV")]
    [IsoId("_uZkZm_RYEeuLhpyIdtJzwg")]
    [Description(@"Used when a transfer of funds has been initiated (a cover payment) to resolve a case.")]
    CoverInitiated = ExternalInvestigationExecutionConfirmationCode.CoverInitiated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the requested check for a possible duplicate instruction is confirmed.
    /// Encoded/decoded by serializers as &quot;IDUP&quot;.
    /// </summary>
    [EnumMember(Value = "IDUP")]
    [IsoId("_uZuKkvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the requested check for a possible duplicate instruction is confirmed.")]
    InstructionIsDuplicate = ExternalInvestigationExecutionConfirmationCode.InstructionIsDuplicate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the result of an investigation is, or will be, the initiation of a payment instruction.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_uZuKmPRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the result of an investigation is, or will be, the initiation of a payment instruction.")]
    PaymentInitiated = ExternalInvestigationExecutionConfirmationCode.PaymentInitiated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a payment instruction (eg. MT103) has been initiated to resolve a case.
    /// Encoded/decoded by serializers as &quot;IPYI&quot;.
    /// </summary>
    [EnumMember(Value = "IPYI")]
    [IsoId("_uZuKm_RYEeuLhpyIdtJzwg")]
    [Description(@"Used when a payment instruction (eg. MT103) has been initiated to resolve a case.")]
    PaymentInstructionInitiated = ExternalInvestigationExecutionConfirmationCode.PaymentInstructionInitiated, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a transfer of funds has been modified (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;MCOV&quot;.
    /// </summary>
    [EnumMember(Value = "MCOV")]
    [IsoId("_uZuKnvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a transfer of funds has been modified (a cover payment) to resolve a case.")]
    CoverModified = ExternalInvestigationExecutionConfirmationCode.CoverModified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested modification is successful.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_uZ3UgvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested modification is successful.")]
    ModifiedAsPerRequest = ExternalInvestigationExecutionConfirmationCode.ModifiedAsPerRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the payment will be modified to solve an investigation case.
    /// Encoded/decoded by serializers as &quot;MWFW&quot;.
    /// </summary>
    [EnumMember(Value = "MWFW")]
    [IsoId("_uZ3UhfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the payment will be modified to solve an investigation case.")]
    ModificationWillFollow = ExternalInvestigationExecutionConfirmationCode.ModificationWillFollow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation is pending.
    /// Encoded/decoded by serializers as &quot;PDCR&quot;.
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_uaBFgvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested cancellation is pending.")]
    PendingCancellationRequest = ExternalInvestigationExecutionConfirmationCode.PendingCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation has been partially executed.
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_uaBFhfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested cancellation has been partially executed.")]
    PartiallyExecutedCancellationRequest = ExternalInvestigationExecutionConfirmationCode.PartiallyExecutedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Further purpose details are provided to resolve the case.
    /// Encoded/decoded by serializers as &quot;PURP&quot;.
    /// </summary>
    [EnumMember(Value = "PURP")]
    [IsoId("_uaBFiPRYEeuLhpyIdtJzwg")]
    [Description(@"Further purpose details are provided to resolve the case.")]
    PurposeDetailsProvided = ExternalInvestigationExecutionConfirmationCode.PurposeDetailsProvided, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when a requested cancellation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_uaBFi_RYEeuLhpyIdtJzwg")]
    [Description(@"Used when a requested cancellation has been rejected.")]
    RejectedCancellationRequest = ExternalInvestigationExecutionConfirmationCode.RejectedCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The claim for non-receipt of a payment instruction is rejected.
    /// Encoded/decoded by serializers as &quot;RJNR&quot;.
    /// </summary>
    [EnumMember(Value = "RJNR")]
    [IsoId("_uaKPcvRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for non-receipt of a payment instruction is rejected.")]
    RejectedClaimNonReceipt = ExternalInvestigationExecutionConfirmationCode.RejectedClaimNonReceipt, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The claim for value date correction is rejected.
    /// Encoded/decoded by serializers as &quot;RJVA&quot;.
    /// </summary>
    [EnumMember(Value = "RJVA")]
    [IsoId("_uaKPdfRYEeuLhpyIdtJzwg")]
    [Description(@"The claim for value date correction is rejected.")]
    RejectedValueDateAdjustment = ExternalInvestigationExecutionConfirmationCode.RejectedValueDateAdjustment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the entry in the statement is correct.
    /// Encoded/decoded by serializers as &quot;SMTC&quot;.
    /// </summary>
    [EnumMember(Value = "SMTC")]
    [IsoId("_uaUAcvRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the entry in the statement is correct.")]
    StatementEntryCorrect = ExternalInvestigationExecutionConfirmationCode.StatementEntryCorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when the entry in the statement is incorrect and further information is provided with the resolution.
    /// Encoded/decoded by serializers as &quot;SMTI&quot;.
    /// </summary>
    [EnumMember(Value = "SMTI")]
    [IsoId("_uaUAdfRYEeuLhpyIdtJzwg")]
    [Description(@"Used when the entry in the statement is incorrect and further information is provided with the resolution.")]
    StatementEntryIncorrect = ExternalInvestigationExecutionConfirmationCode.StatementEntryIncorrect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when sender wants to respond to an assignment with an Unable To Apply workflow.
    /// Encoded/decoded by serializers as &quot;UWFW&quot;.
    /// </summary>
    [EnumMember(Value = "UWFW")]
    [IsoId("_uaUAePRYEeuLhpyIdtJzwg")]
    [Description(@"Used when sender wants to respond to an assignment with an Unable To Apply workflow.")]
    UnableToApplyWillFollow = ExternalInvestigationExecutionConfirmationCode.UnableToApplyWillFollow, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Process a cancellation request but batch already settled.
    /// Encoded/decoded by serializers as &quot;BIAS&quot;.
    /// </summary>
    [EnumMember(Value = "BIAS")]
    [IsoId("_eSPVoQTrEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request but batch already settled.")]
    BatchInstructionAlreadySettled = ExternalInvestigationExecutionConfirmationCode.BatchInstructionAlreadySettled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Process a  Batch Cancellation &quot;using an incorrect batch sequence number”.
    /// Encoded/decoded by serializers as &quot;IDNE&quot;.
    /// </summary>
    [EnumMember(Value = "IDNE")]
    [IsoId("_ekkbwQTrEey95qpfbNuEwg")]
    [Description(@"Process a  Batch Cancellation ""using an incorrect batch sequence number”.")]
    InstructionDoesNotExist = ExternalInvestigationExecutionConfirmationCode.InstructionDoesNotExist, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Process a cancellation request with incorrect reference to original batch.
    /// Encoded/decoded by serializers as &quot;IVCR&quot;.
    /// </summary>
    [EnumMember(Value = "IVCR")]
    [IsoId("_erSHwQTrEey95qpfbNuEwg")]
    [Description(@"Process a cancellation request with incorrect reference to original batch.")]
    InvalidCancellationRequest = ExternalInvestigationExecutionConfirmationCode.InvalidCancellationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when additional information has been sent to the beneficiary of a payment.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_G4loYRRyEeyk6Lq9x6ij-w")]
    [Description(@"Used when additional information has been sent to the beneficiary of a payment.")]
    AdditionalInformationSent = ExternalInvestigationExecutionConfirmationCode.AdditionalInformationSent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used when no additional information is available.
    /// Encoded/decoded by serializers as &quot;NINF&quot;.
    /// </summary>
    [EnumMember(Value = "NINF")]
    [IsoId("_pWiy8iemEe2VkIu7jTuNaA")]
    [Description(@"Used when no additional information is available.")]
    NoInformationAvailable = ExternalInvestigationExecutionConfirmationCode.NoInformationAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Used to inform that a response to an investigation is pending.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_H78O8ienEe2VkIu7jTuNaA")]
    [Description(@"Used to inform that a response to an investigation is pending.")]
    Pending = ExternalInvestigationExecutionConfirmationCode.Pending, // same ordinal as derivation source for type conversions
    
}
