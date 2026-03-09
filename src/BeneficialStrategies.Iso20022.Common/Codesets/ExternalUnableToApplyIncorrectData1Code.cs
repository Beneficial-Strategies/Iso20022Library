// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of an unable to apply due to incorrect data, as published in an external unable to apply incorrect data code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_p-vHiN4jEeqt1ZcLzWyWFw")]
[Description(@"Specifies the reason of an unable to apply due to incorrect data, as published in an external unable to apply incorrect data code set.|External code sets can be downloaded from www.iso20022.org.")]
[DerivedFrom(typeof(ExternalUnableToApplyIncorrectDataCode))]
public enum ExternalUnableToApplyIncorrectData1Code
{
    /// <summary>
    /// Related transaction reference is incorrect.
    /// Encoded/decoded by serializers as &quot;IN01&quot;.
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_uxjbxfRYEeuLhpyIdtJzwg")]
    [Description(@"Related transaction reference is incorrect.")]
    IncorrectRelatedReference = ExternalUnableToApplyIncorrectDataCode.IncorrectRelatedReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type service level is incorrect (former IncorrectBankOperationCode).
    /// Encoded/decoded by serializers as &quot;IN02&quot;.
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_uxjbyPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment type service level is incorrect (former IncorrectBankOperationCode).")]
    IncorrectPaymentServiceLevel = ExternalUnableToApplyIncorrectDataCode.IncorrectPaymentServiceLevel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type category purpose is incorrect (former IncorrectInstructionCode).
    /// Encoded/decoded by serializers as &quot;IN03&quot;.
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_uxjby_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment type category purpose is incorrect (former IncorrectInstructionCode).")]
    IncorrectCategoryPurpose = ExternalUnableToApplyIncorrectDataCode.IncorrectCategoryPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as &quot;IN04&quot;.
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_uxtMwvRYEeuLhpyIdtJzwg")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate = ExternalUnableToApplyIncorrectDataCode.IncorrectRequestedExecutionDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interbank settlement date is incorrect (former IncorrectValueDate).
    /// Encoded/decoded by serializers as &quot;IN05&quot;.
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_uxtMxfRYEeuLhpyIdtJzwg")]
    [Description(@"Interbank settlement date is incorrect (former IncorrectValueDate).")]
    IncorrectInterbankSettlementDate = ExternalUnableToApplyIncorrectDataCode.IncorrectInterbankSettlementDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interbank settlement amount is incorrect (former IncorrectSettledAmount).
    /// Encoded/decoded by serializers as &quot;IN06&quot;.
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_uxtMyPRYEeuLhpyIdtJzwg")]
    [Description(@"Interbank settlement amount is incorrect (former IncorrectSettledAmount).")]
    IncorrectInterbankSettlementAmount = ExternalUnableToApplyIncorrectDataCode.IncorrectInterbankSettlementAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN07&quot;.
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_ux29wvRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor = ExternalUnableToApplyIncorrectDataCode.IncorrectDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN08&quot;.
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_ux29xfRYEeuLhpyIdtJzwg")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount = ExternalUnableToApplyIncorrectDataCode.IncorrectDebtorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).
    /// Encoded/decoded by serializers as &quot;IN09&quot;.
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_ux29yPRYEeuLhpyIdtJzwg")]
    [Description(@"InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).")]
    IncorrectInstructedReimbursementAgent = ExternalUnableToApplyIncorrectDataCode.IncorrectInstructedReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as &quot;IN10&quot;.
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_uyAHsvRYEeuLhpyIdtJzwg")]
    [Description(@"ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).")]
    IncorrectThirdReimbursementAgent = ExternalUnableToApplyIncorrectDataCode.IncorrectThirdReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment type clearing channel is incorrect (former PaymentScheme).
    /// Encoded/decoded by serializers as &quot;IN11&quot;.
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_uyAHtfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment type clearing channel is incorrect (former PaymentScheme).")]
    IncorrectPaymentClearingChannel = ExternalUnableToApplyIncorrectDataCode.IncorrectPaymentClearingChannel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as &quot;IN12&quot;.
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_uyAHuPRYEeuLhpyIdtJzwg")]
    [Description(@"CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).")]
    IncorrectCreditorAgentAccount = ExternalUnableToApplyIncorrectDataCode.IncorrectCreditorAgentAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN13&quot;.
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_uyJ4svRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor = ExternalUnableToApplyIncorrectDataCode.IncorrectCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor account is incorrect.
    /// Encoded/decoded by serializers as &quot;IN14&quot;.
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_uyJ4tfRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor account is incorrect.")]
    IncorrectCreditorAccount = ExternalUnableToApplyIncorrectDataCode.IncorrectCreditorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN15&quot;.
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_uyTpsvRYEeuLhpyIdtJzwg")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation = ExternalUnableToApplyIncorrectDataCode.IncorrectRemittanceInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction payment purpose is incorrect.
    /// Encoded/decoded by serializers as &quot;IN16&quot;.
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_uyTptfRYEeuLhpyIdtJzwg")]
    [Description(@"Transaction payment purpose is incorrect.")]
    IncorrectPaymentPurpose = ExternalUnableToApplyIncorrectDataCode.IncorrectPaymentPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ChargeBearer is incorrect (former IncorrectDetailsOfCharges).
    /// Encoded/decoded by serializers as &quot;IN17&quot;.
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_uyTpuPRYEeuLhpyIdtJzwg")]
    [Description(@"ChargeBearer is incorrect (former IncorrectDetailsOfCharges).")]
    IncorrectChargeBearer = ExternalUnableToApplyIncorrectDataCode.IncorrectChargeBearer, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).
    /// Encoded/decoded by serializers as &quot;IN18&quot;.
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_uyTpu_RYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).")]
    IncorrectInstructionForNextAgent = ExternalUnableToApplyIncorrectDataCode.IncorrectInstructionForNextAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).
    /// Encoded/decoded by serializers as &quot;IN19&quot;.
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_uydasvRYEeuLhpyIdtJzwg")]
    [Description(@"Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).")]
    IncorrectInstructionForCreditorAgent = ExternalUnableToApplyIncorrectDataCode.IncorrectInstructionForCreditorAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount in statement entry is incorrect.
    /// Encoded/decoded by serializers as &quot;IN33&quot;.
    /// </summary>
    [EnumMember(Value = "IN33")]
    [IsoId("_uymkovRYEeuLhpyIdtJzwg")]
    [Description(@"Amount in statement entry is incorrect.")]
    IncorrectReportEntryAmount = ExternalUnableToApplyIncorrectDataCode.IncorrectReportEntryAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SettlementAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN36&quot;.
    /// </summary>
    [EnumMember(Value = "IN36")]
    [IsoId("_uymkpfRYEeuLhpyIdtJzwg")]
    [Description(@"SettlementAccount is incorrect.")]
    IncorrectSettlementAccount = ExternalUnableToApplyIncorrectDataCode.IncorrectSettlementAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instructing reimbursement agent is incorrect.
    /// Encoded/decoded by serializers as &quot;IN37&quot;.
    /// </summary>
    [EnumMember(Value = "IN37")]
    [IsoId("_uywVovRYEeuLhpyIdtJzwg")]
    [Description(@"Instructing reimbursement agent is incorrect.")]
    IncorrectInstructingReimbursementAgent = ExternalUnableToApplyIncorrectDataCode.IncorrectInstructingReimbursementAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor&apos;s address is incorrect.
    /// Encoded/decoded by serializers as &quot;IN38&quot;.
    /// </summary>
    [EnumMember(Value = "IN38")]
    [IsoId("_uywVpfRYEeuLhpyIdtJzwg")]
    [Description(@"Debtor's address is incorrect.")]
    IncorrectDebtorAddress = ExternalUnableToApplyIncorrectDataCode.IncorrectDebtorAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor&apos;s address is incorrect.
    /// Encoded/decoded by serializers as &quot;IN39&quot;.
    /// </summary>
    [EnumMember(Value = "IN39")]
    [IsoId("_uywVqPRYEeuLhpyIdtJzwg")]
    [Description(@"Creditor's address is incorrect.")]
    IncorrectCreditorAddress = ExternalUnableToApplyIncorrectDataCode.IncorrectCreditorAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RelatedRemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN40&quot;.
    /// </summary>
    [EnumMember(Value = "IN40")]
    [IsoId("_uywVq_RYEeuLhpyIdtJzwg")]
    [Description(@"RelatedRemittanceInformation is incorrect.")]
    IncorrectRelatedRemittanceInformation = ExternalUnableToApplyIncorrectDataCode.IncorrectRelatedRemittanceInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and account of creditor are not matching.
    /// Encoded/decoded by serializers as &quot;MM20&quot;.
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_uy5fkvRYEeuLhpyIdtJzwg")]
    [Description(@"Name and account of creditor are not matching.")]
    MismatchCreditorNameAccount = ExternalUnableToApplyIncorrectDataCode.MismatchCreditorNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and account of debtor are not matching.
    /// Encoded/decoded by serializers as &quot;MM21&quot;.
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_uy5flfRYEeuLhpyIdtJzwg")]
    [Description(@"Name and account of debtor are not matching.")]
    MismatchDebtorNameAccount = ExternalUnableToApplyIncorrectDataCode.MismatchDebtorNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and account of creditor agent (former FinalAgent) are not matching.
    /// Encoded/decoded by serializers as &quot;MM22&quot;.
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_uy5fmPRYEeuLhpyIdtJzwg")]
    [Description(@"Name and account of creditor agent (former FinalAgent) are not matching.")]
    MismatchCreditorAgentNameAccount = ExternalUnableToApplyIncorrectDataCode.MismatchCreditorAgentNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM23&quot;.
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_uy5fm_RYEeuLhpyIdtJzwg")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails = ExternalUnableToApplyIncorrectDataCode.InsufficientDebtorDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM24&quot;.
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_uzDQkvRYEeuLhpyIdtJzwg")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails = ExternalUnableToApplyIncorrectDataCode.InsufficientCreditorDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as &quot;MM25&quot;.
    /// </summary>
    [EnumMember(Value = "MM25")]
    [IsoId("_uzDQlfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PendingExecutionDebtorAccountOrIdentification = ExternalUnableToApplyIncorrectDataCode.PendingExecutionDebtorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as &quot;MM26&quot;.
    /// </summary>
    [EnumMember(Value = "MM26")]
    [IsoId("_uzDQmPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PendingExecutionDebtorNameOrAddress = ExternalUnableToApplyIncorrectDataCode.PendingExecutionDebtorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as &quot;MM27&quot;.
    /// </summary>
    [EnumMember(Value = "MM27")]
    [IsoId("_uzDQm_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PaymentExecutedDebtorAccountOrIdentification = ExternalUnableToApplyIncorrectDataCode.PaymentExecutedDebtorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as &quot;MM28&quot;.
    /// </summary>
    [EnumMember(Value = "MM28")]
    [IsoId("_uzNBkvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PaymentExecutedDebtorNameOrAddress = ExternalUnableToApplyIncorrectDataCode.PaymentExecutedDebtorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as &quot;MM29&quot;.
    /// </summary>
    [EnumMember(Value = "MM29")]
    [IsoId("_uzNBlfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PendingExecutionCreditorAccountOrIdentification = ExternalUnableToApplyIncorrectDataCode.PendingExecutionCreditorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as &quot;MM30&quot;.
    /// </summary>
    [EnumMember(Value = "MM30")]
    [IsoId("_uzNBmPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PendingExecutionCreditorNameOrAddress = ExternalUnableToApplyIncorrectDataCode.PendingExecutionCreditorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as &quot;MM31&quot;.
    /// </summary>
    [EnumMember(Value = "MM31")]
    [IsoId("_uzNBm_RYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PaymentExecutedCreditorAccountOrIdentification = ExternalUnableToApplyIncorrectDataCode.PaymentExecutedCreditorAccountOrIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as &quot;MM32&quot;.
    /// </summary>
    [EnumMember(Value = "MM32")]
    [IsoId("_uzNBnvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PaymentExecutedCreditorNameOrAddress = ExternalUnableToApplyIncorrectDataCode.PaymentExecutedCreditorNameOrAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient charges details provided.
    /// Encoded/decoded by serializers as &quot;MM34&quot;.
    /// </summary>
    [EnumMember(Value = "MM34")]
    [IsoId("_uzWLgvRYEeuLhpyIdtJzwg")]
    [Description(@"Insufficient charges details provided.")]
    InsufficientChargesDetails = ExternalUnableToApplyIncorrectDataCode.InsufficientChargesDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment purpose needs to be further specified.
    /// Encoded/decoded by serializers as &quot;MM35&quot;.
    /// </summary>
    [EnumMember(Value = "MM35")]
    [IsoId("_uzWLhfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment purpose needs to be further specified.")]
    InsufficientPaymentPurpose = ExternalUnableToApplyIncorrectDataCode.InsufficientPaymentPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_uzf8gvRYEeuLhpyIdtJzwg")]
    [Description(@"See narrative field for additional information.")]
    Narrative = ExternalUnableToApplyIncorrectDataCode.Narrative, // same ordinal as derivation source for type conversions
    
}
