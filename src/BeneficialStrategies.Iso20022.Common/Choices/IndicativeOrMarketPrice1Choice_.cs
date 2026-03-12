// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicative price or a market price.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice1Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice1Choice.MarketPrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice1Choice.IndicativePrice),nameof(IndicativeOrMarketPrice1Choice.IndicativePrice))]
    [JsonDerivedType(typeof(IndicativeOrMarketPrice1Choice.MarketPrice),nameof(IndicativeOrMarketPrice1Choice.MarketPrice))]
    [IsoId("_UKwuQtp-Ed-ak6NoX_4Aeg_772413166")]
    [DisplayName("Indicative Or Market Price 1 Choice")]
    public abstract partial record IndicativeOrMarketPrice1Choice_
    {
    }
}
