// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Dutch Auction Type Format1Choice.
    /// </summary>
    [KnownType(typeof(DutchAuctionTypeFormat1Choice.Code))]
    [KnownType(typeof(DutchAuctionTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(DutchAuctionTypeFormat1Choice.Code),nameof(DutchAuctionTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(DutchAuctionTypeFormat1Choice.Proprietary),nameof(DutchAuctionTypeFormat1Choice.Proprietary))]
    [IsoId("_6SGIMIAHEe-DNerJibcigw")]
    [DisplayName("Dutch Auction Type Format1Choice")]
    public abstract partial record DutchAuctionTypeFormat1Choice_
    {
    }
}
