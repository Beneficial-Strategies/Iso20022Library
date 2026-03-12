// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Period as a date, a month or a date time span for which the statement is provided.
    /// </summary>
    [KnownType(typeof(DatePeriod1Choice.Date))]
    [KnownType(typeof(DatePeriod1Choice.DateMonth))]
    [KnownType(typeof(DatePeriod1Choice.FromDateToDate))]
    [JsonDerivedType(typeof(DatePeriod1Choice.Date),nameof(DatePeriod1Choice.Date))]
    [JsonDerivedType(typeof(DatePeriod1Choice.DateMonth),nameof(DatePeriod1Choice.DateMonth))]
    [JsonDerivedType(typeof(DatePeriod1Choice.FromDateToDate),nameof(DatePeriod1Choice.FromDateToDate))]
    [IsoId("_kaGgU579EeOieb-y7x0pFg")]
    [DisplayName("Date Period 1 Choice")]
    public abstract partial record DatePeriod1Choice_
    {
    }
}
