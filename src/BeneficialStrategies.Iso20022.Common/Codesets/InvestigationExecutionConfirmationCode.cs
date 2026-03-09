// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the result of an investigation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_abdQQtp-Ed-ak6NoX_4Aeg_-1445551000")]
[Description(@"Indicates the result of an investigation.")]
[Derivations(typeof(InvestigationExecutionConfirmation4Code),typeof(InvestigationExecutionConfirmation1Code),typeof(InvestigationExecutionConfirmation5Code),typeof(InvestigationExecutionConfirmation2Code),typeof(InvestigationExecutionConfirmation3Code))]
public enum InvestigationExecutionConfirmationCode
{
    /// <summary>
    /// Used when a requested cancellation is successful.
    /// Encoded/decoded by serializers as &quot;CNCL&quot;.
    /// </summary>
    [EnumMember(Value = "CNCL")]
    [IsoId("_abdQQ9p-Ed-ak6NoX_4Aeg_1725755237")]
    [Description(@"Used when a requested cancellation is successful.")]
    CancelledAsPerRequest,
    
    /// <summary>
    /// Used when a requested modification is successful.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_abdQRNp-Ed-ak6NoX_4Aeg_1725755280")]
    [Description(@"Used when a requested modification is successful.")]
    ModifiedAsPerRequest,
    
    /// <summary>
    /// Used when a creditor accepts the debit authorisation.
    /// Encoded/decoded by serializers as &quot;ACDA&quot;.
    /// </summary>
    [EnumMember(Value = "ACDA")]
    [IsoId("_abdQRdp-Ed-ak6NoX_4Aeg_1725755297")]
    [Description(@"Used when a creditor accepts the debit authorisation.")]
    AcceptedDebitAuthorisation,
    
    /// <summary>
    /// Used when the result of an investigation is, or will be, the initiation of a payment instruction.
    /// Encoded/decoded by serializers as &quot;IPAY&quot;.
    /// </summary>
    [EnumMember(Value = "IPAY")]
    [IsoId("_abdQRtp-Ed-ak6NoX_4Aeg_1725755332")]
    [Description(@"Used when the result of an investigation is, or will be, the initiation of a payment instruction.")]
    PaymentInitiated,
    
    /// <summary>
    /// Used when a transfer of funds has been initiated (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;ICOV&quot;.
    /// </summary>
    [EnumMember(Value = "ICOV")]
    [IsoId("_abdQR9p-Ed-ak6NoX_4Aeg_1733139976")]
    [Description(@"Used when a transfer of funds has been initiated (a cover payment) to resolve a case.")]
    CoverInitiated,
    
    /// <summary>
    /// Used when a transfer of funds has been modified (a cover payment) to resolve a case.
    /// Encoded/decoded by serializers as &quot;MCOV&quot;.
    /// </summary>
    [EnumMember(Value = "MCOV")]
    [IsoId("_abdQSNp-Ed-ak6NoX_4Aeg_1733140011")]
    [Description(@"Used when a transfer of funds has been modified (a cover payment) to resolve a case.")]
    CoverModified,
    
    /// <summary>
    /// Used when a payment instruction (eg. MT103) has been initiated to resolve a case.
    /// Encoded/decoded by serializers as &quot;IPYI&quot;.
    /// </summary>
    [EnumMember(Value = "IPYI")]
    [IsoId("_abdQSdp-Ed-ak6NoX_4Aeg_1733140046")]
    [Description(@"Used when a payment instruction (eg. MT103) has been initiated to resolve a case.")]
    PaymentInstructionInitiated,
    
    /// <summary>
    /// Used when additional information has been sent to the beneficiary of a payment.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_abnBQNp-Ed-ak6NoX_4Aeg_1734065068")]
    [Description(@"Used when additional information has been sent to the beneficiary of a payment.")]
    AdditionalInformationSent,
    
    /// <summary>
    /// Used when a payment has been checked and was correctly executed without any intervention.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_abnBQdp-Ed-ak6NoX_4Aeg_1734065111")]
    [Description(@"Used when a payment has been checked and was correctly executed without any intervention.")]
    ConfirmationOfPayment,
    
    /// <summary>
    /// Used when a payment will be cancelled to solve an investigation case.
    /// Encoded/decoded by serializers as &quot;CWFW&quot;.
    /// </summary>
    [EnumMember(Value = "CWFW")]
    [IsoId("_abnBQtp-Ed-ak6NoX_4Aeg_1734065146")]
    [Description(@"Used when a payment will be cancelled to solve an investigation case.")]
    CancellationWillFollow,
    
