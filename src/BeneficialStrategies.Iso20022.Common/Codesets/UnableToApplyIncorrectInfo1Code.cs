// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Used when the unable to apply is due to incorrect information.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Vncustp-Ed-ak6NoX_4Aeg_1226420909")]
[Description(@"Used when the unable to apply is due to incorrect information.")]
[DerivedFrom(typeof(UnableToApplyIncorrectInfoCode))]
[Obsolete("Formally obsoleted in the ISO 20022 specification. No removal date recorded.")]
public enum UnableToApplyIncorrectInfo1Code
{
    /// <summary>
    /// RelatedReference is incorrect.
    /// Encoded/decoded by serializers as &quot;IN01&quot;.
    /// </summary>
    [EnumMember(Value = "IN01")]
    [IsoId("_Vncus9p-Ed-ak6NoX_4Aeg_-121794033")]
    [Description(@"RelatedReference is incorrect.")]
    IncorrectRelatedReference = UnableToApplyIncorrectInfoCode.IncorrectRelatedReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// BankOperationCode is incorrect.
    /// Encoded/decoded by serializers as &quot;IN02&quot;.
    /// </summary>
    [EnumMember(Value = "IN02")]
    [IsoId("_VncutNp-Ed-ak6NoX_4Aeg_-121793700")]
    [Description(@"BankOperationCode is incorrect.")]
    IncorrectBankOperationCode = UnableToApplyIncorrectInfoCode.IncorrectBankOperationCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructionCode is incorrect.
    /// Encoded/decoded by serializers as &quot;IN03&quot;.
    /// </summary>
    [EnumMember(Value = "IN03")]
    [IsoId("_Vncutdp-Ed-ak6NoX_4Aeg_-121793665")]
    [Description(@"InstructionCode is incorrect.")]
    IncorrectInstructionCode = UnableToApplyIncorrectInfoCode.IncorrectInstructionCode, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RequestedExecutionDate is incorrect.
    /// Encoded/decoded by serializers as &quot;IN04&quot;.
    /// </summary>
    [EnumMember(Value = "IN04")]
    [IsoId("_Vncuttp-Ed-ak6NoX_4Aeg_-121793630")]
    [Description(@"RequestedExecutionDate is incorrect.")]
    IncorrectRequestedExecutionDate = UnableToApplyIncorrectInfoCode.IncorrectRequestedExecutionDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ValueDate is incorrect.
    /// Encoded/decoded by serializers as &quot;IN05&quot;.
    /// </summary>
    [EnumMember(Value = "IN05")]
    [IsoId("_Vncut9p-Ed-ak6NoX_4Aeg_-121793588")]
    [Description(@"ValueDate is incorrect.")]
    IncorrectValueDate = UnableToApplyIncorrectInfoCode.IncorrectValueDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InterbankSettledAmount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN06&quot;.
    /// </summary>
    [EnumMember(Value = "IN06")]
    [IsoId("_VncuuNp-Ed-ak6NoX_4Aeg_-121793570")]
    [Description(@"InterbankSettledAmount is incorrect.")]
    IncorrectInterbankSettledAmount = UnableToApplyIncorrectInfoCode.IncorrectInterbankSettledAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Debtor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN07&quot;.
    /// </summary>
    [EnumMember(Value = "IN07")]
    [IsoId("_VnmfsNp-Ed-ak6NoX_4Aeg_-121793528")]
    [Description(@"Debtor is incorrect.")]
    IncorrectDebtor = UnableToApplyIncorrectInfoCode.IncorrectDebtor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DebtorAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN08&quot;.
    /// </summary>
    [EnumMember(Value = "IN08")]
    [IsoId("_Vnmfsdp-Ed-ak6NoX_4Aeg_-121793493")]
    [Description(@"DebtorAccount is incorrect.")]
    IncorrectDebtorAccount = UnableToApplyIncorrectInfoCode.IncorrectDebtorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ReceiverCorrespondent is incorrect.
    /// Encoded/decoded by serializers as &quot;IN09&quot;.
    /// </summary>
    [EnumMember(Value = "IN09")]
    [IsoId("_Vnmfstp-Ed-ak6NoX_4Aeg_-121793233")]
    [Description(@"ReceiverCorrespondent is incorrect.")]
    IncorrectReceiverCorrespondent = UnableToApplyIncorrectInfoCode.IncorrectReceiverCorrespondent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ThirdReimbursementInstitution is incorrect.
    /// Encoded/decoded by serializers as &quot;IN10&quot;.
    /// </summary>
    [EnumMember(Value = "IN10")]
    [IsoId("_Vnmfs9p-Ed-ak6NoX_4Aeg_-121793198")]
    [Description(@"ThirdReimbursementInstitution is incorrect.")]
    IncorrectThirdReimbursementInstitution = UnableToApplyIncorrectInfoCode.IncorrectThirdReimbursementInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PaymentScheme is incorrect.
    /// Encoded/decoded by serializers as &quot;IN11&quot;.
    /// </summary>
    [EnumMember(Value = "IN11")]
    [IsoId("_VnmftNp-Ed-ak6NoX_4Aeg_-121793156")]
    [Description(@"PaymentScheme is incorrect.")]
    IncorrectPaymentScheme = UnableToApplyIncorrectInfoCode.IncorrectPaymentScheme, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// AccountOfBeneficiaryInstitution is incorrect.
    /// Encoded/decoded by serializers as &quot;IN12&quot;.
    /// </summary>
    [EnumMember(Value = "IN12")]
    [IsoId("_Vnmftdp-Ed-ak6NoX_4Aeg_-121793121")]
    [Description(@"AccountOfBeneficiaryInstitution is incorrect.")]
    IncorrectAccountOfBeneficiaryInstitution = UnableToApplyIncorrectInfoCode.IncorrectAccountOfBeneficiaryInstitution, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creditor is incorrect.
    /// Encoded/decoded by serializers as &quot;IN13&quot;.
    /// </summary>
    [EnumMember(Value = "IN13")]
    [IsoId("_Vnmfttp-Ed-ak6NoX_4Aeg_-121793078")]
    [Description(@"Creditor is incorrect.")]
    IncorrectCreditor = UnableToApplyIncorrectInfoCode.IncorrectCreditor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// CreditorAccount is incorrect.
    /// Encoded/decoded by serializers as &quot;IN14&quot;.
    /// </summary>
    [EnumMember(Value = "IN14")]
    [IsoId("_Vnmft9p-Ed-ak6NoX_4Aeg_-121792795")]
    [Description(@"CreditorAccount is incorrect.")]
    IncorrectCreditorAccount = UnableToApplyIncorrectInfoCode.IncorrectCreditorAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// RemittanceInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN15&quot;.
    /// </summary>
    [EnumMember(Value = "IN15")]
    [IsoId("_VnmfuNp-Ed-ak6NoX_4Aeg_-121792734")]
    [Description(@"RemittanceInformation is incorrect.")]
    IncorrectRemittanceInformation = UnableToApplyIncorrectInfoCode.IncorrectRemittanceInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PaymentPurpose is incorrect.
    /// Encoded/decoded by serializers as &quot;IN16&quot;.
    /// </summary>
    [EnumMember(Value = "IN16")]
    [IsoId("_Vnmfudp-Ed-ak6NoX_4Aeg_-121792614")]
    [Description(@"PaymentPurpose is incorrect.")]
    IncorrectPaymentPurpose = UnableToApplyIncorrectInfoCode.IncorrectPaymentPurpose, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// DetailsOfCharges is incorrect.
    /// Encoded/decoded by serializers as &quot;IN17&quot;.
    /// </summary>
    [EnumMember(Value = "IN17")]
    [IsoId("_VnvpoNp-Ed-ak6NoX_4Aeg_-121792579")]
    [Description(@"DetailsOfCharges is incorrect.")]
    IncorrectDetailsOfCharges = UnableToApplyIncorrectInfoCode.IncorrectDetailsOfCharges, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// SenderToReceiverInformation is incorrect.
    /// Encoded/decoded by serializers as &quot;IN18&quot;.
    /// </summary>
    [EnumMember(Value = "IN18")]
    [IsoId("_Vnvpodp-Ed-ak6NoX_4Aeg_-121792519")]
    [Description(@"SenderToReceiverInformation is incorrect.")]
    IncorrectSenderToReceiverInformation = UnableToApplyIncorrectInfoCode.IncorrectSenderToReceiverInformation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// InstructionForFinalAgent is incorrect.
    /// Encoded/decoded by serializers as &quot;IN19&quot;.
    /// </summary>
    [EnumMember(Value = "IN19")]
    [IsoId("_Vnvpotp-Ed-ak6NoX_4Aeg_-121792267")]
    [Description(@"InstructionForFinalAgent is incorrect.")]
    IncorrectInstructionForFinalAgent = UnableToApplyIncorrectInfoCode.IncorrectInstructionForFinalAgent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and Account of Creditor mismatched.
    /// Encoded/decoded by serializers as &quot;MM20&quot;.
    /// </summary>
    [EnumMember(Value = "MM20")]
    [IsoId("_Vnvpo9p-Ed-ak6NoX_4Aeg_1717924661")]
    [Description(@"Name and Account of Creditor mismatched.")]
    MismatchCreditorNameAccount = UnableToApplyIncorrectInfoCode.MismatchCreditorNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and Account of Debtor mismatched.
    /// Encoded/decoded by serializers as &quot;MM21&quot;.
    /// </summary>
    [EnumMember(Value = "MM21")]
    [IsoId("_VnvppNp-Ed-ak6NoX_4Aeg_1807504359")]
    [Description(@"Name and Account of Debtor mismatched.")]
    MismatchDebtorNameAccount = UnableToApplyIncorrectInfoCode.MismatchDebtorNameAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Name and Account of FinalAgent mismatched.
    /// Encoded/decoded by serializers as &quot;MM22&quot;.
    /// </summary>
    [EnumMember(Value = "MM22")]
    [IsoId("_Vnvppdp-Ed-ak6NoX_4Aeg_1849988214")]
    [Description(@"Name and Account of FinalAgent mismatched.")]
    MismatchFinalAgentNameAccount = UnableToApplyIncorrectInfoCode.MismatchFinalAgentNameAccount, // same ordinal as derivation source for type conversions
    
}
