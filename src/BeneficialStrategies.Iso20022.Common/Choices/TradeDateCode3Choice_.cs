// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the trade date code.
    /// </summary>
    [KnownType(typeof(TradeDateCode3Choice.Code))]
    [KnownType(typeof(TradeDateCode3Choice.Proprietary))]
    [JsonDerivedType(typeof(TradeDateCode3Choice.Code), nameof(TradeDateCode3Choice.Code))]
    [JsonDerivedType(
        typeof(TradeDateCode3Choice.Proprietary),
        nameof(TradeDateCode3Choice.Proprietary)
    )]
    [IsoId("_HSmeHTqLEeWVrPy0StzzSg")]
    [DisplayName("Trade Date Code 3 Choice")]
    public abstract record TradeDateCode3Choice_ { }
}
