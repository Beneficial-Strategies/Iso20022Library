// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period5Choice.FromDateTimeToDateTime))]
    [KnownType(typeof(Period5Choice.FromDateToDate))]
    [JsonDerivedType(
        typeof(Period5Choice.FromDateTimeToDateTime),
        nameof(Period5Choice.FromDateTimeToDateTime)
    )]
    [JsonDerivedType(typeof(Period5Choice.FromDateToDate), nameof(Period5Choice.FromDateToDate))]
    [IsoId("_W6N3ca3NEeey8N0JWnVPUw")]
    [DisplayName("Period 5 Choice")]
    public abstract record Period5Choice_ { }
}
