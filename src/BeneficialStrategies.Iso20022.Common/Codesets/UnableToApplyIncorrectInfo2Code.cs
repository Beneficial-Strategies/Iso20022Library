// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Used when the unable to apply is due to incorrect information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Yzcwp9p-Ed-ak6NoX_4Aeg_-718887737")]
[Description(@"Used when the unable to apply is due to incorrect information.")]
[DerivedFrom(typeof(UnableToApplyIncorrectInfoCode))]
[Obsolete("Formally obsoleted in the ISO 20022 specification. No removal date recorded.")]
public enum UnableToApplyIncorrectInfo2Code
{
    /// <summary>
    /// RelatedReference is incorrect.
    /// Encoded/decoded by serializers as &quot;IN01&quot;.
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_YzcwqNp-Ed-ak6NoX_4Aeg_-718887494")]
    [Description(@"RelatedReference is incorrect.")]
    IncorrectRelatedReference = UnableToApplyIncorrectInfoCode.IncorrectRelatedReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// BankOperationCode is incorrect.
    /// Encoded/decoded by serializers as &quot;IN02&quot;.
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_Yzl6kNp-Ed-ak6NoX_4Aeg_-718887477")]
    [Description(@"BankOperationCode is incorrect.")]
    IncorrectBankOperationCode = UnableToApplyIncorrectInfoCode.IncorrectBankOperationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructionCode is incorrect.
    /// Encoded/decoded by serializers as &quot;IN03&quot;.
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_Yzl6kdp-Ed-ak6NoX_4Aeg_-718887417")]
    [Description(@"InstructionCode is incorrect.")]
    IncorrectInstructionCode = UnableToApplyIncorrectInfoCode.IncorrectInstructionCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as &quot;IN04&quot;.
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_Yzl6ktp-Ed-ak6NoX_4Aeg_-718887400")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate = UnableToApplyIncorrectInfoCode.IncorrectRequestedExecutionDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ValueDate is incorrect.
    /// Encoded/decoded by serializers as &quot;IN05&quot;.
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_Yzl6k9p-Ed-ak6NoX_4Aeg_-718887347")]
    [Description(@"ValueDate is incorrect.")]
    IncorrectValueDate = UnableToApplyIncorrectInfoCode.IncorrectValueDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InterbankSettledAmount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN06&quot;.
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_Yzl6lNp-Ed-ak6NoX_4Aeg_-718887057")]
    [Description(@"InterbankSettledAmount is incorrect.")]
    IncorrectInterbankSettledAmount = UnableToApplyIncorrectInfoCode.IncorrectInterbankSettledAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN07&quot;.
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_Yzl6ldp-Ed-ak6NoX_4Aeg_-718887056")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor = UnableToApplyIncorrectInfoCode.IncorrectDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN08&quot;.
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_Yzl6ltp-Ed-ak6NoX_4Aeg_-718887039")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount = UnableToApplyIncorrectInfoCode.IncorrectDebtorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ReceiverCorrespondent is incorrect.
    /// Encoded/decoded by serializers as &quot;IN09&quot;.
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_Yzl6l9p-Ed-ak6NoX_4Aeg_-718886979")]
    [Description(@"ReceiverCorrespondent is incorrect.")]
    IncorrectReceiverCorrespondent = UnableToApplyIncorrectInfoCode.IncorrectReceiverCorrespondent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ThirdReimbursementInstitution is incorrect.
    /// Encoded/decoded by serializers as &quot;IN10&quot;.
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_Yzl6mNp-Ed-ak6NoX_4Aeg_-718886962")]
    [Description(@"ThirdReimbursementInstitution is incorrect.")]
    IncorrectThirdReimbursementInstitution = UnableToApplyIncorrectInfoCode.IncorrectThirdReimbursementInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PaymentScheme is incorrect.
    /// Encoded/decoded by serializers as &quot;IN11&quot;.
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_Yzl6mdp-Ed-ak6NoX_4Aeg_-718886919")]
    [Description(@"PaymentScheme is incorrect.")]
    IncorrectPaymentScheme = UnableToApplyIncorrectInfoCode.IncorrectPaymentScheme, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// AccountOfBeneficiaryInstitution is incorrect.
    /// Encoded/decoded by serializers as &quot;IN12&quot;.
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_Yzl6mtp-Ed-ak6NoX_4Aeg_-718886884")]
    [Description(@"AccountOfBeneficiaryInstitution is incorrect.")]
    IncorrectAccountOfBeneficiaryInstitution = UnableToApplyIncorrectInfoCode.IncorrectAccountOfBeneficiaryInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN13&quot;.
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_YzvrkNp-Ed-ak6NoX_4Aeg_-718886859")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor = UnableToApplyIncorrectInfoCode.IncorrectCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CreditorAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN14&quot;.
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_Yzvrkdp-Ed-ak6NoX_4Aeg_-718886842")]
    [Description(@"CreditorAccount is incorrect.")]
    IncorrectCreditorAccount = UnableToApplyIncorrectInfoCode.IncorrectCreditorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN15&quot;.
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_Yzvrktp-Ed-ak6NoX_4Aeg_-718886789")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation = UnableToApplyIncorrectInfoCode.IncorrectRemittanceInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PaymentPurpose is incorrect.
    /// Encoded/decoded by serializers as &quot;IN16&quot;.
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_Yzvrk9p-Ed-ak6NoX_4Aeg_-718886512")]
    [Description(@"PaymentPurpose is incorrect.")]
    IncorrectPaymentPurpose = UnableToApplyIncorrectInfoCode.IncorrectPaymentPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DetailsOfCharges is incorrect.
    /// Encoded/decoded by serializers as &quot;IN17&quot;.
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_YzvrlNp-Ed-ak6NoX_4Aeg_-718886470")]
    [Description(@"DetailsOfCharges is incorrect.")]
    IncorrectDetailsOfCharges = UnableToApplyIncorrectInfoCode.IncorrectDetailsOfCharges, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SenderToReceiverInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN18&quot;.
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_Yzvrldp-Ed-ak6NoX_4Aeg_-718886435")]
    [Description(@"SenderToReceiverInformation is incorrect.")]
    IncorrectSenderToReceiverInformation = UnableToApplyIncorrectInfoCode.IncorrectSenderToReceiverInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructionForFinalAgent is incorrect.
    /// Encoded/decoded by serializers as &quot;IN19&quot;.
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_Yzvrltp-Ed-ak6NoX_4Aeg_-718886392")]
    [Description(@"InstructionForFinalAgent is incorrect.")]
    IncorrectInstructionForFinalAgent = UnableToApplyIncorrectInfoCode.IncorrectInstructionForFinalAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and Account of Creditor mismatched.
    /// Encoded/decoded by serializers as &quot;MM20&quot;.
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_Yzvrl9p-Ed-ak6NoX_4Aeg_-718886109")]
    [Description(@"Name and Account of Creditor mismatched.")]
    MismatchCreditorNameAccount = UnableToApplyIncorrectInfoCode.MismatchCreditorNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and Account of Debtor mismatched.
    /// Encoded/decoded by serializers as &quot;MM21&quot;.
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_YzvrmNp-Ed-ak6NoX_4Aeg_-718886084")]
    [Description(@"Name and Account of Debtor mismatched.")]
    MismatchDebtorNameAccount = UnableToApplyIncorrectInfoCode.MismatchDebtorNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and Account of FinalAgent mismatched.
    /// Encoded/decoded by serializers as &quot;MM22&quot;.
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_Yzvrmdp-Ed-ak6NoX_4Aeg_-718886067")]
    [Description(@"Name and Account of FinalAgent mismatched.")]
    MismatchFinalAgentNameAccount = UnableToApplyIncorrectInfoCode.MismatchFinalAgentNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient or incoherent details about the debtor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM23&quot;.
    /// </summary>
    [EnumMember(Value = "MM23")]
    [IsoId("_Yz5ckNp-Ed-ak6NoX_4Aeg_-718886014")]
    [Description(@"Insufficient or incoherent details about the debtor with respect to regulatory requirements.")]
    InsufficientDebtorDetails = UnableToApplyIncorrectInfoCode.InsufficientDebtorDetails, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Insufficient or incoherent details about the creditor with respect to regulatory requirements.
    /// Encoded/decoded by serializers as &quot;MM24&quot;.
    /// </summary>
    [EnumMember(Value = "MM24")]
    [IsoId("_Yz5ckdp-Ed-ak6NoX_4Aeg_-718885893")]
    [Description(@"Insufficient or incoherent details about the creditor with respect to regulatory requirements.")]
    InsufficientCreditorDetails = UnableToApplyIncorrectInfoCode.InsufficientCreditorDetails, // same ordinal as derivation source for type conversions
    
}
