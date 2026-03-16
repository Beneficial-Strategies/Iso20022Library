// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
    /// </summary>
    [KnownType(typeof(PlaceOfTradeIdentification1Choice.Country))]
    [KnownType(typeof(PlaceOfTradeIdentification1Choice.Exchange))]
    [KnownType(typeof(PlaceOfTradeIdentification1Choice.Party))]
    [KnownType(typeof(PlaceOfTradeIdentification1Choice.OverTheCounter))]
    [JsonDerivedType(
        typeof(PlaceOfTradeIdentification1Choice.Country),
        nameof(PlaceOfTradeIdentification1Choice.Country)
    )]
    [JsonDerivedType(
        typeof(PlaceOfTradeIdentification1Choice.Exchange),
        nameof(PlaceOfTradeIdentification1Choice.Exchange)
    )]
    [JsonDerivedType(
        typeof(PlaceOfTradeIdentification1Choice.Party),
        nameof(PlaceOfTradeIdentification1Choice.Party)
    )]
    [JsonDerivedType(
        typeof(PlaceOfTradeIdentification1Choice.OverTheCounter),
        nameof(PlaceOfTradeIdentification1Choice.OverTheCounter)
    )]
    [IsoId("_TCWUu9p-Ed-ak6NoX_4Aeg_-2100921873")]
    [DisplayName("Place Of Trade Identification 1 Choice")]
    public abstract record PlaceOfTradeIdentification1Choice_ { }
}
