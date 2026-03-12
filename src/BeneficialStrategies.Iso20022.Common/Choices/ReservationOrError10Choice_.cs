// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide confirmation details of one or more reservations set by the member (or on behalf of the member) and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(ReservationOrError10Choice.BusinessReport))]
    [KnownType(typeof(ReservationOrError10Choice.OperationalError))]
    [JsonDerivedType(typeof(ReservationOrError10Choice.BusinessReport),nameof(ReservationOrError10Choice.BusinessReport))]
    [JsonDerivedType(typeof(ReservationOrError10Choice.OperationalError),nameof(ReservationOrError10Choice.OperationalError))]
    [IsoId("_eGwpEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reservation Or Error 10 Choice")]
    public abstract partial record ReservationOrError10Choice_
    {
    }
}
