// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [KnownType(typeof(TradingVenueType1Choice.OnVenue))]
    [KnownType(typeof(TradingVenueType1Choice.OffVenue))]
    [JsonDerivedType(typeof(TradingVenueType1Choice.OnVenue),nameof(TradingVenueType1Choice.OnVenue))]
    [JsonDerivedType(typeof(TradingVenueType1Choice.OffVenue),nameof(TradingVenueType1Choice.OffVenue))]
    [IsoId("_MXZ-8Hy7Eeu1BeE84IrnAQ")]
    [DisplayName("Trading Venue Type 1 Choice")]
    public abstract partial record TradingVenueType1Choice_
    {
    }
}
