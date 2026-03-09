// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of an unable to apply due to incorrect information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y0yNY9p-Ed-ak6NoX_4Aeg_-1880255090")]
[Description(@"Specifies the reason of an unable to apply due to incorrect information.")]
[Derivations(typeof(UnableToApplyIncorrectInformation3Code),typeof(UnableToApplyIncorrectInformation4Code))]
public enum UnableToApplyIncorrectInformationV2Code
{
    /// <summary>
    /// Related transaction reference is incorrect.
    /// Encoded/decoded by serializers as &quot;IN01&quot;.
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_Y0yNZNp-Ed-ak6NoX_4Aeg_-1491451794")]
    [Description(@"Related transaction reference is incorrect.")]
    IncorrectRelatedReference,
    
    /// <summary>
    /// Payment type service level is incorrect (former IncorrectBankOperationCode).
    /// Encoded/decoded by serializers as &quot;IN02&quot;.
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_Y0yNZdp-Ed-ak6NoX_4Aeg_-1491451764")]
    [Description(@"Payment type service level is incorrect (former IncorrectBankOperationCode).")]
    IncorrectPaymentServiceLevel,
    
    /// <summary>
    /// Payment type category purpose is incorrect (former IncorrectInstructionCode).
    /// Encoded/decoded by serializers as &quot;IN03&quot;.
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_Y0yNZtp-Ed-ak6NoX_4Aeg_-1491451763")]
    [Description(@"Payment type category purpose is incorrect (former IncorrectInstructionCode).")]
    IncorrectCategoryPurpose,
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as &quot;IN04&quot;.
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_Y0yNZ9p-Ed-ak6NoX_4Aeg_-1491451733")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate,
    
    /// <summary>
    /// Interbank settlement date is incorrect (former IncorrectValueDate).
    /// Encoded/decoded by serializers as &quot;IN05&quot;.
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_Y0yNaNp-Ed-ak6NoX_4Aeg_-1491451711")]
    [Description(@"Interbank settlement date is incorrect (former IncorrectValueDate).")]
    IncorrectInterbankSettlementDate,
    
    /// <summary>
    /// Interbank settlement amount is incorrect (former IncorrectSettledAmount).
    /// Encoded/decoded by serializers as &quot;IN06&quot;.
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_Y0yNadp-Ed-ak6NoX_4Aeg_-1491451485")]
    [Description(@"Interbank settlement amount is incorrect (former IncorrectSettledAmount).")]
    IncorrectInterbankSettlementAmount,
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN07&quot;.
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_Y07-YNp-Ed-ak6NoX_4Aeg_-1491451463")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor,
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN08&quot;.
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_Y07-Ydp-Ed-ak6NoX_4Aeg_-1491451432")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount,
    
    /// <summary>
    /// InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).
    /// Encoded/decoded by serializers as &quot;IN09&quot;.
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_Y07-Ytp-Ed-ak6NoX_4Aeg_-1491451423")]
    [Description(@"InstructedReimbursementAgent is incorrect (former IncorrectReceiverCorrespondent).")]
    IncorrectInstructedReimbursementAgent,
    
    /// <summary>
    /// ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).
    /// Encoded/decoded by serializers as &quot;IN10&quot;.
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_Y07-Y9p-Ed-ak6NoX_4Aeg_-1491451402")]
    [Description(@"ThirdReimbursementAgent is incorrect (former IncorrectThirdReimbursementInstitution).")]
    IncorrectThirdReimbursementAgent,
    
    /// <summary>
    /// Payment type clearing channel is incorrect (former PaymentScheme).
    /// Encoded/decoded by serializers as &quot;IN11&quot;.
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_Y07-ZNp-Ed-ak6NoX_4Aeg_-1491451371")]
    [Description(@"Payment type clearing channel is incorrect (former PaymentScheme).")]
    IncorrectPaymentClearingChannel,
    
    /// <summary>
    /// CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).
    /// Encoded/decoded by serializers as &quot;IN12&quot;.
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_Y07-Zdp-Ed-ak6NoX_4Aeg_-1491451370")]
    [Description(@"CreditorAgentAccount is incorrect (former IncorrectAccountOfBeneficiaryInstitution).")]
    IncorrectCreditorAgentAccount,
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN13&quot;.
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_Y07-Ztp-Ed-ak6NoX_4Aeg_-1491451340")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor,
    
