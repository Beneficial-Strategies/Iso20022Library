// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicative price or a market price.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice5Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice5Choice.MarketPrice))]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice5Choice.IndicativePrice),
        nameof(IndicativeOrMarketPrice5Choice.IndicativePrice)
    )]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice5Choice.MarketPrice),
        nameof(IndicativeOrMarketPrice5Choice.MarketPrice)
    )]
    [IsoId("_oc_1ceEJEd-udr336SN7mQ")]
    [DisplayName("Indicative Or Market Price 5 Choice")]
    public abstract record IndicativeOrMarketPrice5Choice_ { }
}
