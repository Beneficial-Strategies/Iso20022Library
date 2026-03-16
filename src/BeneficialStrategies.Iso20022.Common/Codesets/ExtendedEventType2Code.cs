// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZcengHniEeO2o_OAyvnbZw")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined corporate action event type."
)]
[DerivedFrom(typeof(ExtendedEventTypeV2Code))]
public enum ExtendedEventType2Code
{
    /// <summary>
    /// Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;BRIS&quot;.
    /// </summary>
    [EnumMember(Value = "BRIS")]
    [IsoId("_hsMa8XniEeO2o_OAyvnbZw")]
    [Description(
        @"Security holders are issued additional securities, free of payment, from the issuer in proportion to their holdings. A bonus issue is typically represented by shares or warrants. Nominal value does not change. The security holder may be offered choice of entitlement. Distinguishes from Rights Subscription, Sale Of Rights event types mapped to the same ISO event type code."
    )]
    BonusRightsIssue = ExtendedEventTypeV2Code.BonusRightsIssue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from &quot;partial defeasance&quot;, &quot;partial prerefunding&quot; event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;FLPR&quot;.
    /// </summary>
    [EnumMember(Value = "FLPR")]
    [IsoId("_h2m7MXniEeO2o_OAyvnbZw")]
    [Description(
        @"Exercise of a privilege by the issuer to repay, in full, any debt security prior to maturity when the issuer deposits assets in trust. This irrevocably restricts their use to satisfaction of the debt. Distinguishes from ""partial defeasance"", ""partial prerefunding"" event types mapped to the same ISO event type code."
    )]
    FullPrerefunding = ExtendedEventTypeV2Code.FullPrerefunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer sets aside funds in escrow to guarantee payment for the portion of the security on maturity date. Defeased and Non-defeased cusips are issued respectively for the defeased and non-defeased portions.
    /// Encoded/decoded by serializers as &quot;PDEF&quot;.
    /// </summary>
    [EnumMember(Value = "PDEF")]
    [IsoId("_iBBbcXniEeO2o_OAyvnbZw")]
    [Description(
        @"Issuer sets aside funds in escrow to guarantee payment for the portion of the security on maturity date. Defeased and Non-defeased cusips are issued respectively for the defeased and non-defeased portions."
    )]
    PartialDefeasance = ExtendedEventTypeV2Code.PartialDefeasance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities.
    /// Encoded/decoded by serializers as &quot;PPUT&quot;.
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_iLSKsXniEeO2o_OAyvnbZw")]
    [Description(
        @"The mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities."
    )]
    PartialMandatoryPut = ExtendedEventTypeV2Code.PartialMandatoryPut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer sets aside funds in escrow to guarantee payment for the portion of the security prior to maturity date. Refunded and Non-Refunded cusips are issued respectively for the refunded and non-refunded portions.
    /// Encoded/decoded by serializers as &quot;PPRE&quot;.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_iVi58XniEeO2o_OAyvnbZw")]
    [Description(
        @"Issuer sets aside funds in escrow to guarantee payment for the portion of the security prior to maturity date. Refunded and Non-Refunded cusips are issued respectively for the refunded and non-refunded portions."
    )]
    PartialPrerefunding = ExtendedEventTypeV2Code.PartialPrerefunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// General information provided by the issuer that should not result in material changes to the security.
    /// Encoded/decoded by serializers as &quot;RPLA&quot;.
    /// </summary>
    [EnumMember(Value = "RPLA")]
    [IsoId("_iYOagXniEeO2o_OAyvnbZw")]
    [Description(
        @"General information provided by the issuer that should not result in material changes to the security."
    )]
    RightsPlanAdoption = ExtendedEventTypeV2Code.RightsPlanAdoption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code.
    /// Encoded/decoded by serializers as &quot;TMTN&quot;.
    /// </summary>
    [EnumMember(Value = "TMTN")]
    [IsoId("_iio6wXniEeO2o_OAyvnbZw")]
    [Description(
        @"Security, usually a form of a derivative, for which the agent or issuer has decided to terminate the derivative based on a change to the underlying security(ies) or a change in strategy. Distinguishes from Mandatory Exchange, Exchange Offer event types mapped to the same ISO event type code."
    )]
    Termination = ExtendedEventTypeV2Code.Termination, // same ordinal as derivation source for type conversions
}
