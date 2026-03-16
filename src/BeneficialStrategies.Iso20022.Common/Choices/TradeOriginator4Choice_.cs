// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trading capacity of the party.
    /// </summary>
    [KnownType(typeof(TradeOriginator4Choice.Code))]
    [KnownType(typeof(TradeOriginator4Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeOriginator4Choice.Code), nameof(TradeOriginator4Choice.Code))]
    [JsonDerivedType(
        typeof(TradeOriginator4Choice.Proprietary),
        nameof(TradeOriginator4Choice.Proprietary)
    )]
    [IsoId("_5mtMh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Originator 4 Choice")]
    public abstract record TradeOriginator4Choice_ { }
}
