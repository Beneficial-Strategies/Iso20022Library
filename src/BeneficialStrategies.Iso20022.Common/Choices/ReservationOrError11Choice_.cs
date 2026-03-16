// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reservation Or Error11Choice.
    /// </summary>
    [KnownType(typeof(ReservationOrError11Choice.BusinessReport))]
    [KnownType(typeof(ReservationOrError11Choice.OperationalError))]
    [JsonDerivedType(typeof(ReservationOrError11Choice.BusinessReport),nameof(ReservationOrError11Choice.BusinessReport))]
    [JsonDerivedType(typeof(ReservationOrError11Choice.OperationalError),nameof(ReservationOrError11Choice.OperationalError))]
    [IsoId("_6xdpkTEyEe6g-ffJsqGiSA")]
    [DisplayName("Reservation Or Error11Choice")]
    public abstract partial record ReservationOrError11Choice_
    {
    }
}
