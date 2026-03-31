// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Relates to a principal adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZT7ngNp-Ed-ak6NoX_4Aeg_605345255")]
[Description(@"Relates to a principal adjustment.")]
[Derivations(
    typeof(RepurchaseType7Code),
    typeof(RepurchaseType3Code),
    typeof(RepurchaseType6Code),
    typeof(RepurchaseType4Code),
    typeof(RepurchaseType5Code),
    typeof(RepurchaseType2Code)
)]
public enum RepurchaseTypeCode
{
    /// <summary>
    /// Relates to a Swap/Substitution.
    /// Encoded/decoded by serializers as &quot;CADJ&quot;.
    /// </summary>
    [EnumMember(Value = "CADJ")]
    [IsoId("_ZT7ngdp-Ed-ak6NoX_4Aeg_605345257")]
    [Description(@"Relates to a Swap/Substitution.")]
    Swap,

    /// <summary>
    /// Relates to a change in the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_ZT7ngtp-Ed-ak6NoX_4Aeg_605345286")]
    [Description(@"Relates to a change in the closing or maturity date.")]
    RepurchaseCall,

    /// <summary>
    /// Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions.
    /// Encoded/decoded by serializers as &quot;PAIR&quot;.
    /// </summary>
    [EnumMember(Value = "PAIR")]
    [IsoId("_ZT7ng9p-Ed-ak6NoX_4Aeg_605345287")]
    [Description(
        @"Relates to a pair-off: the transaction is paired off and netted against one or more previous transactions."
    )]
    Pairoff,

    /// <summary>
    /// Is part of a pair-off.
    /// Encoded/decoded by serializers as &quot;RATE&quot;.
    /// </summary>
    [EnumMember(Value = "RATE")]
    [IsoId("_ZT7nhNp-Ed-ak6NoX_4Aeg_605345316")]
    [Description(@"Is part of a pair-off.")]
    RepoRate,

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;ROLP&quot;.
    /// </summary>
    [EnumMember(Value = "ROLP")]
    [IsoId("_ZT7nhdp-Ed-ak6NoX_4Aeg_605345317")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Rollover,

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;TOPU&quot;.
    /// </summary>
    [EnumMember(Value = "TOPU")]
    [IsoId("_ZT7nhtp-Ed-ak6NoX_4Aeg_605345564")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    TopUp,

    /// <summary>
    /// Relates to a repo rollover of a position extending the closing or maturity date.
    /// Encoded/decoded by serializers as &quot;WTHD&quot;.
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_ZT7nh9p-Ed-ak6NoX_4Aeg_605345565")]
    [Description(
        @"Relates to a repo rollover of a position extending the closing or maturity date."
    )]
    Withdrawal,

    /// <summary>
    /// Relates to a principal adjustment.
    /// Encoded/decoded by serializers as &quot;PADJ&quot;.
    /// </summary>
    [EnumMember(Value = "PADJ")]
    [IsoId("_ZT7niNp-Ed-ak6NoX_4Aeg_690308694")]
    [Description(@"Relates to a principal adjustment.")]
    PrincipalExposureAdjustment,
}