    /// <summary>
    /// Creditor account is incorrect.
    /// Encoded/decoded by serializers as &quot;IN14&quot;.
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_Y07-Z9p-Ed-ak6NoX_4Aeg_-1491451310")]
    [Description(@"Creditor account is incorrect.")]
    IncorrectCreditorAccount,
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN15&quot;.
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_Y07-aNp-Ed-ak6NoX_4Aeg_-1491451031")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation,
    
    /// <summary>
    /// Transaction payment purpose is incorrect.
    /// Encoded/decoded by serializers as &quot;IN16&quot;.
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_Y07-adp-Ed-ak6NoX_4Aeg_-1491451001")]
    [Description(@"Transaction payment purpose is incorrect.")]
    IncorrectPaymentPurpose,
    
    /// <summary>
    /// ChargeBearer is incorrect (former IncorrectDetailsOfCharges).
    /// Encoded/decoded by serializers as &quot;IN17&quot;.
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_Y1FvYNp-Ed-ak6NoX_4Aeg_-1491450970")]
    [Description(@"ChargeBearer is incorrect (former IncorrectDetailsOfCharges).")]
    IncorrectChargeBearer,
    
    /// <summary>
    /// Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).
    /// Encoded/decoded by serializers as &quot;IN18&quot;.
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_Y1FvYdp-Ed-ak6NoX_4Aeg_-1491450969")]
    [Description(@"Instruction for next agent is incorrect (former IncorrectSenderToReceiverInformation).")]
    IncorrectInstructionForNextAgent,
    
    /// <summary>
    /// Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).
    /// Encoded/decoded by serializers as &quot;IN19&quot;.
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_Y1FvYtp-Ed-ak6NoX_4Aeg_-1491450939")]
    [Description(@"Instruction for creditor agent is incorrect (former IncorrectInstructionForFinalAgent).")]
    IncorrectInstructionForCreditorAgent,
    
    /// <summary>
    /// Name and account of creditor are not matching.
    /// Encoded/decoded by serializers as &quot;MM20&quot;.
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_Y1FvY9p-Ed-ak6NoX_4Aeg_-1491450817")]
    [Description(@"Name and account of creditor are not matching.")]
    MismatchCreditorNameAccount,
    
    /// <summary>
    /// Name and account of debtor are not matching.
    /// Encoded/decoded by serializers as &quot;MM21&quot;.
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_Y1FvZNp-Ed-ak6NoX_4Aeg_-1491450515")]
    [Description(@"Name and account of debtor are not matching.")]
    MismatchDebtorNameAccount,
    
