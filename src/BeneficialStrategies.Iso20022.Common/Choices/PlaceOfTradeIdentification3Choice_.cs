// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
    /// </summary>
    [KnownType(typeof(PlaceOfTradeIdentification3Choice.Country))]
    [KnownType(typeof(PlaceOfTradeIdentification3Choice.Exchange))]
    [KnownType(typeof(PlaceOfTradeIdentification3Choice.OverTheCounter))]
    [JsonDerivedType(
        typeof(PlaceOfTradeIdentification3Choice.Country),
        nameof(PlaceOfTradeIdentification3Choice.Country)
    )]
    [JsonDerivedType(
        typeof(PlaceOfTradeIdentification3Choice.Exchange),
        nameof(PlaceOfTradeIdentification3Choice.Exchange)
    )]
    [JsonDerivedType(
        typeof(PlaceOfTradeIdentification3Choice.OverTheCounter),
        nameof(PlaceOfTradeIdentification3Choice.OverTheCounter)
    )]
    [IsoId("_WNc-0tp-Ed-ak6NoX_4Aeg_-1162943357")]
    [DisplayName("Place Of Trade Identification 3 Choice")]
    public abstract record PlaceOfTradeIdentification3Choice_ { }
}
