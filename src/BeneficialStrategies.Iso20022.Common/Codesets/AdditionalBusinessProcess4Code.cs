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
[IsoId("_V_8rgQFpEeGXDp73SgCmsg")]
[Description(@"Specifies the additional business process linked to a corporate action event.")]
[DerivedFrom(typeof(AdditionalBusinessProcessCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AdditionalBusinessProcess4Code>))]
#endif
public enum AdditionalBusinessProcess4Code
{
    /// <summary>
    /// Relates to a claim on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;CLAI&quot;.
    /// </summary>
    [EnumMember(Value = "CLAI")]
    [IsoId("_V_8rhwFpEeGXDp73SgCmsg")]
    [Description(@"Relates to a claim on the associated corporate action event.")]
    ClaimOrCompensation = AdditionalBusinessProcessCode.ClaimOrCompensation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a tax refund from the authorities on the associated corporate action event.
    /// Encoded/decoded by serializers as &quot;TAXR&quot;.
    /// </summary>
    [EnumMember(Value = "TAXR")]
    [IsoId("_V_8riwFpEeGXDp73SgCmsg")]
    [Description(
        @"Relates to a tax refund from the authorities on the associated corporate action event."
    )]
    TaxRefund = AdditionalBusinessProcessCode.TaxRefund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;ACLA&quot;.
    /// </summary>
    [EnumMember(Value = "ACLA")]
    [IsoId("_XHoFSgFpEeGXDp73SgCmsg")]
    [Description(
        @"Will automatically give rise to market claims by the account servicer, for example, a Central Securities Depository (CSD)."
    )]
    AutomaticMarketClaim = AdditionalBusinessProcessCode.AutomaticMarketClaim, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s).
    /// Encoded/decoded by serializers as &quot;ATXF&quot;.
    /// </summary>
    [EnumMember(Value = "ATXF")]
    [IsoId("_XoQtIgFpEeGXDp73SgCmsg")]
    [Description(
        @"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system and replaced with transactions in the outturn resource(s)."
    )]
    SubjectToTransformation = AdditionalBusinessProcessCode.SubjectToTransformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// As a result of the corporate action, all transactions in the underlying security will be cancelled by the system.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_YP578gFpEeGXDp73SgCmsg")]
    [Description(
        @"As a result of the corporate action, all transactions in the underlying security will be cancelled by the system."
    )]
    CancelUnderlyingTrades = AdditionalBusinessProcessCode.CancelUnderlyingTrades, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS).
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_Y-ijkgFpEeGXDp73SgCmsg")]
    [Description(
        @"Relates to a consent within a corporate action event other than a Consent event (: 22F:: CAEV//CONS)."
    )]
    Consent = AdditionalBusinessProcessCode.Consent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Event will not automatically give rise to market claims and transformations by the account servicer, for example, a Central Securities Depository (CSD).
    /// Encoded/decoded by serializers as &quot;NAMC&quot;.
    /// </summary>
    [EnumMember(Value = "NAMC")]
    [IsoId("_Zcpb6gFpEeGXDp73SgCmsg")]
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
    [IsoId("_Z4EMmgFpEeGXDp73SgCmsg")]
    [Description(@"Issuer only allows a single option to be selected per designated holding.")]
    NoSplitElection = AdditionalBusinessProcessCode.NoSplitElection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital.
    /// Encoded/decoded by serializers as &quot;SCHM&quot;.
    /// </summary>
    [EnumMember(Value = "SCHM")]
    [IsoId("_afjqYgFpEeGXDp73SgCmsg")]
    [Description(
        @"Component event of a scheme/plan of arrangement: a reorganisation of a company or a group of companies, and their capital."
    )]
    SchemeOrPlanOfArrangement = AdditionalBusinessProcessCode.SchemeOrPlanOfArrangement, // same ordinal as derivation source for type conversions
}
