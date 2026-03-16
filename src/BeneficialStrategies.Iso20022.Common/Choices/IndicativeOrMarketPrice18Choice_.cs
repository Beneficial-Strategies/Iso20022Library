// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicative Or Market Price18Choice.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice18Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice18Choice.MarketPrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice18Choice.IndicativePrice),nameof(IndicativeOrMarketPrice18Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice18Choice.MarketPrice),nameof(IndicativeOrMarketPrice18Choice.MarketPrice))]
    [IsoId("_nLl9xZt3Ee-wQIOX0djF2w")]
    [DisplayName("Indicative Or Market Price18Choice")]
    public abstract partial record IndicativeOrMarketPrice18Choice_
    {
    }
}