    /// <summary>
    /// Name and account of creditor agent (former FinalAgent) are not matching.
    /// Encoded/decoded by serializers as &quot;MM22&quot;.
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_Y1FvZdp-Ed-ak6NoX_4Aeg_-1491450484")]
    [Description(@"Name and account of creditor agent (former FinalAgent) are not matching.")]
    MismatchCreditorAgentNameAccount,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM23&quot;.
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_Y1FvZtp-Ed-ak6NoX_4Aeg_-1476677331")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM24&quot;.
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_Y1FvZ9p-Ed-ak6NoX_4Aeg_-1476677300")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as &quot;MM25&quot;.
    /// </summary>
    [EnumMember(Value = "MM25")]
    [IsoId("_Y1FvaNp-Ed-ak6NoX_4Aeg_-1459129606")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PendingExecutionDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as &quot;MM26&quot;.
    /// </summary>
    [EnumMember(Value = "MM26")]
    [IsoId("_Y1Fvadp-Ed-ak6NoX_4Aeg_-1065707728")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PendingExecutionDebtorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.
    /// Encoded/decoded by serializers as &quot;MM27&quot;.
    /// </summary>
    [EnumMember(Value = "MM27")]
    [IsoId("_Y1Fvatp-Ed-ak6NoX_4Aeg_-1007525450")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the debtor.")]
    PaymentExecutedDebtorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.
    /// Encoded/decoded by serializers as &quot;MM28&quot;.
    /// </summary>
    [EnumMember(Value = "MM28")]
    [IsoId("_Y1O5UNp-Ed-ak6NoX_4Aeg_-964122806")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the debtor.")]
    PaymentExecutedDebtorNameOrAddress,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as &quot;MM29&quot;.
    /// </summary>
    [EnumMember(Value = "MM29")]
    [IsoId("_Y1O5Udp-Ed-ak6NoX_4Aeg_-485736601")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PendingExecutionCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as &quot;MM30&quot;.
    /// </summary>
    [EnumMember(Value = "MM30")]
    [IsoId("_Y1O5Utp-Ed-ak6NoX_4Aeg_-485736478")]
    [Description(@"Payment is pending execution. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PendingExecutionCreditorNameOrAddress,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.
    /// Encoded/decoded by serializers as &quot;MM31&quot;.
    /// </summary>
    [EnumMember(Value = "MM31")]
    [IsoId("_Y1O5U9p-Ed-ak6NoX_4Aeg_-485736394")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the account number or unique identification of the creditor.")]
    PaymentExecutedCreditorAccountOrIdentification,
    
    /// <summary>
    /// Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.
    /// Encoded/decoded by serializers as &quot;MM32&quot;.
    /// </summary>
    [EnumMember(Value = "MM32")]
    [IsoId("_Y1O5VNp-Ed-ak6NoX_4Aeg_-478351375")]
    [Description(@"Payment has been executed. For reasons of regulatory requirements we request further information on the name and/or address of the creditor.")]
    PaymentExecutedCreditorNameOrAddress,
    
    /// <summary>
    /// Amount in statement entry is incorrect.
    /// Encoded/decoded by serializers as &quot;IN33&quot;.
    /// </summary>
    [EnumMember(Value = "IN33")]
    [IsoId("_Y1O5Vdp-Ed-ak6NoX_4Aeg_783181284")]
    [Description(@"Amount in statement entry is incorrect.")]
    IncorrectReportEntryAmount,
    
    /// <summary>
    /// Insufficient charges details provided.
    /// Encoded/decoded by serializers as &quot;MM34&quot;.
    /// </summary>
    [EnumMember(Value = "MM34")]
    [IsoId("_Y1O5Vtp-Ed-ak6NoX_4Aeg_1254176047")]
    [Description(@"Insufficient charges details provided.")]
    InsufficientChargesDetails,
    
    /// <summary>
    /// Payment purpose needs to be further specified.
    /// Encoded/decoded by serializers as &quot;MM35&quot;.
    /// </summary>
    [EnumMember(Value = "MM35")]
    [IsoId("_Y1O5V9p-Ed-ak6NoX_4Aeg_1567247885")]
    [Description(@"Payment purpose needs to be further specified.")]
    InsufficientPaymentPurpose,
    
    /// <summary>
    /// SettlementAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN36&quot;.
    /// </summary>
    [EnumMember(Value = "IN36")]
    [IsoId("_Y1YqUNp-Ed-ak6NoX_4Aeg_-1693093653")]
    [Description(@"SettlementAccount is incorrect.")]
    IncorrectSettlementAccount,
    
    /// <summary>
    /// Instructing reimbursement agent is incorrect.
    /// Encoded/decoded by serializers as &quot;IN37&quot;.
    /// </summary>
    [EnumMember(Value = "IN37")]
    [IsoId("_Y1YqUdp-Ed-ak6NoX_4Aeg_838074029")]
    [Description(@"Instructing reimbursement agent is incorrect.")]
    IncorrectInstructingReimbursementAgent,
    
    /// <summary>
    /// Debtor&apos;s address is incorrect.
    /// Encoded/decoded by serializers as &quot;IN38&quot;.
    /// </summary>
    [EnumMember(Value = "IN38")]
    [IsoId("_Y1YqUtp-Ed-ak6NoX_4Aeg_-1463463483")]
    [Description(@"Debtor's address is incorrect.")]
    IncorrectDebtorAddress,
    
    /// <summary>
    /// Creditor&apos;s address is incorrect.
    /// Encoded/decoded by serializers as &quot;IN39&quot;.
    /// </summary>
    [EnumMember(Value = "IN39")]
    [IsoId("_Y1YqU9p-Ed-ak6NoX_4Aeg_-1461615238")]
    [Description(@"Creditor's address is incorrect.")]
    IncorrectCreditorAddress,
    
    /// <summary>
    /// See narrative field for additional information.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_0SCIsUgsEeaGKYpLDboHPQ")]
    [Description(@"See narrative field for additional information.")]
    Narrative,
    
}
