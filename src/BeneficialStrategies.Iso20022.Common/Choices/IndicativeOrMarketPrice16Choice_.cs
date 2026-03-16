// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicative Or Market Price16Choice.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice16Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice16Choice.MarketPrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice16Choice.IndicativePrice),nameof(IndicativeOrMarketPrice16Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice16Choice.MarketPrice),nameof(IndicativeOrMarketPrice16Choice.MarketPrice))]
    [IsoId("_kv7zlZt3Ee-wQIOX0djF2w")]
    [DisplayName("Indicative Or Market Price16Choice")]
    public abstract partial record IndicativeOrMarketPrice16Choice_
    {
    }
}
