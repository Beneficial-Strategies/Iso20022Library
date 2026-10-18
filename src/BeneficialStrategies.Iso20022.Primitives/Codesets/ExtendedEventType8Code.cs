// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mrreAaNZEfC9id413JK-Ig")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type."
)]
[DerivedFrom(typeof(ExtendedEventTypeV2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExtendedEventType8Code>))]
public enum ExtendedEventType8Code
{
    /// <summary>
    /// Feature of a security that allows an issuer to make a payment to the security holder. This event will be used for securities subject to redemptions other than those categorised as full and partial calls (for example early Certificate of Deposit redemptions).
    /// Encoded/decoded by serializers as &quot;CDRD&quot;.
    /// </summary>
    [EnumMember(Value = "CDRD")]
    [IsoId("_my3rIaNZEfC9id413JK-Ig")]
    [Description(
        @"Feature of a security that allows an issuer to make a payment to the security holder. This event will be used for securities subject to redemptions other than those categorised as full and partial calls (for example early Certificate of Deposit redemptions)."
    )]
    CertificateOfDepositEarlyRedemption = ExtendedEventTypeV2Code.CertificateOfDepositEarlyRedemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final distribution of principal due on a security, typically Collateralised Mortgage Obligations.
    /// Encoded/decoded by serializers as &quot;FPAY&quot;.
    /// </summary>
    [EnumMember(Value = "FPAY")]
    [IsoId("_my3rI6NZEfC9id413JK-Ig")]
    [Description(@"Final distribution of principal due on a security, typically Collateralised Mortgage Obligations.")]
    FinalPaydown = ExtendedEventTypeV2Code.FinalPaydown, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt.
    /// Encoded/decoded by serializers as &quot;FPRE&quot;.
    /// </summary>
    [EnumMember(Value = "FPRE")]
    [IsoId("_oKhakaNZEfC9id413JK-Ig")]
    [Description(
        @"Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt."
    )]
    FullPrefunding = ExtendedEventTypeV2Code.FullPrefunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event is a redemption of warrant.
    /// Encoded/decoded by serializers as &quot;REDW&quot;.
    /// </summary>
    [EnumMember(Value = "REDW")]
    [IsoId("_my3rJaNZEfC9id413JK-Ig")]
    [Description(@"Event is a redemption of warrant.")]
    RedemptionOfWarrant = ExtendedEventTypeV2Code.RedemptionOfWarrant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_my3rJ6NZEfC9id413JK-Ig")]
    [Description(
        @"Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code."
    )]
    Termination = ExtendedEventTypeV2Code.Termination, // same ordinal as derivation source for type conversions
}
