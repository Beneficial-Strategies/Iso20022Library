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
[IsoId("_bqSa49p-Ed-ak6NoX_4Aeg_1581017079")]
[Description(@"Specifies the additional business process linked to a corporate action event.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AdditionalBusinessProcess1Code>))]
#endif
public enum AdditionalBusinessProcess1Code
{
    /// <summary>
    /// Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;ACLA&quot;.
    /// </summary>
    [EnumMember(Value = "ACLA")]
    [IsoId("_bqSa5Np-Ed-ak6NoX_4Aeg_1581017081")]
    [Description(
        @"Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD)."
    )]
    AutomaticMarketClaim = AdditionalBusinessProcessCode.AutomaticMarketClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).
    /// Encoded/decoded by serializers as &quot;ATXF&quot;.
    /// </summary>
    [EnumMember(Value = "ATXF")]
    [IsoId("_bqSa5dp-Ed-ak6NoX_4Aeg_1581017097")]
    [Description(
        @"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s)."
    )]
    SubjectToTransformation = AdditionalBusinessProcessCode.SubjectToTransformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_bqSa5tp-Ed-ak6NoX_4Aeg_1581017098")]
    [Description(
        @"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system."
    )]
    CancelUnderlyingTrades = AdditionalBusinessProcessCode.CancelUnderlyingTrades, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NAMC&quot;.
    /// </summary>
    [EnumMember(Value = "NAMC")]
    [IsoId("_bqSa59p-Ed-ak6NoX_4Aeg_1581017122")]
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
    [IsoId("_bqSa6Np-Ed-ak6NoX_4Aeg_1581017123")]
    [Description(@"Issuer only allows a single option to be selected per designated holding.")]
    NoSplitElection = AdditionalBusinessProcessCode.NoSplitElection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.
    /// Encoded/decoded by serializers as &quot;SCHM&quot;.
    /// </summary>
    [EnumMember(Value = "SCHM")]
    [IsoId("_bqSa6dp-Ed-ak6NoX_4Aeg_1581017139")]
    [Description(
        @"Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital."
    )]
    SchemeOrPlanOfArrangement = AdditionalBusinessProcessCode.SchemeOrPlanOfArrangement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_bqSa6tp-Ed-ak6NoX_4Aeg_-912746764")]
    [Description(
        @"Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS)."
    )]
    Consent = AdditionalBusinessProcessCode.Consent, // same ordinal as derivation source for type conversions
}
