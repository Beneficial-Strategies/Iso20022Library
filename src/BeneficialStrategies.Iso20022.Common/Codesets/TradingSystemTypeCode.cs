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
[IsoId("_UOF_0GFXEfC91ZUW7iS7ww")]
[Description(@"Specifies the type of the trading system.")]
[Derivations(typeof(TradingSystemType1Code), typeof(TradingSystemType2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TradingSystemTypeCode>))]
public enum TradingSystemTypeCode
{
    /// <summary>
    /// Central limit order book.
    /// Encoded/decoded by serializers as &quot;CLOB&quot;.
    /// </summary>
    [EnumMember(Value = "CLOB")]
    [IsoId("_ikTQYGFXEfC91ZUW7iS7ww")]
    [Description(@"Central limit order book.")]
    CentralLimitOrderBook,

    /// <summary>
    /// Hybrid system
    /// Encoded/decoded by serializers as &quot;HYBR&quot;.
    /// </summary>
    [EnumMember(Value = "HYBR")]
    [IsoId("_DCpLAGFYEfC91ZUW7iS7ww")]
    [Description(@"Hybrid system")]
    HybridSystem,

    /// <summary>
    /// Other trading system
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_NpCh8GFYEfC91ZUW7iS7ww")]
    [Description(@"Other trading system")]
    Other,

    /// <summary>
    /// Periodic auction
    /// Encoded/decoded by serializers as &quot;PATS&quot;.
    /// </summary>
    [EnumMember(Value = "PATS")]
    [IsoId("_81hhcGFXEfC91ZUW7iS7ww")]
    [Description(@"Periodic auction")]
    PeriodicAuction,

    /// <summary>
    /// Quote driven market
    /// Encoded/decoded by serializers as &quot;QDTS&quot;.
    /// </summary>
    [EnumMember(Value = "QDTS")]
    [IsoId("_wYjqcGFXEfC91ZUW7iS7ww")]
    [Description(@"Quote driven market")]
    QuoteDrivenMarket,

    /// <summary>
    /// Request for quotes
    /// Encoded/decoded by serializers as &quot;RFQT&quot;.
    /// </summary>
    [EnumMember(Value = "RFQT")]
    [IsoId("__cY2AGFXEfC91ZUW7iS7ww")]
    [Description(@"Request for quotes")]
    RequestForQuotes,

    /// <summary>
    /// Voice trading system
    /// Encoded/decoded by serializers as &quot;VOIC&quot;.
    /// </summary>
    [EnumMember(Value = "VOIC")]
    [IsoId("_j4SQYGewEfCqqP8BnNaHnA")]
    [Description(@"Voice trading system")]
    VoiceTradingSystem,
}
