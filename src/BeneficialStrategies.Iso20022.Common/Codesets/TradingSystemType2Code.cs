// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of the trading system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pduoQi0EfGcdem6NRoegA")]
[Description(@"Specifies the type of the trading system.")]
[DerivedFrom(typeof(TradingSystemTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingSystemType2Code>))]
public enum TradingSystemType2Code
{
    /// <summary>
    /// Central limit order book.
    /// Encoded/decoded by serializers as &quot;CLOB&quot;.
    /// </summary>
    [EnumMember(Value = "CLOB")]
    [IsoId("_1q1noQi0EfGcdem6NRoegA")]
    [Description(@"Central limit order book.")]
    CentralLimitOrderBook = TradingSystemTypeCode.CentralLimitOrderBook,

    /// <summary>
    /// Hybrid system
    /// Encoded/decoded by serializers as &quot;HYBR&quot;.
    /// </summary>
    [EnumMember(Value = "HYBR")]
    [IsoId("_1q1nowi0EfGcdem6NRoegA")]
    [Description(@"Hybrid system")]
    HybridSystem = TradingSystemTypeCode.HybridSystem,

    /// <summary>
    /// Other trading system
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_1q1npQi0EfGcdem6NRoegA")]
    [Description(@"Other trading system")]
    Other = TradingSystemTypeCode.Other,

    /// <summary>
    /// Periodic auction
    /// Encoded/decoded by serializers as &quot;PATS&quot;.
    /// </summary>
    [EnumMember(Value = "PATS")]
    [IsoId("_1q1npwi0EfGcdem6NRoegA")]
    [Description(@"Periodic auction")]
    PeriodicAuction = TradingSystemTypeCode.PeriodicAuction,

    /// <summary>
    /// Quote driven market
    /// Encoded/decoded by serializers as &quot;QDTS&quot;.
    /// </summary>
    [EnumMember(Value = "QDTS")]
    [IsoId("_1q1nqQi0EfGcdem6NRoegA")]
    [Description(@"Quote driven market")]
    QuoteDrivenMarket = TradingSystemTypeCode.QuoteDrivenMarket,

    /// <summary>
    /// Request for quotes
    /// Encoded/decoded by serializers as &quot;RFQT&quot;.
    /// </summary>
    [EnumMember(Value = "RFQT")]
    [IsoId("_1q1nqwi0EfGcdem6NRoegA")]
    [Description(@"Request for quotes")]
    RequestForQuotes = TradingSystemTypeCode.RequestForQuotes,
}
