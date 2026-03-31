// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide confirmation details of one or more reservations set by the member (or on behalf of the member) and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(ReservationOrError8Choice.BusinessReport))]
    [KnownType(typeof(ReservationOrError8Choice.OperationalError))]
    [JsonDerivedType(
        typeof(ReservationOrError8Choice.BusinessReport),
        nameof(ReservationOrError8Choice.BusinessReport)
    )]
    [JsonDerivedType(
        typeof(ReservationOrError8Choice.OperationalError),
        nameof(ReservationOrError8Choice.OperationalError)
    )]
    [IsoId("_DMyNh24-EeiU9cctagi5ow")]
    [DisplayName("Reservation Or Error 8 Choice")]
    public abstract record ReservationOrError8Choice_ { }
}
