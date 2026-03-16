// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade date.
    /// </summary>
    [KnownType(typeof(TradeDate6Choice.Date))]
    [KnownType(typeof(TradeDate6Choice.DateCode))]
    [JsonDerivedType(typeof(TradeDate6Choice.Date), nameof(TradeDate6Choice.Date))]
    [JsonDerivedType(typeof(TradeDate6Choice.DateCode), nameof(TradeDate6Choice.DateCode))]
    [IsoId("_5TGUWZNLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Date 6 Choice")]
    public abstract record TradeDate6Choice_ { }
}
