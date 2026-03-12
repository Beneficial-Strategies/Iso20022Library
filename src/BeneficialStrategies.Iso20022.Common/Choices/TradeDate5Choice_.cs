// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade date.
    /// </summary>
    [KnownType(typeof(TradeDate5Choice.Date))]
    [KnownType(typeof(TradeDate5Choice.DateCode))]
    [JsonDerivedType(typeof(TradeDate5Choice.Date),nameof(TradeDate5Choice.Date))]
    [JsonDerivedType(typeof(TradeDate5Choice.DateCode),nameof(TradeDate5Choice.DateCode))]
    [IsoId("_GxkNgTqLEeWVrPy0StzzSg")]
    [DisplayName("Trade Date 5 Choice")]
    public abstract partial record TradeDate5Choice_
    {
    }
}