    /// <summary>
    /// Used when the payment will be modified to solve an investigation case.
    /// Encoded/decoded by serializers as &quot;MWFW&quot;.
    /// </summary>
    [EnumMember(Value = "MWFW")]
    [IsoId("_abnBQ9p-Ed-ak6NoX_4Aeg_-1371666346")]
    [Description(@"Used when the payment will be modified to solve an investigation case.")]
    ModificationWillFollow,
    
    /// <summary>
    /// Used when sender wants to respond to an assignment with an Unable To Apply workflow.
    /// Encoded/decoded by serializers as &quot;UWFW&quot;.
    /// </summary>
    [EnumMember(Value = "UWFW")]
    [IsoId("_abnBRNp-Ed-ak6NoX_4Aeg_912954614")]
    [Description(@"Used when sender wants to respond to an assignment with an Unable To Apply workflow.")]
    UnableToApplyWillFollow,
    
    /// <summary>
    /// Used when a requested cancellation has been partially executed.
    /// Encoded/decoded by serializers as &quot;PECR&quot;.
    /// </summary>
    [EnumMember(Value = "PECR")]
    [IsoId("_abnBRdp-Ed-ak6NoX_4Aeg_498725332")]
    [Description(@"Used when a requested cancellation has been partially executed.")]
    PartiallyExecutedCancellationRequest,
    
    /// <summary>
    /// Used when a requested cancellation has been rejected.
    /// Encoded/decoded by serializers as &quot;RJCR&quot;.
    /// </summary>
    [EnumMember(Value = "RJCR")]
    [IsoId("_abnBRtp-Ed-ak6NoX_4Aeg_498725363")]
    [Description(@"Used when a requested cancellation has been rejected.")]
    RejectedCancellationRequest,
    
    /// <summary>
    /// Used when a requested cancellation is pending.
    /// Encoded/decoded by serializers as &quot;PDCR&quot;.
    /// </summary>
    [EnumMember(Value = "PDCR")]
    [IsoId("_abnBR9p-Ed-ak6NoX_4Aeg_498725393")]
    [Description(@"Used when a requested cancellation is pending.")]
    PendingCancellationRequest,
    
    /// <summary>
    /// Used when the entry in the statement is correct.
    /// Encoded/decoded by serializers as &quot;SMTC&quot;.
    /// </summary>
    [EnumMember(Value = "SMTC")]
    [IsoId("_abnBSNp-Ed-ak6NoX_4Aeg_498725424")]
    [Description(@"Used when the entry in the statement is correct.")]
    StatementEntryCorrect,
    
    /// <summary>
    /// Used when the entry in the statement is incorrect and further information is provided with the resolution.
    /// Encoded/decoded by serializers as &quot;SMTI&quot;.
    /// </summary>
    [EnumMember(Value = "SMTI")]
    [IsoId("_abnBSdp-Ed-ak6NoX_4Aeg_498725733")]
    [Description(@"Used when the entry in the statement is incorrect and further information is provided with the resolution.")]
    StatementEntryIncorrect,
    
    /// <summary>
    /// Further charges details are provided to resolve the case.
    /// Encoded/decoded by serializers as &quot;CHRG&quot;.
    /// </summary>
    [EnumMember(Value = "CHRG")]
    [IsoId("_abwLMNp-Ed-ak6NoX_4Aeg_498725764")]
    [Description(@"Further charges details are provided to resolve the case.")]
    ChargesDetailsProvided,
    
    /// <summary>
    /// Further purpose details are provided to resolve the case.
    /// Encoded/decoded by serializers as &quot;PURP&quot;.
    /// </summary>
    [EnumMember(Value = "PURP")]
    [IsoId("_abwLMdp-Ed-ak6NoX_4Aeg_972343199")]
    [Description(@"Further purpose details are provided to resolve the case.")]
    PurposeDetailsProvided,
    
    /// <summary>
    /// Used when the requested check for a possible duplicate instruction is confirmed.
    /// Encoded/decoded by serializers as &quot;IDUP&quot;.
    /// </summary>
    [EnumMember(Value = "IDUP")]
    [IsoId("_abwLMtp-Ed-ak6NoX_4Aeg_972343600")]
    [Description(@"Used when the requested check for a possible duplicate instruction is confirmed.")]
    InstructionIsDuplicate,
    
}
