// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of repurchase transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_e06jwI-REeaVK-2bgpxeYw")]
[Description(@"Specifies the type of repurchase transaction.")]
[DerivedFrom(typeof(RepurchaseTypeV2Code))]
public enum RepurchaseType9Code
{
    /// <summary>
    /// Relates to a transaction that is paired off and netted against one or more previous transactions. A paired off transaction is a buyback to offset and effectively liquidate a prior sale of securities or a sellback to offset and effectively liquidate a prior buy of securities.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_hiF7sY-REeaVK-2bgpxeYw")]
    [Description(
        @"Relates to a transaction that is paired off and netted against one or more previous transactions. A paired off transaction is a buyback to offset and effectively liquidate a prior sale of securities or a sellback to offset and effectively liquidate a prior buy of securities."
    )]
    Pairoff = RepurchaseTypeV2Code.Pairoff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a principal adjustment.
    /// Encoded/decoded by serializers as &quot;PADJ&quot;.
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_h9wkAY-REeaVK-2bgpxeYw")]
    [Description(@"Relates to a principal adjustment.")]
    PrincipalExposureAdjustment = RepurchaseTypeV2Code.PrincipalExposureAdjustment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_iiqA0Y-REeaVK-2bgpxeYw")]
    [Description(@"Is part of a pair-off.")]
    RepoRate = RepurchaseTypeV2Code.RepoRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to the early closing/maturity date for a term repo or a termination date of an open repo with the underlying collateral.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_i4-PEY-REeaVK-2bgpxeYw")]
    [Description(
        @"Relates to the early closing/maturity date for a term repo or a termination date of an open repo with the underlying collateral."
    )]
    RepurchaseCall = RepurchaseTypeV2Code.RepurchaseCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a contract extending the closing or maturity date without the underlying collateral impacted.
    /// Encoded/decoded by serializers as &quot;ROLP&quot;.
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_jNNZsY-REeaVK-2bgpxeYw")]
    [Description(
        @"Relates to a repo rollover of a contract extending the closing or maturity date without the underlying collateral impacted."
    )]
    RepoContractRollover = RepurchaseTypeV2Code.RepoContractRollover, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a swap/substitution.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_jkRO0Y-REeaVK-2bgpxeYw")]
    [Description(@"Relates to a swap/substitution.")]
    Swap = RepurchaseTypeV2Code.Swap, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;TOPU&quot;.
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_j_fyQY-REeaVK-2bgpxeYw")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    TopUp = RepurchaseTypeV2Code.TopUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_kH0n0Y-REeaVK-2bgpxeYw")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Withdrawal = RepurchaseTypeV2Code.Withdrawal, // same ordinal as derivation source for type conversions
}
