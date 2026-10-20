// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code indicating information about order restriction, such as the trading phase when the order becomes active.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2Ue88GvqEe2Re-GccwOX8g")]
[Description(
    @"Code indicating information about order restriction, such as the trading phase when the order becomes active."
)]
[DerivedFrom(typeof(OrderRestrictionTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OrderRestrictionType1Code>))]
public enum OrderRestrictionType1Code
{
    /// <summary>
    /// Order qualifying for the closing price crossing session.
    /// Encoded/decoded by serializers as &quot;SESR&quot;.
    /// </summary>
    [EnumMember(Value = "SESR")]
    [IsoId("_3K1WIWvqEe2Re-GccwOX8g")]
    [Description(@"Order qualifying for the closing price crossing session. ")]
    GoodForClosingPriceCrossingSession = OrderRestrictionTypeCode.GoodForClosingPriceCrossingSession, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order being only active and can only be executed at auction phases.
    /// Encoded/decoded by serializers as &quot;VFAR&quot;.
    /// </summary>
    [EnumMember(Value = "VFAR")]
    [IsoId("_3QAKAWvqEe2Re-GccwOX8g")]
    [Description(
        @"Order being only active and can only be executed at auction phases (which can be pre-defined by the member or, participant of the trading venue who submitted the order, e.g. opening and/closing auctions and/or intraday auction)."
    )]
    ValidForAuction = OrderRestrictionTypeCode.ValidForAuction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order being only active during continuous trading.
    /// Encoded/decoded by serializers as &quot;VFCR&quot;.
    /// </summary>
    [EnumMember(Value = "VFCR")]
    [IsoId("_3VGFYWvqEe2Re-GccwOX8g")]
    [Description(@"Order being only active during continuous trading. ")]
    ValidForContinuousTradingOnly = OrderRestrictionTypeCode.ValidForContinuousTradingOnly, // same ordinal as derivation source for type conversions
}
