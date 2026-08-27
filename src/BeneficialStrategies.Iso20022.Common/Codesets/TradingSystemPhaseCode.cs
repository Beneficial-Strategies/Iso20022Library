// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the phase of the trading system
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U7ifMGFYEfC91ZUW7iS7ww")]
[Description(@"Specifies the phase of the trading system")]
[Derivations(typeof(TradingSystemPhase1Code), typeof(TradingSystemPhase2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingSystemPhaseCode>))]
public enum TradingSystemPhaseCode
{
    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;COTR&quot;.
    /// </summary>
    [EnumMember(Value = "COTR")]
    [IsoId("_Ro070GFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    ContinuousTrading,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;MACT&quot;.
    /// </summary>
    [EnumMember(Value = "MACT")]
    [IsoId("_TXNwQGFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    AtMarketCloseTrading,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;ODAU&quot;.
    /// </summary>
    [EnumMember(Value = "ODAU")]
    [IsoId("_HwRiUGFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    OnDemandAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;OMST&quot;.
    /// </summary>
    [EnumMember(Value = "OMST")]
    [IsoId("_WHgtoGFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    OutOfMainSessionTrading,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;OTSP&quot;.
    /// </summary>
    [EnumMember(Value = "OTSP")]
    [IsoId("_kU-48GFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    Other,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;SCAU&quot;.
    /// </summary>
    [EnumMember(Value = "SCAU")]
    [IsoId("_-cmXgGFYEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    ScheduledClosingAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;SIAU&quot;.
    /// </summary>
    [EnumMember(Value = "SIAU")]
    [IsoId("_BjyK4GFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    ScheduledIntradayAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;SOAU&quot;.
    /// </summary>
    [EnumMember(Value = "SOAU")]
    [IsoId("_6e5y4GFYEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    ScheduledOpeningAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;TROE&quot;.
    /// </summary>
    [EnumMember(Value = "TROE")]
    [IsoId("_Y6UzgGFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    TradeReportingOnExchange,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;TROF&quot;.
    /// </summary>
    [EnumMember(Value = "TROF")]
    [IsoId("_dBCxQGFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    TradeReportingOffExchange,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;TRSI&quot;.
    /// </summary>
    [EnumMember(Value = "TRSI")]
    [IsoId("_gP7vIGFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    TradeReportingSystematicInternaliser,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;UAUC&quot;.
    /// </summary>
    [EnumMember(Value = "UAUC")]
    [IsoId("_GBlL4GFZEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    UnscheduledAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;UDUC&quot;.
    /// </summary>
    [EnumMember(Value = "UDUC")]
    [IsoId("_p0iuYGFYEfC91ZUW7iS7ww")]
    [Description(@"Phase in which the trading system is in")]
    UndefinedAuction,
}
