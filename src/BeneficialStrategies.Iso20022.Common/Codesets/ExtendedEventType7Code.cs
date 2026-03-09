// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BaYc8Em3Ee-NocYul3BKXQ")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.")]
[DerivedFrom(typeof(ExtendedEventTypeV2Code))]
public enum ExtendedEventType7Code
{
    /// <summary>
    /// Feature of a security that allows an issuer to make a payment to the security holders before the maturity date.
    /// Encoded/decoded by serializers as &quot;CDRD&quot;.
    /// </summary>
    [EnumMember(Value = "CDRD")]
    [IsoId("")]
    [Description(@"Feature of a security that allows an issuer to make a payment to the security holders before the maturity date.")]
    CertificateOfDepositEarlyRedemption = ExtendedEventTypeV2Code.CertificateOfDepositEarlyRedemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final distribution of principal due on a security, typically Collateralised Mortgage Obligation (CMO) or Asset Backed Security (ABS).
    /// Encoded/decoded by serializers as &quot;FPAY&quot;.
    /// </summary>
    [EnumMember(Value = "FPAY")]
    [IsoId("")]
    [Description(@"Final distribution of principal due on a security, typically Collateralised Mortgage Obligation (CMO) or Asset Backed Security (ABS).")]
    FinalPaydown = ExtendedEventTypeV2Code.FinalPaydown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a redemption of warrant.
    /// Encoded/decoded by serializers as &quot;REDW&quot;.
    /// </summary>
    [EnumMember(Value = "REDW")]
    [IsoId("")]
    [Description(@"Event is a redemption of warrant.")]
    RedemptionOfWarrant = ExtendedEventTypeV2Code.RedemptionOfWarrant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has declared the security to have terminated.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("")]
    [Description(@"Security, usually a form of a derivative, for which the agent or issuer has declared the security to have terminated.")]
    Termination = ExtendedEventTypeV2Code.Termination, // same ordinal as derivation source for type conversions

}
