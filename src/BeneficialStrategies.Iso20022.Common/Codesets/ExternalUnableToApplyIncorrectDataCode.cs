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
[IsoId("_p-vHSt4jEeqt1ZcLzWyWFw")]
[Description(@"Specifies the reason of an unable to apply due to incorrect data, as published in an external unable to apply incorrect data code set.|External code sets can be downloaded from www.iso20022.org.|")]
[Derivations(typeof(ExternalUnableToApplyIncorrectData1Code))]
public enum ExternalUnableToApplyIncorrectDataCode
{
    /// <summary>
    /// Related transaction reference is incorrect.
    /// Encoded/decoded by serializers as &quot;IN01&quot;.
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_p-vHYN4jEeqt1ZcLzWyWFw")]
    [Description(@"Related transaction reference is incorrect.")]
    IncorrectRelatedReference,
    
    /// <summary>
    /// Payment type service level is incorrect (former IncorrectBankOperationCode).
    /// Encoded/decoded by serializers as &quot;IN02&quot;.
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_p-vHad4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment type service level is incorrect (former IncorrectBankOperationCode).")]
    IncorrectPaymentServiceLevel,
    
    /// <summary>
    /// Payment type category purpose is incorrect (former IncorrectInstructionCode).
    /// Encoded/decoded by serializers as &quot;IN03&quot;.
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_p-vHcd4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment type category purpose is incorrect (former IncorrectInstructionCode).")]
    IncorrectCategoryPurpose,
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as &quot;IN04&quot;.
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_p-vHXd4jEeqt1ZcLzWyWFw")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate,
    
    /// <summary>
    /// Interbank settlement date is incorrect (former IncorrectValueDate).
    /// Encoded/decoded by serializers as &quot;IN05&quot;.
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_p-vHbN4jEeqt1ZcLzWyWFw")]
    [Description(@"Interbank settlement date is incorrect (former IncorrectValueDate).")]
    IncorrectInterbankSettlementDate,
    
    /// <summary>
    /// Interbank settlement amount is incorrect (former IncorrectSettledAmount).
    /// Encoded/decoded by serializers as &quot;IN06&quot;.
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_p-vHU94jEeqt1ZcLzWyWFw")]
    [Description(@"Interbank settlement amount is incorrect (former IncorrectSettledAmount).")]
    IncorrectInterbankSettlementAmount,
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN07&quot;.
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_p-vHZt4jEeqt1ZcLzWyWFw")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor,
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN08&quot;.
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_p-vHXN4jEeqt1ZcLzWyWFw")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount,
    
    /// <summary>
    /// InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).
    /// Encoded/decoded by serializers as &quot;IN09&quot;.
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_p-vHct4jEeqt1ZcLzWyWFw")]
    [Description(@"InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).")]
    IncorrectInstructedReimbursementAgent,
    
    /// <summary>
    /// ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as &quot;IN10&quot;.
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_p-vHcN4jEeqt1ZcLzWyWFw")]
    [Description(@"ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).")]
    IncorrectThirdReimbursementAgent,
    
    /// <summary>
    /// Payment type clearing channel is incorrect (former PaymentScheme).
    /// Encoded/decoded by serializers as &quot;IN11&quot;.
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_p-vHUN4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment type clearing channel is incorrect (former PaymentScheme).")]
    IncorrectPaymentClearingChannel,
    
    /// <summary>
    /// CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as &quot;IN12&quot;.
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_p-vHXt4jEeqt1ZcLzWyWFw")]
    [Description(@"CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).")]
    IncorrectCreditorAgentAccount,
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN13&quot;.
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_p-vHWd4jEeqt1ZcLzWyWFw")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor,
    
    /// <summary>
    /// Creditor account is incorrect.
    /// Encoded/decoded by serializers as &quot;IN14&quot;.
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_p-vHTd4jEeqt1ZcLzWyWFw")]
    [Description(@"Creditor account is incorrect.")]
    IncorrectCreditorAccount,
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN15&quot;.
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_p-vHV94jEeqt1ZcLzWyWFw")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation,
    
    /// <summary>
    /// Transaction payment purpose is incorrect.
    /// Encoded/decoded by serializers as &quot;IN16&quot;.
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_p-vHWt4jEeqt1ZcLzWyWFw")]
    [Description(@"Transaction payment purpose is incorrect.")]
    IncorrectPaymentPurpose,
    
    /// <summary>
    /// ChargeBearer is incorrect (former IncorrectDetailsOfCharges).
    /// Encoded/decoded by serializers as &quot;IN17&quot;.
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_p-vHWN4jEeqt1ZcLzWyWFw")]
    [Description(@"ChargeBearer is incorrect (former IncorrectDetailsOfCharges).")]
    IncorrectChargeBearer,
    
    /// <summary>
    /// Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).
    /// Encoded/decoded by serializers as &quot;IN18&quot;.
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_p-vHZd4jEeqt1ZcLzWyWFw")]
    [Description(@"Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).")]
    IncorrectInstructionForNextAgent,
    
    /// <summary>
    /// Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).
    /// Encoded/decoded by serializers as &quot;IN19&quot;.
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_p-vHX94jEeqt1ZcLzWyWFw")]
    [Description(@"Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).")]
    IncorrectInstructionForCreditorAgent,
    
    /// <summary>
    /// Name and account of creditor are not matching.
    /// Encoded/decoded by serializers as &quot;MM20&quot;.
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_p-vHTt4jEeqt1ZcLzWyWFw")]
    [Description(@"Name and account of creditor are not matching.")]
    MismatchCreditorNameAccount,
    
