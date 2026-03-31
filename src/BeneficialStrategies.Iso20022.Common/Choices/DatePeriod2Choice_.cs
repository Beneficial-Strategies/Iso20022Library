// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Range of time defined by a start date and an end date.
    /// </summary>
    [KnownType(typeof(DatePeriod2Choice.FromDate))]
    [KnownType(typeof(DatePeriod2Choice.ToDate))]
    [KnownType(typeof(DatePeriod2Choice.FromToDate))]
    [JsonDerivedType(typeof(DatePeriod2Choice.FromDate), nameof(DatePeriod2Choice.FromDate))]
    [JsonDerivedType(typeof(DatePeriod2Choice.ToDate), nameof(DatePeriod2Choice.ToDate))]
    [JsonDerivedType(typeof(DatePeriod2Choice.FromToDate), nameof(DatePeriod2Choice.FromToDate))]
    [IsoId("_jNAKm5lPEee-Zps0fZQaFQ")]
    [DisplayName("Date Period 2 Choice")]
    public abstract record DatePeriod2Choice_ { }
}
