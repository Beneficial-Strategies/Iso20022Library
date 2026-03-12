// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide confirmation details of one or more reservations set by the member (or on behalf of the member) and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(ReservationOrError6Choice.BusinessReport))]
    [KnownType(typeof(ReservationOrError6Choice.OperationalError))]
    [JsonDerivedType(typeof(ReservationOrError6Choice.BusinessReport),nameof(ReservationOrError6Choice.BusinessReport))]
    [JsonDerivedType(typeof(ReservationOrError6Choice.OperationalError),nameof(ReservationOrError6Choice.OperationalError))]
    [IsoId("_TanVMZliEeeE1Ya-LgRsuQ")]
    [DisplayName("Reservation Or Error 6 Choice")]
    public abstract partial record ReservationOrError6Choice_
    {
    }
}
