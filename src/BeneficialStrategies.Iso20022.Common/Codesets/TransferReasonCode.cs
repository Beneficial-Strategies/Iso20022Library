// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for the assets transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_le2Gw_r4EeCu2Z1WwxJVWA")]
[Description(@"Specifies the reason for the assets transfer.")]
[Derivations(typeof(TransferReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransferReasonCode>))]
#endif
public enum TransferReasonCode
{
    /// <summary>
    /// Transfer is ordinary.
    /// Encoded/decoded by serializers as &quot;TRAO&quot;.
    /// </summary>
    [EnumMember(Value = "TRAO")]
    [IsoId("_mFSbt_r4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is ordinary.")]
    OrdinaryTransfer,

    /// <summary>
    /// Transfer is between spouses.
    /// Encoded/decoded by serializers as &quot;TRAC&quot;.
    /// </summary>
    [EnumMember(Value = "TRAC")]
    [IsoId("_sGzSN_r4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is between spouses.")]
    TransferBetweenSpouses,

    /// <summary>
    /// Transfer is the result of a demerger or division.
    /// Encoded/decoded by serializers as &quot;TRAF&quot;.
    /// </summary>
    [EnumMember(Value = "TRAF")]
    [IsoId("_xr2PJ_r4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is the result of a demerger or division.")]
    Demerger,

    /// <summary>
    /// Transfer is a gift.
    /// Encoded/decoded by serializers as &quot;TRAG&quot;.
    /// </summary>
    [EnumMember(Value = "TRAG")]
    [IsoId("_7PtyEfr4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is a gift.")]
    Gift,

    /// <summary>
    /// Transfer is a heritage.
    /// Encoded/decoded by serializers as &quot;TRAI&quot;.
    /// </summary>
    [EnumMember(Value = "TRAI")]
    [IsoId("_-BogF_r4EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is a heritage.")]
    Heritage,

    /// <summary>
    /// Transfer is between own accounts.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_B9U5l_r5EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is between own accounts.")]
    BetweenOwnAccounts,

    /// <summary>
    /// Transfer is a trade.
    /// Encoded/decoded by serializers as &quot;TRAT&quot;.
    /// </summary>
    [EnumMember(Value = "TRAT")]
    [IsoId("_GEpUR_r5EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is a trade.")]
    Trade,

    /// <summary>
    /// Transfer is an undivided possession.
    /// Encoded/decoded by serializers as &quot;TRAU&quot;.
    /// </summary>
    [EnumMember(Value = "TRAU")]
    [IsoId("_Jncsp_r5EeCu2Z1WwxJVWA")]
    [Description(@"Transfer is an undivided possession.")]
    UndividedPossession,

    /// <summary>
    /// Transfer to pledged account (in certain circumstances distributors have to freeze and transfer total or partial holding to separate omnibus account e.g. investigation required by fiscal authority or police).
    /// Encoded/decoded by serializers as &quot;TPLD&quot;.
    /// </summary>
    [EnumMember(Value = "TPLD")]
    [IsoId("_mv3UoP_YEeCq5NtzDTui4w")]
    [Description(
        @"Transfer to pledged account (in certain circumstances distributors have to freeze and transfer total or partial holding to separate omnibus account e.g. investigation required by fiscal authority or police)."
    )]
    PledgedAccountTransfer,

    /// <summary>
    /// Transfer between different beneficiaries with taxation to be applied (accounts with different owner).
    /// Encoded/decoded by serializers as &quot;TRPE&quot;.
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_xSUmwP_YEeCq5NtzDTui4w")]
    [Description(
        @"Transfer between different beneficiaries with taxation to be applied (accounts with different owner)."
    )]
    TransferBetweenDifferentBeneficiaries,

    /// <summary>
    /// Transfer instruction executed within TDT framework (TDT framework is the operation model promoted by the Italian Banking Association for transfer and most of transfers, but not all, will be executed in accordance with that process).
    /// Encoded/decoded by serializers as &quot;TTDT&quot;.
    /// </summary>
    [EnumMember(Value = "TTDT")]
    [IsoId("_4jZnsP_YEeCq5NtzDTui4w")]
    [Description(
        @"Transfer instruction executed within TDT framework (TDT framework is the operation model promoted by the Italian Banking Association for transfer and most of transfers, but not all, will be executed in accordance with that process)."
    )]
    TDTFrameworkTransfer,
}
