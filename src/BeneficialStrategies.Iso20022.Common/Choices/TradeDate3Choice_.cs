// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade date.
    /// </summary>
    [KnownType(typeof(TradeDate3Choice.Date))]
    [KnownType(typeof(TradeDate3Choice.DateCode))]
    [JsonDerivedType(typeof(TradeDate3Choice.Date), nameof(TradeDate3Choice.Date))]
    [JsonDerivedType(typeof(TradeDate3Choice.DateCode), nameof(TradeDate3Choice.DateCode))]
    [IsoId("_-axnlqMOEeCojJW5vEuTEQ_-1297910471")]
    [DisplayName("Trade Date 3 Choice")]
    public abstract record TradeDate3Choice_ { }
}
