// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on the reservation or on a business error.
    /// </summary>
    [KnownType(typeof(ReservationOrError9Choice.Reservation))]
    [KnownType(typeof(ReservationOrError9Choice.BusinessError))]
    [JsonDerivedType(typeof(ReservationOrError9Choice.Reservation),nameof(ReservationOrError9Choice.Reservation))]
    [JsonDerivedType(typeof(ReservationOrError9Choice.BusinessError),nameof(ReservationOrError9Choice.BusinessError))]
    [IsoId("_RN8LwXhdEeidzqjNEfehPg")]
    [DisplayName("Reservation Or Error 9 Choice")]
    public abstract partial record ReservationOrError9Choice_
    {
    }
}
