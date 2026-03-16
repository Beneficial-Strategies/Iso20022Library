// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of cross being submitted to a market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bUOrWdp-Ed-ak6NoX_4Aeg_335335746")]
[Description(@"Type of cross being submitted to a market.")]
public enum CrossTradeExecutionCode
{
    /// <summary>
    /// Identifies a cross trade which is executed completely or not. Both sides are treated in the same manner.
    /// Encoded/decoded by serializers as &quot;EXEC&quot;.
    /// </summary>
    [EnumMember(Value = "EXEC")]
    [IsoId("_bUYcUNp-Ed-ak6NoX_4Aeg_335335747")]
    [Description(
        @"Identifies a cross trade which is executed completely or not. Both sides are treated in the same manner."
    )]
    Executed,

    /// <summary>
    /// Identifies a cross trade which is executed partially and the rest is cancelled. One side is fully executed, the other side is partially executed with the remainder being cancelled. This is equivalent to an Immediate or Cancel on the other side.
    /// Encoded/decoded by serializers as &quot;PACA&quot;.
    /// </summary>
    [EnumMember(Value = "PACA")]
    [IsoId("_bUYcUdp-Ed-ak6NoX_4Aeg_335335973")]
    [Description(
        @"Identifies a cross trade which is executed partially and the rest is cancelled. One side is fully executed, the other side is partially executed with the remainder being cancelled. This is equivalent to an Immediate or Cancel on the other side."
    )]
    PartialCancel,

    /// <summary>
    /// Identifies a cross trade which is partially executed with the unfilled portions remaining active. One side of the cross is fully executed but the unfilled portion remains active.
    /// Encoded/decoded by serializers as &quot;PAAC&quot;.
    /// </summary>
    [EnumMember(Value = "PAAC")]
    [IsoId("_bUYcUtp-Ed-ak6NoX_4Aeg_335335974")]
    [Description(
        @"Identifies a cross trade which is partially executed with the unfilled portions remaining active. One side of the cross is fully executed but the unfilled portion remains active."
    )]
    PartialActive,

    /// <summary>
    /// Identifies a cross trade which is executed with existing orders with the same price. In the case other orders exist with the same price, the quantity of the cross is executed against the existing orders and quotes, the remainder of the cross is executed against the other side of the cross. The two sides potentially have different quantities.
    /// Encoded/decoded by serializers as &quot;EXWI&quot;.
    /// </summary>
    [EnumMember(Value = "EXWI")]
    [IsoId("_bUYcU9p-Ed-ak6NoX_4Aeg_335335975")]
    [Description(
        @"Identifies a cross trade which is executed with existing orders with the same price. In the case other orders exist with the same price, the quantity of the cross is executed against the existing orders and quotes, the remainder of the cross is executed against the other side of the cross. The two sides potentially have different quantities."
    )]
    ExecutedWithExisting,
}
