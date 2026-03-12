// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicative price or a market price.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice9Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice9Choice.MarketPrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice9Choice.IndicativePrice),nameof(IndicativeOrMarketPrice9Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice9Choice.MarketPrice),nameof(IndicativeOrMarketPrice9Choice.MarketPrice))]
    [IsoId("_chez05KQEeWHWpTQn1FFVg")]
    [DisplayName("Indicative Or Market Price 9 Choice")]
    public abstract partial record IndicativeOrMarketPrice9Choice_
    {
    }
}
