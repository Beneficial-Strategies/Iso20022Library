// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of cross being submitted to a market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bUYcVNp-Ed-ak6NoX_4Aeg_2017715514")]
[Description(@"Type of cross being submitted to a market.")]
[DerivedFrom(typeof(CrossTypeCode))]
public enum CrossType1Code
{
    /// <summary>
    /// Cross All or None - Cross trade that is executed completely or not. Both sides are treated in the same manner. This is equivalent to Fill or Kill type behavior, where the cross order meets the crossing criteria  within the market and is executed or it is rejected.
    /// Encoded/decoded by serializers as &quot;ALON&quot;.
    /// </summary>
    [EnumMember(Value = "ALON")]
    [IsoId("_bUYcVdp-Ed-ak6NoX_4Aeg_726038962")]
    [Description(@"Cross All or None - Cross trade that is executed completely or not. Both sides are treated in the same manner. This is equivalent to Fill or Kill type behavior, where the cross order meets the crossing criteria  within the market and is executed or it is rejected.")]
    AllOrNone = CrossTypeCode.AllOrNone, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cross trade that is executed partially and the rest is canceled. One side is fully executed, the other side is partially executed with the remainder being canceled. This is equivalent to an Immediate or Cancel on the other side. Note: The CrossPrioritization field is used to indicate which side should fully execute in this scenario.
    /// Encoded/decoded by serializers as &quot;IMOC&quot;.
    /// </summary>
    [EnumMember(Value = "IMOC")]
    [IsoId("_bUYcVtp-Ed-ak6NoX_4Aeg_726039047")]
    [Description(@"Cross trade that is executed partially and the rest is canceled. One side is fully executed, the other side is partially executed with the remainder being canceled. This is equivalent to an Immediate or Cancel on the other side. Note: The CrossPrioritization field is used to indicate which side should fully execute in this scenario.")]
    ImmediateOrCancel = CrossTypeCode.ImmediateOrCancel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cross trade that is partially executed with the unfilled portions remaining active. One side of the cross is fully executed (the side that was prioritised) but the unfilled portion remains active.
    /// Encoded/decoded by serializers as &quot;ONSI&quot;.
    /// </summary>
    [EnumMember(Value = "ONSI")]
    [IsoId("_bUYcV9p-Ed-ak6NoX_4Aeg_726959053")]
    [Description(@"Cross trade that is partially executed with the unfilled portions remaining active. One side of the cross is fully executed (the side that was prioritised) but the unfilled portion remains active.")]
    OneSide = CrossTypeCode.OneSide, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cross trade is executed with existing orders with the same price. In the case other orders exist with the same price, the quantity of the Cross is executed against the existing orders and quotes, the remainder of the cross is executed against the other side of the cross.The two sides potentially have different quantities.
    /// Encoded/decoded by serializers as &quot;SAPR&quot;.
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_bUYcWNp-Ed-ak6NoX_4Aeg_726959096")]
    [Description(@"Cross trade is executed with existing orders with the same price. In the case other orders exist with the same price, the quantity of the Cross is executed against the existing orders and quotes, the remainder of the cross is executed against the other side of the cross.The two sides potentially have different quantities.")]
    SamePrice = CrossTypeCode.SamePrice, // same ordinal as derivation source for type conversions
    
}
