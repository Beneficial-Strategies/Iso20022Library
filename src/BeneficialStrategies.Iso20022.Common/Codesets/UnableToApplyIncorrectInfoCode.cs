// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Used when the unable to apply is due to incorrect information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yz5cktp-Ed-ak6NoX_4Aeg_22044540")]
[Description(@"Used when the unable to apply is due to incorrect information.")]
[Derivations(typeof(UnableToApplyIncorrectInfo1Code),typeof(UnableToApplyIncorrectInfo2Code))]
public enum UnableToApplyIncorrectInfoCode
{
    /// <summary>
    /// RelatedReference is incorrect.
    /// Encoded/decoded by serializers as &quot;IN01&quot;.
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_Yz5ck9p-Ed-ak6NoX_4Aeg_504594197")]
    [Description(@"RelatedReference is incorrect.")]
    IncorrectRelatedReference,
    
    /// <summary>
    /// BankOperationCode is incorrect.
    /// Encoded/decoded by serializers as &quot;IN02&quot;.
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_Yz5clNp-Ed-ak6NoX_4Aeg_504594239")]
    [Description(@"BankOperationCode is incorrect.")]
    IncorrectBankOperationCode,
    
    /// <summary>
    /// InstructionCode is incorrect.
    /// Encoded/decoded by serializers as &quot;IN03&quot;.
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_Yz5cldp-Ed-ak6NoX_4Aeg_504594282")]
    [Description(@"InstructionCode is incorrect.")]
    IncorrectInstructionCode,
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as &quot;IN04&quot;.
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_Yz5cltp-Ed-ak6NoX_4Aeg_504594317")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate,
    
    /// <summary>
    /// ValueDate is incorrect.
    /// Encoded/decoded by serializers as &quot;IN05&quot;.
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_Yz5cl9p-Ed-ak6NoX_4Aeg_504594352")]
    [Description(@"ValueDate is incorrect.")]
    IncorrectValueDate,
    
    /// <summary>
    /// InterbankSettledAmount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN06&quot;.
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_Yz5cmNp-Ed-ak6NoX_4Aeg_504594394")]
    [Description(@"InterbankSettledAmount is incorrect.")]
    IncorrectInterbankSettledAmount,
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN07&quot;.
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_Yz5cmdp-Ed-ak6NoX_4Aeg_504594689")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor,
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN08&quot;.
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_Y0CmgNp-Ed-ak6NoX_4Aeg_504594732")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount,
    
    /// <summary>
    /// ReceiverCorrespondent is incorrect.
    /// Encoded/decoded by serializers as &quot;IN09&quot;.
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_Y0Cmgdp-Ed-ak6NoX_4Aeg_504594785")]
    [Description(@"ReceiverCorrespondent is incorrect.")]
    IncorrectReceiverCorrespondent,
    
    /// <summary>
    /// ThirdReimbursementInstitution is incorrect.
    /// Encoded/decoded by serializers as &quot;IN10&quot;.
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_Y0Cmgtp-Ed-ak6NoX_4Aeg_505514799")]
    [Description(@"ThirdReimbursementInstitution is incorrect.")]
    IncorrectThirdReimbursementInstitution,
    
    /// <summary>
    /// PaymentScheme is incorrect.
    /// Encoded/decoded by serializers as &quot;IN11&quot;.
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_Y0Cmg9p-Ed-ak6NoX_4Aeg_505514834")]
    [Description(@"PaymentScheme is incorrect.")]
    IncorrectPaymentScheme,
    
    /// <summary>
    /// AccountOfBeneficiaryInstitution is incorrect.
    /// Encoded/decoded by serializers as &quot;IN12&quot;.
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_Y0CmhNp-Ed-ak6NoX_4Aeg_505514876")]
    [Description(@"AccountOfBeneficiaryInstitution is incorrect.")]
    IncorrectAccountOfBeneficiaryInstitution,
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN13&quot;.
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_Y0Cmhdp-Ed-ak6NoX_4Aeg_505514919")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor,
    
    /// <summary>
    /// CreditorAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN14&quot;.
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_Y0Cmhtp-Ed-ak6NoX_4Aeg_505514954")]
    [Description(@"CreditorAccount is incorrect.")]
    IncorrectCreditorAccount,
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN15&quot;.
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_Y0Cmh9p-Ed-ak6NoX_4Aeg_505515014")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation,
    
    /// <summary>
    /// PaymentPurpose is incorrect.
    /// Encoded/decoded by serializers as &quot;IN16&quot;.
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_Y0CmiNp-Ed-ak6NoX_4Aeg_505515049")]
    [Description(@"PaymentPurpose is incorrect.")]
    IncorrectPaymentPurpose,
    
    /// <summary>
    /// DetailsOfCharges is incorrect.
    /// Encoded/decoded by serializers as &quot;IN17&quot;.
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_Y0Cmidp-Ed-ak6NoX_4Aeg_505515091")]
    [Description(@"DetailsOfCharges is incorrect.")]
    IncorrectDetailsOfCharges,
    
    /// <summary>
    /// SenderToReceiverInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN18&quot;.
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_Y0MXgNp-Ed-ak6NoX_4Aeg_505515361")]
    [Description(@"SenderToReceiverInformation is incorrect.")]
    IncorrectSenderToReceiverInformation,
    
    /// <summary>
    /// InstructionForFinalAgent is incorrect.
    /// Encoded/decoded by serializers as &quot;IN19&quot;.
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_Y0MXgdp-Ed-ak6NoX_4Aeg_505515403")]
    [Description(@"InstructionForFinalAgent is incorrect.")]
    IncorrectInstructionForFinalAgent,
    
    /// <summary>
    /// Name and Account of Creditor mismatched.
    /// Encoded/decoded by serializers as &quot;MM20&quot;.
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_Y0MXgtp-Ed-ak6NoX_4Aeg_505515446")]
    [Description(@"Name and Account of Creditor mismatched.")]
    MismatchCreditorNameAccount,
    
    /// <summary>
    /// Name and Account of Debtor mismatched.
    /// Encoded/decoded by serializers as &quot;MM21&quot;.
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_Y0MXg9p-Ed-ak6NoX_4Aeg_505515824")]
    [Description(@"Name and Account of Debtor mismatched.")]
    MismatchDebtorNameAccount,
    
    /// <summary>
    /// Name and Account of FinalAgent mismatched.
    /// Encoded/decoded by serializers as &quot;MM22&quot;.
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_Y0MXhNp-Ed-ak6NoX_4Aeg_505515866")]
    [Description(@"Name and Account of FinalAgent mismatched.")]
    MismatchFinalAgentNameAccount,
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM23&quot;.
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_Y0MXhdp-Ed-ak6NoX_4Aeg_112548700")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails,
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM24&quot;.
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_Y0MXhtp-Ed-ak6NoX_4Aeg_121782450")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails,
    
}
