// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates whether the trade was executed on or off-market.
    /// </summary>
    [KnownType(typeof(PlaceOfTradeIdentification2Choice.MarketIdentification))]
    [KnownType(typeof(PlaceOfTradeIdentification2Choice.OffMarket))]
    [JsonDerivedType(typeof(PlaceOfTradeIdentification2Choice.MarketIdentification),nameof(PlaceOfTradeIdentification2Choice.MarketIdentification))]
    [JsonDerivedType(typeof(PlaceOfTradeIdentification2Choice.OffMarket),nameof(PlaceOfTradeIdentification2Choice.OffMarket))]
    [IsoId("_TCfepNp-Ed-ak6NoX_4Aeg_2102299149")]
    [DisplayName("Place Of Trade Identification 2 Choice")]
    public abstract partial record PlaceOfTradeIdentification2Choice_
    {
    }
}
