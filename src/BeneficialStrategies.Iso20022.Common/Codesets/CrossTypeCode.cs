// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of cross being submitted to a market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bUhmQNp-Ed-ak6NoX_4Aeg_1989083397")]
[Description(@"Type of cross being submitted to a market.")]
[Derivations(typeof(CrossType1Code))]
public enum CrossTypeCode
{
    /// <summary>
    /// Cross All or None - Cross trade that is executed completely or not. Both sides are treated in the same manner. This is equivalent to Fill or Kill type behavior, where the cross order meets the crossing criteria  within the market and is executed or it is rejected.
    /// Encoded/decoded by serializers as &quot;ALON&quot;.
    /// </summary>
    [EnumMember(Value = "ALON")]
    [IsoId("_bUhmQdp-Ed-ak6NoX_4Aeg_2048190713")]
    [Description(
        @"Cross All or None - Cross trade that is executed completely or not. Both sides are treated in the same manner. This is equivalent to Fill or Kill type behavior, where the cross order meets the crossing criteria  within the market and is executed or it is rejected."
    )]
    AllOrNone,

    /// <summary>
    /// Cross trade that is executed partially and the rest is canceled. One side is fully executed, the other side is partially executed with the remainder being canceled. This is equivalent to an Immediate or Cancel on the other side. Note: The CrossPrioritization field is used to indicate which side should fully execute in this scenario.
    /// Encoded/decoded by serializers as &quot;IMOC&quot;.
    /// </summary>
    [EnumMember(Value = "IMOC")]
    [IsoId("_bUhmQtp-Ed-ak6NoX_4Aeg_-1892145002")]
    [Description(
        @"Cross trade that is executed partially and the rest is canceled. One side is fully executed, the other side is partially executed with the remainder being canceled. This is equivalent to an Immediate or Cancel on the other side. Note: The CrossPrioritization field is used to indicate which side should fully execute in this scenario."
    )]
    ImmediateOrCancel,

    /// <summary>
    /// Cross trade that is partially executed with the unfilled portions remaining active. One side of the cross is fully executed (the side that was prioritised) but the unfilled portion remains active.
    /// Encoded/decoded by serializers as &quot;ONSI&quot;.
    /// </summary>
    [EnumMember(Value = "ONSI")]
    [IsoId("_bUhmQ9p-Ed-ak6NoX_4Aeg_-1446082343")]
    [Description(
        @"Cross trade that is partially executed with the unfilled portions remaining active. One side of the cross is fully executed (the side that was prioritised) but the unfilled portion remains active."
    )]
    OneSide,

    /// <summary>
    /// Cross trade is executed with existing orders with the same price. In the case other orders exist with the same price, the quantity of the Cross is executed against the existing orders and quotes, the remainder of the cross is executed against the other side of the cross.The two sides potentially have different quantities.
    /// Encoded/decoded by serializers as &quot;SAPR&quot;.
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_bUhmRNp-Ed-ak6NoX_4Aeg_-1379589823")]
    [Description(
        @"Cross trade is executed with existing orders with the same price. In the case other orders exist with the same price, the quantity of the Cross is executed against the existing orders and quotes, the remainder of the cross is executed against the other side of the cross.The two sides potentially have different quantities."
    )]
    SamePrice,
}
