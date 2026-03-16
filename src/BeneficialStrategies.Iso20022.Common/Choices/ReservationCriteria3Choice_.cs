// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(ReservationCriteria3Choice.QueryName))]
    [KnownType(typeof(ReservationCriteria3Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(ReservationCriteria3Choice.QueryName),
        nameof(ReservationCriteria3Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(ReservationCriteria3Choice.NewCriteria),
        nameof(ReservationCriteria3Choice.NewCriteria)
    )]
    [IsoId("_D2D0B24-EeiU9cctagi5ow")]
    [DisplayName("Reservation Criteria 3 Choice")]
    public abstract record ReservationCriteria3Choice_ { }
}
