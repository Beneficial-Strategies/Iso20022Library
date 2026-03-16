// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(ReservationStatus1Choice.Code))]
    [KnownType(typeof(ReservationStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReservationStatus1Choice.Code), nameof(ReservationStatus1Choice.Code))]
    [JsonDerivedType(
        typeof(ReservationStatus1Choice.Proprietary),
        nameof(ReservationStatus1Choice.Proprietary)
    )]
    [IsoId("_8JAUFaMgEeCJ6YNENx4h-w_22646004")]
    [DisplayName("Reservation Status 1 Choice")]
    public abstract record ReservationStatus1Choice_ { }
}
