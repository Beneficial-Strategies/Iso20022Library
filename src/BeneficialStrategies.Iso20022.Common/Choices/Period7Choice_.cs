// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period7Choice.FromDateTimeToDateTime))]
    [KnownType(typeof(Period7Choice.FromDateToDate))]
    [JsonDerivedType(
        typeof(Period7Choice.FromDateTimeToDateTime),
        nameof(Period7Choice.FromDateTimeToDateTime)
    )]
    [JsonDerivedType(typeof(Period7Choice.FromDateToDate), nameof(Period7Choice.FromDateToDate))]
    [IsoId("_VEuSoTwGEemGDJYTly2NCA")]
    [DisplayName("Period 7 Choice")]
    public abstract record Period7Choice_ { }
}
