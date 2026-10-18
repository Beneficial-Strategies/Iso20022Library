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
[IsoId("_jwxIkGevEfCqqP8BnNaHnA")]
[Description(@"Specifies the type of the trading system.")]
[DerivedFrom(typeof(TradingSystemTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingSystemType1Code>))]
public enum TradingSystemType1Code
{
    /// <summary>
    /// Central limit order book.
    /// Encoded/decoded by serializers as &quot;CLOB&quot;.
    /// </summary>
    [EnumMember(Value = "CLOB")]
    [IsoId("_pDrzsWevEfCqqP8BnNaHnA")]
    [Description(@"Central limit order book.")]
    CentralLimitOrderBook = TradingSystemTypeCode.CentralLimitOrderBook,

    /// <summary>
    /// Hybrid system
    /// Encoded/decoded by serializers as &quot;HYBR&quot;.
    /// </summary>
    [EnumMember(Value = "HYBR")]
    [IsoId("_pHn4gWevEfCqqP8BnNaHnA")]
    [Description(@"Hybrid system")]
    HybridSystem = TradingSystemTypeCode.HybridSystem,

    /// <summary>
    /// Other trading system
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_pK09gWevEfCqqP8BnNaHnA")]
    [Description(@"Other trading system")]
    Other = TradingSystemTypeCode.Other,

    /// <summary>
    /// Periodic auction
    /// Encoded/decoded by serializers as &quot;PATS&quot;.
    /// </summary>
    [EnumMember(Value = "PATS")]
    [IsoId("_pN9KAWevEfCqqP8BnNaHnA")]
    [Description(@"Periodic auction")]
    PeriodicAuction = TradingSystemTypeCode.PeriodicAuction,

    /// <summary>
    /// Quote driven market
    /// Encoded/decoded by serializers as &quot;QDTS&quot;.
    /// </summary>
    [EnumMember(Value = "QDTS")]
    [IsoId("_pQoqkWevEfCqqP8BnNaHnA")]
    [Description(@"Quote driven market")]
    QuoteDrivenMarket = TradingSystemTypeCode.QuoteDrivenMarket,

    /// <summary>
    /// Request for quotes
    /// Encoded/decoded by serializers as &quot;RFQT&quot;.
    /// </summary>
    [EnumMember(Value = "RFQT")]
    [IsoId("_pXXksWevEfCqqP8BnNaHnA")]
    [Description(@"Request for quotes")]
    RequestForQuotes = TradingSystemTypeCode.RequestForQuotes,

    /// <summary>
    /// Voice trading system
    /// Encoded/decoded by serializers as &quot;VOIC&quot;.
    /// </summary>
    [EnumMember(Value = "VOIC")]
    [IsoId("_oXwFUWewEfCqqP8BnNaHnA")]
    [Description(@"Voice trading system")]
    VoiceTradingSystem = TradingSystemTypeCode.VoiceTradingSystem,
}
