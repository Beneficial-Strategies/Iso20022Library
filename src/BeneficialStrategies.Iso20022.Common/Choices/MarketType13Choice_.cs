// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the market type.
    /// </summary>
    [KnownType(typeof(MarketType13Choice.Code))]
    [KnownType(typeof(MarketType13Choice.Proprietary))]
    [JsonDerivedType(typeof(MarketType13Choice.Code), nameof(MarketType13Choice.Code))]
    [JsonDerivedType(
        typeof(MarketType13Choice.Proprietary),
        nameof(MarketType13Choice.Proprietary)
    )]
    [IsoId("_Yczl4EeIEeSzluxs8tdrVw")]
    [DisplayName("Market Type 13 Choice")]
    public abstract record MarketType13Choice_ { }
}
