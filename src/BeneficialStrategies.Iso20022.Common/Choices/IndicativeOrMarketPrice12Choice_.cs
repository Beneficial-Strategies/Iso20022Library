// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicative Or Market Price12Choice.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice12Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice12Choice.MarketPrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice12Choice.IndicativePrice),nameof(IndicativeOrMarketPrice12Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice12Choice.MarketPrice),nameof(IndicativeOrMarketPrice12Choice.MarketPrice))]
    [IsoId("_Cv1HMYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Indicative Or Market Price12Choice")]
    public abstract partial record IndicativeOrMarketPrice12Choice_
    {
    }
}
