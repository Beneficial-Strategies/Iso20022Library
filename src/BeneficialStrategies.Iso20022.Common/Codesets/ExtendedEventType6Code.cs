// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_32I1Ub_pEeeb2ZBoAlSG1Q")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.")]
[DerivedFrom(typeof(ExtendedEventTypeV2Code))]
public enum ExtendedEventType6Code
{
    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_4GDgob_pEeeb2ZBoAlSG1Q")]
    [Description(@"Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.")]
    Termination = ExtendedEventTypeV2Code.Termination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Final distribution of principal due on a security, typically Collateralised Mortgage Obligations.
    /// Encoded/decoded by serializers as &quot;FPAY&quot;.
    /// </summary>
    [EnumMember(Value = "FPAY")]
    [IsoId("_4GDgo7_pEeeb2ZBoAlSG1Q")]
    [Description(@"Final distribution of principal due on a security, typically Collateralised Mortgage Obligations.")]
    FinalPaydown = ExtendedEventTypeV2Code.FinalPaydown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature of a security that allows an issuer to make a payment to the security holder. This event will be used for securities subject to redemptions other than those categorised as full and partial calls (for example early Certificate of Deposit redemptions).
    /// Encoded/decoded by serializers as &quot;CDRD&quot;.
    /// </summary>
    [EnumMember(Value = "CDRD")]
    [IsoId("_4GDgpb_pEeeb2ZBoAlSG1Q")]
    [Description(@"Feature of a security that allows an issuer to make a payment to the security holder. This event will be used for securities subject to redemptions other than those categorised as full and partial calls (for example early Certificate of Deposit redemptions).")]
    CertificateOfDepositEarlyRedemption = ExtendedEventTypeV2Code.CertificateOfDepositEarlyRedemption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Event is a redemption of warrant.
    /// Encoded/decoded by serializers as &quot;REDW&quot;.
    /// </summary>
    [EnumMember(Value = "REDW")]
    [IsoId("_BkJywb_qEeeb2ZBoAlSG1Q")]
    [Description(@"Event is a redemption of warrant.")]
    RedemptionOfWarrant = ExtendedEventTypeV2Code.RedemptionOfWarrant, // same ordinal as derivation source for type conversions
    
}
