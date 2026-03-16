// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Range of time defined by a start date and an end date.
    /// </summary>
    [KnownType(typeof(DatePeriod3Choice.FromDate))]
    [KnownType(typeof(DatePeriod3Choice.ToDate))]
    [KnownType(typeof(DatePeriod3Choice.FromToDate))]
    [KnownType(typeof(DatePeriod3Choice.Date))]
    [JsonDerivedType(typeof(DatePeriod3Choice.FromDate), nameof(DatePeriod3Choice.FromDate))]
    [JsonDerivedType(typeof(DatePeriod3Choice.ToDate), nameof(DatePeriod3Choice.ToDate))]
    [JsonDerivedType(typeof(DatePeriod3Choice.FromToDate), nameof(DatePeriod3Choice.FromToDate))]
    [JsonDerivedType(typeof(DatePeriod3Choice.Date), nameof(DatePeriod3Choice.Date))]
    [IsoId("_Az9J8YwDEei289CGNqs21g")]
    [DisplayName("Date Period 3 Choice")]
    public abstract record DatePeriod3Choice_ { }
}
