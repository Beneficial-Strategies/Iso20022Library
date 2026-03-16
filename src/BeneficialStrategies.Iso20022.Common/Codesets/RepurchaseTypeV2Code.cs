// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Relates to a principal adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_oOW02Y-QEeaVK-2bgpxeYw")]
[Description(@"Relates to a principal adjustment.")]
[Derivations(
    typeof(RepurchaseType8Code),
    typeof(RepurchaseType10Code),
    typeof(RepurchaseType9Code)
)]
public enum RepurchaseTypeV2Code
{
    /// <summary>
    /// Relates to a swap/substitution.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_oOW03o-QEeaVK-2bgpxeYw")]
    [Description(@"Relates to a swap/substitution.")]
    Swap,

    /// <summary>
    /// Relates to the early closing/maturity date for a term repo or a termination date of an open repo with the underlying collateral.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_oOW02o-QEeaVK-2bgpxeYw")]
    [Description(
        @"Relates to the early closing/maturity date for a term repo or a termination date of an open repo with the underlying collateral."
    )]
    RepurchaseCall,

    /// <summary>
    /// Relates to a transaction that is paired off and netted against one or more previous transactions. A paired off transaction is a buyback to offset and effectively liquidate a prior sale of securities or a sellback to offset and effectively liquidate a prior buy of securities.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_oOW03Y-QEeaVK-2bgpxeYw")]
    [Description(
        @"Relates to a transaction that is paired off and netted against one or more previous transactions. A paired off transaction is a buyback to offset and effectively liquidate a prior sale of securities or a sellback to offset and effectively liquidate a prior buy of securities."
    )]
    Pairoff,

    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_oOW03I-QEeaVK-2bgpxeYw")]
    [Description(@"Is part of a pair-off.")]
    RepoRate,

    /// <summary>
    /// Relates to a repo rollover of a contract extending the closing or maturity date without the underlying collateral impacted.
    /// Encoded/decoded by serializers as &quot;ROLP&quot;.
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_oOW04I-QEeaVK-2bgpxeYw")]
    [Description(
        @"Relates to a repo rollover of a contract extending the closing or maturity date without the underlying collateral impacted."
    )]
    RepoContractRollover,

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;TOPU&quot;.
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_oOW024-QEeaVK-2bgpxeYw")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    TopUp,

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_oOW04Y-QEeaVK-2bgpxeYw")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Withdrawal,

    /// <summary>
    /// Relates to a principal adjustment.
    /// Encoded/decoded by serializers as &quot;PADJ&quot;.
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_oOW034-QEeaVK-2bgpxeYw")]
    [Description(@"Relates to a principal adjustment.")]
    PrincipalExposureAdjustment,
}
