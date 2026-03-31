// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3qOF4I-QEeaVK-2bgpxeYw")]
[Description(@"Specifies the type of repurchase transaction.")]
[DerivedFrom(typeof(RepurchaseTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RepurchaseType8Code>))]
#endif
public enum RepurchaseType8Code
{
    /// <summary>
    /// Relates to a principal adjustment.
    /// Encoded/decoded by serializers as &quot;PADJ&quot;.
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_CCDcYY-REeaVK-2bgpxeYw")]
    [Description(@"Relates to a principal adjustment.")]
    PrincipalExposureAdjustment = RepurchaseTypeV2Code.PrincipalExposureAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a contract extending the closing or maturity date without the underlying collateral impacted.
    /// Encoded/decoded by serializers as &quot;ROLP&quot;.
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_CG9KgY-REeaVK-2bgpxeYw")]
    [Description(
        @"Relates to a repo rollover of a contract extending the closing or maturity date without the underlying collateral impacted."
    )]
    RepoContractRollover = RepurchaseTypeV2Code.RepoContractRollover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_CTApgY-REeaVK-2bgpxeYw")]
    [Description(@"Is part of a pair-off.")]
    RepoRate = RepurchaseTypeV2Code.RepoRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the early closing/maturity date for a term repo or a termination date of an open repo with the underlying collateral.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_ENc88Y-REeaVK-2bgpxeYw")]
    [Description(
        @"Relates to the early closing/maturity date for a term repo or a termination date of an open repo with the underlying collateral."
    )]
    RepurchaseCall = RepurchaseTypeV2Code.RepurchaseCall, // same ordinal as derivation source for type conversions
}
