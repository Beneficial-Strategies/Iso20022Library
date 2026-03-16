// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Place Of Trade Identification4Choice.
    /// </summary>
    [KnownType(typeof(PlaceOfTradeIdentification4Choice.Country))]
    [KnownType(typeof(PlaceOfTradeIdentification4Choice.Exchange))]
    [KnownType(typeof(PlaceOfTradeIdentification4Choice.OverTheCounter))]
    [KnownType(typeof(PlaceOfTradeIdentification4Choice.Party))]
    [JsonDerivedType(typeof(PlaceOfTradeIdentification4Choice.Country),nameof(PlaceOfTradeIdentification4Choice.Country))]
    [JsonDerivedType(typeof(PlaceOfTradeIdentification4Choice.Exchange),nameof(PlaceOfTradeIdentification4Choice.Exchange))]
    [JsonDerivedType(typeof(PlaceOfTradeIdentification4Choice.OverTheCounter),nameof(PlaceOfTradeIdentification4Choice.OverTheCounter))]
    [JsonDerivedType(typeof(PlaceOfTradeIdentification4Choice.Party),nameof(PlaceOfTradeIdentification4Choice.Party))]
    [IsoId("_w2GyoRwIEe6fEumgV5aG_A")]
    [DisplayName("Place Of Trade Identification4Choice")]
    public abstract partial record PlaceOfTradeIdentification4Choice_
    {
    }
}
