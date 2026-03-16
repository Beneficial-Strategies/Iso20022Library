// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicative Or Market Price13Choice.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice13Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice13Choice.MarketPrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice13Choice.IndicativePrice),nameof(IndicativeOrMarketPrice13Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice13Choice.MarketPrice),nameof(IndicativeOrMarketPrice13Choice.MarketPrice))]
    [IsoId("_DW68WYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Indicative Or Market Price13Choice")]
    public abstract partial record IndicativeOrMarketPrice13Choice_
    {
    }
}
