// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(ReservationCriteria4Choice.QueryName))]
    [KnownType(typeof(ReservationCriteria4Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(ReservationCriteria4Choice.QueryName),
        nameof(ReservationCriteria4Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(ReservationCriteria4Choice.NewCriteria),
        nameof(ReservationCriteria4Choice.NewCriteria)
    )]
    [IsoId("_grsrAdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reservation Criteria 4 Choice")]
    public abstract record ReservationCriteria4Choice_ { }
}