    /// <summary>
    /// Name and account of debtor are not matching.
    /// Encoded/decoded by serializers as &quot;MM21&quot;.
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_p-vHT94jEeqt1ZcLzWyWFw")]
    [Description(@"Name and account of debtor are not matching.")]
    MismatchDebtorNameAccount,
    
    /// <summary>
    /// Name and account of creditor agent (former FinalAgent) are not matching.
    /// Encoded/decoded by serializers as &quot;MM22&quot;.
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_p-vHa94jEeqt1ZcLzWyWFw")]
    [Description(@"Name and account of creditor agent (former FinalAgent) are not matching.")]
    MismatchCreditorAgentNameAccount,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM23&quot;.
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_p-vHat4jEeqt1ZcLzWyWFw")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM24&quot;.
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_p-vHVN4jEeqt1ZcLzWyWFw")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as &quot;MM25&quot;.
    /// </summary>
    [EnumMember(Value = "MM25")]
    [IsoId("_p-vHY94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PendingExecutionDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as &quot;MM26&quot;.
    /// </summary>
    [EnumMember(Value = "MM26")]
    [IsoId("_p-vHYd4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PendingExecutionDebtorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as &quot;MM27&quot;.
    /// </summary>
    [EnumMember(Value = "MM27")]
    [IsoId("_p-vHW94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PaymentExecutedDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as &quot;MM28&quot;.
    /// </summary>
    [EnumMember(Value = "MM28")]
    [IsoId("_p-vHc94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PaymentExecutedDebtorNameOrAddress,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as &quot;MM29&quot;.
    /// </summary>
    [EnumMember(Value = "MM29")]
    [IsoId("_p-vHbt4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PendingExecutionCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as &quot;MM30&quot;.
    /// </summary>
    [EnumMember(Value = "MM30")]
    [IsoId("_p-vHUt4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PendingExecutionCreditorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as &quot;MM31&quot;.
    /// </summary>
    [EnumMember(Value = "MM31")]
    [IsoId("_p-vHS94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PaymentExecutedCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as &quot;MM32&quot;.
    /// </summary>
    [EnumMember(Value = "MM32")]
    [IsoId("_p-vHYt4jEeqt1ZcLzWyWFw")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PaymentExecutedCreditorNameOrAddress,
    
    /// <summary>
    /// Amount in statement entry is incorrect.
    /// Encoded/decoded by serializers as &quot;IN33&quot;.
    /// </summary>
    [EnumMember(Value = "IN33")]
    [IsoId("_p-vHZN4jEeqt1ZcLzWyWFw")]
    [Description(@"Amount in statement entry is incorrect.")]
    IncorrectReportEntryAmount,
    
    /// <summary>
    /// Insufficient charges details provided.
    /// Encoded/decoded by serializers as &quot;MM34&quot;.
    /// </summary>
    [EnumMember(Value = "MM34")]
    [IsoId("_p-vHbd4jEeqt1ZcLzWyWFw")]
    [Description(@"Insufficient charges details provided.")]
    InsufficientChargesDetails,
    
    /// <summary>
    /// Payment purpose needs to be further specified.
    /// Encoded/decoded by serializers as &quot;MM35&quot;.
    /// </summary>
    [EnumMember(Value = "MM35")]
    [IsoId("_p-vHZ94jEeqt1ZcLzWyWFw")]
    [Description(@"Payment purpose needs to be further specified.")]
    InsufficientPaymentPurpose,
    
    /// <summary>
    /// SettlementAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN36&quot;.
    /// </summary>
    [EnumMember(Value = "IN36")]
    [IsoId("_p-vHUd4jEeqt1ZcLzWyWFw")]
    [Description(@"SettlementAccount is incorrect.")]
    IncorrectSettlementAccount,
    
    /// <summary>
    /// Instructing reimbursement agent is incorrect.
    /// Encoded/decoded by serializers as &quot;IN37&quot;.
    /// </summary>
    [EnumMember(Value = "IN37")]
    [IsoId("_p-vHVt4jEeqt1ZcLzWyWFw")]
    [Description(@"Instructing reimbursement agent is incorrect.")]
    IncorrectInstructingReimbursementAgent,
    
    /// <summary>
    /// Debtor&apos;s address is incorrect.
    /// Encoded/decoded by serializers as &quot;IN38&quot;.
    /// </summary>
    [EnumMember(Value = "IN38")]
    [IsoId("_p-vHTN4jEeqt1ZcLzWyWFw")]
    [Description(@"Debtor's address is incorrect.")]
    IncorrectDebtorAddress,
    
    /// <summary>
    /// Creditor&apos;s address is incorrect.
    /// Encoded/decoded by serializers as &quot;IN39&quot;.
    /// </summary>
    [EnumMember(Value = "IN39")]
    [IsoId("_p-vHVd4jEeqt1ZcLzWyWFw")]
    [Description(@"Creditor's address is incorrect.")]
    IncorrectCreditorAddress,
    
    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_p-vHb94jEeqt1ZcLzWyWFw")]
    [Description(@"See narrative field for additional information.")]
    Narrative,
    
    /// <summary>
    /// RelatedRemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN40&quot;.
    /// </summary>
    [EnumMember(Value = "IN40")]
    [IsoId("_p-vHaN4jEeqt1ZcLzWyWFw")]
    [Description(@"RelatedRemittanceInformation is incorrect.")]
    IncorrectRelatedRemittanceInformation,
    
}
