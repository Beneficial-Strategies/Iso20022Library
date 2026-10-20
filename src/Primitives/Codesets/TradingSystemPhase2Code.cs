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
[IsoId("_nqxSEYTREfClBYp_xDbOWg")]
[Description(@"Specifies the phase of the trading system.")]
[DerivedFrom(typeof(TradingSystemPhaseCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingSystemPhase2Code>))]
public enum TradingSystemPhase2Code
{
    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;COTR&quot;.
    /// </summary>
    [EnumMember(Value = "COTR")]
    [IsoId("_nro0w4TREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    ContinuousTrading = TradingSystemPhaseCode.ContinuousTrading,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;MACT&quot;.
    /// </summary>
    [EnumMember(Value = "MACT")]
    [IsoId("_nro0wYTREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    AtMarketCloseTrading = TradingSystemPhaseCode.AtMarketCloseTrading,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;ODAU&quot;.
    /// </summary>
    [EnumMember(Value = "ODAU")]
    [IsoId("_nro0xYTREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    OnDemandAuction = TradingSystemPhaseCode.OnDemandAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;OMST&quot;.
    /// </summary>
    [EnumMember(Value = "OMST")]
    [IsoId("_nrpb04TREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    OutOfMainSessionTrading = TradingSystemPhaseCode.OutOfMainSessionTrading,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;OTSP&quot;.
    /// </summary>
    [EnumMember(Value = "OTSP")]
    [IsoId("_nrpb0YTREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    Other = TradingSystemPhaseCode.Other,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;SCAU&quot;.
    /// </summary>
    [EnumMember(Value = "SCAU")]
    [IsoId("_nrpb1YTREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    ScheduledClosingAuction = TradingSystemPhaseCode.ScheduledClosingAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;SIAU&quot;.
    /// </summary>
    [EnumMember(Value = "SIAU")]
    [IsoId("_nrpb14TREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    ScheduledIntradayAuction = TradingSystemPhaseCode.ScheduledIntradayAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;SOAU&quot;.
    /// </summary>
    [EnumMember(Value = "SOAU")]
    [IsoId("_nrpb2YTREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    ScheduledOpeningAuction = TradingSystemPhaseCode.ScheduledOpeningAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;UAUC&quot;.
    /// </summary>
    [EnumMember(Value = "UAUC")]
    [IsoId("_nrpb44TREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    UnscheduledAuction = TradingSystemPhaseCode.UnscheduledAuction,

    /// <summary>
    /// Phase in which the trading system is in
    /// Encoded/decoded by serializers as &quot;UDUC&quot;.
    /// </summary>
    [EnumMember(Value = "UDUC")]
    [IsoId("_nrpb4YTREfClBYp_xDbOWg")]
    [Description(@"Phase in which the trading system is in")]
    UndefinedAuction = TradingSystemPhaseCode.UndefinedAuction,
}
