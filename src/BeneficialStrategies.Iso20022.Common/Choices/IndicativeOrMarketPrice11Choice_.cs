// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicative price or a market price.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice11Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice11Choice.MarketPrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice11Choice.IndicativePrice),nameof(IndicativeOrMarketPrice11Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice11Choice.MarketPrice),nameof(IndicativeOrMarketPrice11Choice.MarketPrice))]
    [IsoId("_ctkH_ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Indicative Or Market Price 11 Choice")]
    public abstract partial record IndicativeOrMarketPrice11Choice_
    {
    }
}
