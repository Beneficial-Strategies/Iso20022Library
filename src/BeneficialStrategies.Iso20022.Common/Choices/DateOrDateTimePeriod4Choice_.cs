// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date and time format for a period.
    /// </summary>
    [KnownType(typeof(DateOrDateTimePeriod4Choice.Date))]
    [KnownType(typeof(DateOrDateTimePeriod4Choice.DateTime))]
    [JsonDerivedType(typeof(DateOrDateTimePeriod4Choice.Date), nameof(DateOrDateTimePeriod4Choice.Date))]
    [JsonDerivedType(typeof(DateOrDateTimePeriod4Choice.DateTime), nameof(DateOrDateTimePeriod4Choice.DateTime))]
    [IsoId("c6ef8432-0935-45be-8b0d-6aca785aaa24")]
    [DisplayName("Date Or Date Time Period 4 Choice")]
    public abstract record DateOrDateTimePeriod4Choice_ { }
}
