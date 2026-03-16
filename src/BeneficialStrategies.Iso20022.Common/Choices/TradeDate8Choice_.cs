// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade date.
    /// </summary>
    [KnownType(typeof(TradeDate8Choice.Date))]
    [KnownType(typeof(TradeDate8Choice.DateCode))]
    [JsonDerivedType(typeof(TradeDate8Choice.Date), nameof(TradeDate8Choice.Date))]
    [JsonDerivedType(typeof(TradeDate8Choice.DateCode), nameof(TradeDate8Choice.DateCode))]
    [IsoId("_vej6AbPuEeelzbgsFa3sqQ")]
    [DisplayName("Trade Date 8 Choice")]
    public abstract record TradeDate8Choice_ { }
}
