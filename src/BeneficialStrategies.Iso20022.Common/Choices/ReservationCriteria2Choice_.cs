// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(ReservationCriteria2Choice.QueryName))]
    [KnownType(typeof(ReservationCriteria2Choice.NewCriteria))]
    [JsonDerivedType(typeof(ReservationCriteria2Choice.QueryName),nameof(ReservationCriteria2Choice.QueryName))]
    [JsonDerivedType(typeof(ReservationCriteria2Choice.NewCriteria),nameof(ReservationCriteria2Choice.NewCriteria))]
    [IsoId("_keMrp5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Reservation Criteria 2 Choice")]
    public abstract partial record ReservationCriteria2Choice_
    {
    }
}
