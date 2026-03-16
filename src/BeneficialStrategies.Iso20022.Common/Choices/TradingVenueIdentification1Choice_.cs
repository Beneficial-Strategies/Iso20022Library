// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Trade venue related fields.
    /// </summary>
    [KnownType(typeof(TradingVenueIdentification1Choice.MarketIdentificationCode))]
    [KnownType(typeof(TradingVenueIdentification1Choice.NationalCompetentAuthority))]
    [KnownType(typeof(TradingVenueIdentification1Choice.Other))]
    [JsonDerivedType(
        typeof(TradingVenueIdentification1Choice.MarketIdentificationCode),
        nameof(TradingVenueIdentification1Choice.MarketIdentificationCode)
    )]
    [JsonDerivedType(
        typeof(TradingVenueIdentification1Choice.NationalCompetentAuthority),
        nameof(TradingVenueIdentification1Choice.NationalCompetentAuthority)
    )]
    [JsonDerivedType(
        typeof(TradingVenueIdentification1Choice.Other),
        nameof(TradingVenueIdentification1Choice.Other)
    )]
    [IsoId("_3sh9EhtGEeWhp-Wous5jzA")]
    [DisplayName("Trading Venue Identification 1 Choice")]
    public abstract record TradingVenueIdentification1Choice_ { }
}
