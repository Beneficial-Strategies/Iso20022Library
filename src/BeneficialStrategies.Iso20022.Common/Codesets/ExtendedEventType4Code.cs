// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-mm30ZESEeajS_7NioJdVA")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.")]
[DerivedFrom(typeof(ExtendedEventTypeV2Code))]
public enum ExtendedEventType4Code
{
    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("__CIWMZESEeajS_7NioJdVA")]
    [Description(@"Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.")]
    Termination = ExtendedEventTypeV2Code.Termination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Final distribution of principal due on a security, typically Collateralised Mortgage Obligations.
    /// Encoded/decoded by serializers as &quot;FPAY&quot;.
    /// </summary>
    [EnumMember(Value = "FPAY")]
    [IsoId("_BGZUAZETEeajS_7NioJdVA")]
    [Description(@"Final distribution of principal due on a security, typically Collateralised Mortgage Obligations.")]
    FinalPaydown = ExtendedEventTypeV2Code.FinalPaydown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Feature of a security that allows an issuer to make a payment to the security holder. This event will be used for securities subject to redemptions other than those categorised as full and partial calls (for example early Certificate of Deposit redemptions).
    /// Encoded/decoded by serializers as &quot;CDRD&quot;.
    /// </summary>
    [EnumMember(Value = "CDRD")]
    [IsoId("_BVkYcZETEeajS_7NioJdVA")]
    [Description(@"Feature of a security that allows an issuer to make a payment to the security holder. This event will be used for securities subject to redemptions other than those categorised as full and partial calls (for example early Certificate of Deposit redemptions).")]
    CertificateOfDepositEarlyRedemption = ExtendedEventTypeV2Code.CertificateOfDepositEarlyRedemption, // same ordinal as derivation source for type conversions
    
}
