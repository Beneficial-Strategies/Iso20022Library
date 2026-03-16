// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reservation Criteria6Choice.
    /// </summary>
    [KnownType(typeof(ReservationCriteria6Choice.NewCriteria))]
    [KnownType(typeof(ReservationCriteria6Choice.QueryName))]
    [JsonDerivedType(typeof(ReservationCriteria6Choice.NewCriteria),nameof(ReservationCriteria6Choice.NewCriteria))]
    [JsonDerivedType(typeof(ReservationCriteria6Choice.QueryName),nameof(ReservationCriteria6Choice.QueryName))]
    [IsoId("_zsubhTEyEe6g-ffJsqGiSA")]
    [DisplayName("Reservation Criteria6Choice")]
    public abstract partial record ReservationCriteria6Choice_
    {
    }
}
