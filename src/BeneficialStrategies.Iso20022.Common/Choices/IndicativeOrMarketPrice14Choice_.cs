// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicative Or Market Price14Choice.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice14Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice14Choice.MarketPrice))]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice14Choice.IndicativePrice),
        nameof(IndicativeOrMarketPrice14Choice.IndicativePrice)
    )]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice14Choice.MarketPrice),
        nameof(IndicativeOrMarketPrice14Choice.MarketPrice)
    )]
    [IsoId("_jtlhkYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Indicative Or Market Price14Choice")]
    public abstract record IndicativeOrMarketPrice14Choice_ { }
}
