// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Dutch Auction Type Format2Choice.
    /// </summary>
    [KnownType(typeof(DutchAuctionTypeFormat2Choice.Code))]
    [KnownType(typeof(DutchAuctionTypeFormat2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(DutchAuctionTypeFormat2Choice.Code),
        nameof(DutchAuctionTypeFormat2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(DutchAuctionTypeFormat2Choice.Proprietary),
        nameof(DutchAuctionTypeFormat2Choice.Proprietary)
    )]
    [IsoId("_t5KOQaAUEe-BUYcGJFWBWA")]
    [DisplayName("Dutch Auction Type Format2Choice")]
    public abstract record DutchAuctionTypeFormat2Choice_ { }
}
