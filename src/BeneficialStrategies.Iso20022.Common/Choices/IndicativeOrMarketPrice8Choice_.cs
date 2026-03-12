// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicative price or a market price.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice8Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice8Choice.MarketPrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice8Choice.IndicativePrice),nameof(IndicativeOrMarketPrice8Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice8Choice.MarketPrice),nameof(IndicativeOrMarketPrice8Choice.MarketPrice))]
    [IsoId("_PoGCkUGMEeWqy4niLuXETA")]
    [DisplayName("Indicative Or Market Price 8 Choice")]
    public abstract partial record IndicativeOrMarketPrice8Choice_
    {
    }
}
