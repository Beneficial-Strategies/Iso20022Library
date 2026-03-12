// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Current or default reservation set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(CurrentOrDefaultReservation2Choice.Current))]
    [KnownType(typeof(CurrentOrDefaultReservation2Choice.Default))]
    [JsonDerivedType(typeof(CurrentOrDefaultReservation2Choice.Current),nameof(CurrentOrDefaultReservation2Choice.Current))]
    [JsonDerivedType(typeof(CurrentOrDefaultReservation2Choice.Default),nameof(CurrentOrDefaultReservation2Choice.Default))]
    [IsoId("_BndOfW4-EeiU9cctagi5ow")]
    [DisplayName("Current Or Default Reservation 2 Choice")]
    public abstract partial record CurrentOrDefaultReservation2Choice_
    {
    }
}
