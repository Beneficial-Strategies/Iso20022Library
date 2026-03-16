// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicative price or a market price.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice7Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice7Choice.MarketPrice))]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice7Choice.IndicativePrice),
        nameof(IndicativeOrMarketPrice7Choice.IndicativePrice)
    )]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice7Choice.MarketPrice),
        nameof(IndicativeOrMarketPrice7Choice.MarketPrice)
    )]
    [IsoId("_dJ4jPUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Indicative Or Market Price 7 Choice")]
    public abstract record IndicativeOrMarketPrice7Choice_ { }
}
