// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies an airport by its code or by its name and the town where it is located.
    /// </summary>
    [KnownType(typeof(AirportName1Choice.AirportCode))]
    [KnownType(typeof(AirportName1Choice.OtherAirportDescription))]
    [JsonDerivedType(
        typeof(AirportName1Choice.AirportCode),
        nameof(AirportName1Choice.AirportCode)
    )]
    [JsonDerivedType(
        typeof(AirportName1Choice.OtherAirportDescription),
        nameof(AirportName1Choice.OtherAirportDescription)
    )]
    [IsoId("_SsSlI9p-Ed-ak6NoX_4Aeg_-992731401")]
    [DisplayName("Airport Name 1 Choice")]
    public abstract record AirportName1Choice_ { }
}
