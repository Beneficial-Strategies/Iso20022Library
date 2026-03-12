// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on the reservation or on a business error.
    /// </summary>
    [KnownType(typeof(ReservationOrError7Choice.Reservation))]
    [KnownType(typeof(ReservationOrError7Choice.BusinessError))]
    [JsonDerivedType(typeof(ReservationOrError7Choice.Reservation),nameof(ReservationOrError7Choice.Reservation))]
    [JsonDerivedType(typeof(ReservationOrError7Choice.BusinessError),nameof(ReservationOrError7Choice.BusinessError))]
    [IsoId("_T0LEt5liEeeE1Ya-LgRsuQ")]
    [DisplayName("Reservation Or Error 7 Choice")]
    public abstract partial record ReservationOrError7Choice_
    {
    }
}
