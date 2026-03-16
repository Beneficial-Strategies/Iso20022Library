// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(ReservationType2Choice.Code))]
    [KnownType(typeof(ReservationType2Choice.Proprietary))]
    [JsonDerivedType(typeof(ReservationType2Choice.Code), nameof(ReservationType2Choice.Code))]
    [JsonDerivedType(
        typeof(ReservationType2Choice.Proprietary),
        nameof(ReservationType2Choice.Proprietary)
    )]
    [IsoId("_5v7SsRUNEeusI4XK3oQSyg")]
    [DisplayName("Reservation Type 2 Choice")]
    public abstract record ReservationType2Choice_ { }
}
