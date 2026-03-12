// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between search criteria based on dates and time ranges.
    /// </summary>
    [KnownType(typeof(DatePeriodSearch1Choice.FromDate))]
    [KnownType(typeof(DatePeriodSearch1Choice.ToDate))]
    [KnownType(typeof(DatePeriodSearch1Choice.FromToDate))]
    [KnownType(typeof(DatePeriodSearch1Choice.EqualDate))]
    [KnownType(typeof(DatePeriodSearch1Choice.NotEqualDate))]
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.FromDate),nameof(DatePeriodSearch1Choice.FromDate))]
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.ToDate),nameof(DatePeriodSearch1Choice.ToDate))]
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.FromToDate),nameof(DatePeriodSearch1Choice.FromToDate))]
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.EqualDate),nameof(DatePeriodSearch1Choice.EqualDate))]
    [JsonDerivedType(typeof(DatePeriodSearch1Choice.NotEqualDate),nameof(DatePeriodSearch1Choice.NotEqualDate))]
    [IsoId("_aIDZIYaAEee8r9VKRbnJSg")]
    [DisplayName("Date Period Search 1 Choice")]
    public abstract partial record DatePeriodSearch1Choice_
    {
    }
}
