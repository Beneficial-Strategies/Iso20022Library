// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the additional business process linked to a corporate action event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Kr4lAWH-EeWNUe-5HV3A_g")]
[Description(@"Specifies the additional business process linked to a corporate action event.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AdditionalBusinessProcess5Code>))]
#endif
public enum AdditionalBusinessProcess5Code
{
    /// <summary>
    /// Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;ACLA&quot;.
    /// </summary>
    [EnumMember(Value = "ACLA")]
    [IsoId("_LC8aIWH-EeWNUe-5HV3A_g")]
    [Description(
        @"Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD)."
    )]
    AutomaticMarketClaim = AdditionalBusinessProcessCode.AutomaticMarketClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).
    /// Encoded/decoded by serializers as &quot;ATXF&quot;.
    /// </summary>
    [EnumMember(Value = "ATXF")]
    [IsoId("_LC8aI2H-EeWNUe-5HV3A_g")]
    [Description(
        @"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s)."
    )]
    SubjectToTransformation = AdditionalBusinessProcessCode.SubjectToTransformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_LC8aJWH-EeWNUe-5HV3A_g")]
    [Description(
        @"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system."
    )]
    CancelUnderlyingTrades = AdditionalBusinessProcessCode.CancelUnderlyingTrades, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NAMC&quot;.
    /// </summary>
    [EnumMember(Value = "NAMC")]
    [IsoId("_LC8aJ2H-EeWNUe-5HV3A_g")]
    [Description(
        @"Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD)."
    )]
    NoAutomaticMarketClaimsAndTransformations =
        AdditionalBusinessProcessCode.NoAutomaticMarketClaimsAndTransformations, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer only allows a single option to be selected per designated holding.
    /// Encoded/decoded by serializers as &quot;NPLE&quot;.
    /// </summary>
    [EnumMember(Value = "NPLE")]
    [IsoId("_LC8aKWH-EeWNUe-5HV3A_g")]
    [Description(@"Issuer only allows a single option to be selected per designated holding.")]
    NoSplitElection = AdditionalBusinessProcessCode.NoSplitElection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.
    /// Encoded/decoded by serializers as &quot;SCHM&quot;.
    /// </summary>
    [EnumMember(Value = "SCHM")]
    [IsoId("_LC8aK2H-EeWNUe-5HV3A_g")]
    [Description(
        @"Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital."
    )]
    SchemeOrPlanOfArrangement = AdditionalBusinessProcessCode.SchemeOrPlanOfArrangement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_LC8aLWH-EeWNUe-5HV3A_g")]
    [Description(
        @"Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS)."
    )]
    Consent = AdditionalBusinessProcessCode.Consent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event.
    /// Encoded/decoded by serializers as &quot;PPUT&quot;.
    /// </summary>
    [EnumMember(Value = "PPUT")]
    [IsoId("_SpJWgWH-EeWNUe-5HV3A_g")]
    [Description(
        @"Partial mandatory exchange of a portion of bonds where the exchanged securities are usually remarketed. The issuer may offer holders the right to retain instead of exchanging their securities. A lottery will be used to determine eligibility for the event."
    )]
    PartialMandatoryPutRedemption = AdditionalBusinessProcessCode.PartialMandatoryPutRedemption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as &quot;FPRE&quot;.
    /// </summary>
    [EnumMember(Value = "FPRE")]
    [IsoId("_jluhgWIAEeWNUe-5HV3A_g")]
    [Description(
        @"Full pre-funding of a debt instrument by the issuer prior to original maturity when the issuer deposits assets in trust. Applicable only in the frame of a partial defeasance corporate action event."
    )]
    FullPrefunding = AdditionalBusinessProcessCode.FullPrefunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event.
    /// Encoded/decoded by serializers as &quot;PPRE&quot;.
    /// </summary>
    [EnumMember(Value = "PPRE")]
    [IsoId("_jr0icWIAEeWNUe-5HV3A_g")]
    [Description(
        @"Partial pre-funding of a debt instrument prior to maturity drawn through a lottery process. One new security is issued with an earlier maturity date for the refunded (called portion) and the other new security is issued with the original maturity date for the non refunded (remaining) portion. Applicable only in the frame of a partial defeasance corporate action event."
    )]
    PartialPreFunding = AdditionalBusinessProcessCode.PartialPreFunding, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner.
    /// Encoded/decoded by serializers as &quot;REAC&quot;.
    /// </summary>
    [EnumMember(Value = "REAC")]
    [IsoId("_ILh18WKfEeWR9ZSfjmHwUA")]
    [Description(
        @"Proceeds / entitlements of the mandatory event can only be paid if specified action is taken by the account owner."
    )]
    RequiredAction = AdditionalBusinessProcessCode.RequiredAction, // same ordinal as derivation source for type conversions
}
