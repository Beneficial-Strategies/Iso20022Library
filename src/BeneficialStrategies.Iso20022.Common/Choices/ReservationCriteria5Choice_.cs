// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(ReservationCriteria5Choice.QueryName))]
    [KnownType(typeof(ReservationCriteria5Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(ReservationCriteria5Choice.QueryName),
        nameof(ReservationCriteria5Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(ReservationCriteria5Choice.NewCriteria),
        nameof(ReservationCriteria5Choice.NewCriteria)
    )]
    [IsoId("_xgiPUQy_Ee2Wmf2RrXviyA")]
    [DisplayName("Reservation Criteria 5 Choice")]
    public abstract record ReservationCriteria5Choice_ { }
}
