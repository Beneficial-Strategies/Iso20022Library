// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date and time format for a period.
    /// </summary>
    [KnownType(typeof(DateOrDateTimePeriod3Choice.Date))]
    [KnownType(typeof(DateOrDateTimePeriod3Choice.DateTime))]
    [JsonDerivedType(typeof(DateOrDateTimePeriod3Choice.Date),nameof(DateOrDateTimePeriod3Choice.Date))]
    [JsonDerivedType(typeof(DateOrDateTimePeriod3Choice.DateTime),nameof(DateOrDateTimePeriod3Choice.DateTime))]
    [IsoId("_Fk5tk_1bEeiAfJEqh4xF_Q")]
    [DisplayName("Date Or Date Time Period 3 Choice")]
    public abstract partial record DateOrDateTimePeriod3Choice_
    {
    }
}
