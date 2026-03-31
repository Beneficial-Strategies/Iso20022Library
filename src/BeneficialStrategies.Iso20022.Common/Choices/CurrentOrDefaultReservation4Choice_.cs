// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Current Or Default Reservation4Choice.
    /// </summary>
    [KnownType(typeof(CurrentOrDefaultReservation4Choice.Current))]
    [KnownType(typeof(CurrentOrDefaultReservation4Choice.Default))]
    [JsonDerivedType(
        typeof(CurrentOrDefaultReservation4Choice.Current),
        nameof(CurrentOrDefaultReservation4Choice.Current)
    )]
    [JsonDerivedType(
        typeof(CurrentOrDefaultReservation4Choice.Default),
        nameof(CurrentOrDefaultReservation4Choice.Default)
    )]
    [IsoId("_5IwmYTEyEe6g-ffJsqGiSA")]
    [DisplayName("Current Or Default Reservation4Choice")]
    public abstract record CurrentOrDefaultReservation4Choice_ { }
}
