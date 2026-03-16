// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Current or default reservation set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(CurrentOrDefaultReservation3Choice.Current))]
    [KnownType(typeof(CurrentOrDefaultReservation3Choice.Default))]
    [JsonDerivedType(
        typeof(CurrentOrDefaultReservation3Choice.Current),
        nameof(CurrentOrDefaultReservation3Choice.Current)
    )]
    [JsonDerivedType(
        typeof(CurrentOrDefaultReservation3Choice.Default),
        nameof(CurrentOrDefaultReservation3Choice.Default)
    )]
    [IsoId("_g_uaQdcZEeqRFcf2R4bPBw")]
    [DisplayName("Current Or Default Reservation 3 Choice")]
    public abstract record CurrentOrDefaultReservation3Choice_ { }
}
