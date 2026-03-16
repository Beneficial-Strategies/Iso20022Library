// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicative Or Market Price15Choice.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice15Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice15Choice.MarketPrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice15Choice.IndicativePrice),nameof(IndicativeOrMarketPrice15Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice15Choice.MarketPrice),nameof(IndicativeOrMarketPrice15Choice.MarketPrice))]
    [IsoId("_kV6xUZt3Ee-wQIOX0djF2w")]
    [DisplayName("Indicative Or Market Price15Choice")]
    public abstract partial record IndicativeOrMarketPrice15Choice_
    {
    }
}
