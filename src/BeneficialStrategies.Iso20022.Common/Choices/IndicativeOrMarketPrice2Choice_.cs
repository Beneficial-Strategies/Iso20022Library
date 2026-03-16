// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an indicative price or a market price.
    /// </summary>
    [KnownType(typeof(IndicativeOrMarketPrice2Choice.IndicativePrice))]
    [KnownType(typeof(IndicativeOrMarketPrice2Choice.MarketPrice))]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice2Choice.IndicativePrice),
        nameof(IndicativeOrMarketPrice2Choice.IndicativePrice)
    )]
    [JsonDerivedType(
        typeof(IndicativeOrMarketPrice2Choice.MarketPrice),
        nameof(IndicativeOrMarketPrice2Choice.MarketPrice)
    )]
    [IsoId("_UKwuRdp-Ed-ak6NoX_4Aeg_-1375580741")]
    [DisplayName("Indicative Or Market Price 2 Choice")]
    public abstract record IndicativeOrMarketPrice2Choice_ { }
}
