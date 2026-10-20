// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the phase of the trading system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_07Ma8Ge0EfCLZIbB93J8xw")]
[Description(@"Specifies the phase of the trading system.")]
[DerivedFrom(typeof(TradingSystemPhaseCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingSystemPhase1Code>))]
public enum TradingSystemPhase1Code
{
    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;COTR&quot;.
    /// </summary>
    [EnumMember(Value = "COTR")]
    [IsoId("_21MCcWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    ContinuousTrading = TradingSystemPhaseCode.ContinuousTrading,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;MACT&quot;.
    /// </summary>
    [EnumMember(Value = "MACT")]
    [IsoId("_2yFEEWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    AtMarketCloseTrading = TradingSystemPhaseCode.AtMarketCloseTrading,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;ODAU&quot;.
    /// </summary>
    [EnumMember(Value = "ODAU")]
    [IsoId("_235YMWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    OnDemandAuction = TradingSystemPhaseCode.OnDemandAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;OMST&quot;.
    /// </summary>
    [EnumMember(Value = "OMST")]
    [IsoId("_3AONwWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    OutOfMainSessionTrading = TradingSystemPhaseCode.OutOfMainSessionTrading,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;OTSP&quot;.
    /// </summary>
    [EnumMember(Value = "OTSP")]
    [IsoId("_26gnUWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    Other = TradingSystemPhaseCode.Other,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;SCAU&quot;.
    /// </summary>
    [EnumMember(Value = "SCAU")]
    [IsoId("_3C1c4We0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    ScheduledClosingAuction = TradingSystemPhaseCode.ScheduledClosingAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;SIAU&quot;.
    /// </summary>
    [EnumMember(Value = "SIAU")]
    [IsoId("_3FtxwWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    ScheduledIntradayAuction = TradingSystemPhaseCode.ScheduledIntradayAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;SOAU&quot;.
    /// </summary>
    [EnumMember(Value = "SOAU")]
    [IsoId("_3ImtsWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    ScheduledOpeningAuction = TradingSystemPhaseCode.ScheduledOpeningAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;TROE&quot;.
    /// </summary>
    [EnumMember(Value = "TROE")]
    [IsoId("_3T6l0We0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    TradeReportingOnExchange = TradingSystemPhaseCode.TradeReportingOnExchange,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;TROF&quot;.
    /// </summary>
    [EnumMember(Value = "TROF")]
    [IsoId("_3MM0QWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    TradeReportingOffExchange = TradingSystemPhaseCode.TradeReportingOffExchange,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;TRSI&quot;.
    /// </summary>
    [EnumMember(Value = "TRSI")]
    [IsoId("_3PvQcWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    TradeReportingSystematicInternaliser = TradingSystemPhaseCode.TradeReportingSystematicInternaliser,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;UAUC&quot;.
    /// </summary>
    [EnumMember(Value = "UAUC")]
    [IsoId("_3cONQWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    UnscheduledAuction = TradingSystemPhaseCode.UnscheduledAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;UDUC&quot;.
    /// </summary>
    [EnumMember(Value = "UDUC")]
    [IsoId("_3WpwwWe0EfCLZIbB93J8xw")]
    [Description(@"Phase in which the trading system is in")]
    UndefinedAuction = TradingSystemPhaseCode.UndefinedAuction,
}
