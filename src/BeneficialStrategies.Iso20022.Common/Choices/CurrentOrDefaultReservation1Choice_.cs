// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Current or default reservation set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(CurrentOrDefaultReservation1Choice.Current))]
    [KnownType(typeof(CurrentOrDefaultReservation1Choice.Default))]
    [JsonDerivedType(
        typeof(CurrentOrDefaultReservation1Choice.Current),
        nameof(CurrentOrDefaultReservation1Choice.Current)
    )]
    [JsonDerivedType(
        typeof(CurrentOrDefaultReservation1Choice.Default),
        nameof(CurrentOrDefaultReservation1Choice.Default)
    )]
    [IsoId("_8IjoJKMgEeCJ6YNENx4h-w_-1597699286")]
    [DisplayName("Current Or Default Reservation 1 Choice")]
    public abstract record CurrentOrDefaultReservation1Choice_ { }
}
