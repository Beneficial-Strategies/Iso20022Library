// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type used for the order restrictions.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ipRQQGseEe25qph5Y8_eYQ")]
[Description(@"Specifies the type used for the order restrictions.")]
[Derivations(typeof(OrderRestrictionType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<OrderRestrictionTypeCode>))]
public enum OrderRestrictionTypeCode
{
    /// <summary>
    /// Order qualifying for the closing price crossing session.
    /// Encoded/decoded by serializers as &quot;SESR&quot;.
    /// </summary>
    [EnumMember(Value = "SESR")]
    [IsoId("_nzWvgGseEe25qph5Y8_eYQ")]
    [Description(@"Order qualifying for the closing price crossing session. ")]
    GoodForClosingPriceCrossingSession,

    /// <summary>
    /// Order being only active and can only be executed at auction phases.
    /// Encoded/decoded by serializers as &quot;VFAR&quot;.
    /// </summary>
    [EnumMember(Value = "VFAR")]
    [IsoId("_tFyScGseEe25qph5Y8_eYQ")]
    [Description(
        @"Order being only active and can only be executed at auction phases (which can be pre-defined by the member or, participant of the trading venue who submitted the order, e.g. opening and/closing auctions and/or intraday auction)."
    )]
    ValidForAuction,

    /// <summary>
    /// Order being only active during continuous trading.
    /// Encoded/decoded by serializers as &quot;VFCR&quot;.
    /// </summary>
    [EnumMember(Value = "VFCR")]
    [IsoId("_5s5j8GseEe25qph5Y8_eYQ")]
    [Description(@"Order being only active during continuous trading. ")]
    ValidForContinuousTradingOnly,
}
