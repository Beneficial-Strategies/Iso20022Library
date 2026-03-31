// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicative Or Market Price17Choice.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice17Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice17Choice.MarketPrice))]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice17Choice.IndicativePrice),
        nameof(IndicativeOrMarketPrice17Choice.IndicativePrice)
    )]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice17Choice.MarketPrice),
        nameof(IndicativeOrMarketPrice17Choice.MarketPrice)
    )]
    [IsoId("_l6Xlopt3Ee-wQIOX0djF2w")]
    [DisplayName("Indicative Or Market Price17Choice")]
    public abstract record IndicativeOrMarketPrice17Choice_ { }
}
