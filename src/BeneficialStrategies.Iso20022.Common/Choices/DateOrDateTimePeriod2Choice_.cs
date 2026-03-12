// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date and time format for a period.
    /// </summary>
    [KnownType(typeof(DateOrDateTimePeriod2Choice.Date))]
    [KnownType(typeof(DateOrDateTimePeriod2Choice.DateTime))]
    [JsonDerivedType(typeof(DateOrDateTimePeriod2Choice.Date),nameof(DateOrDateTimePeriod2Choice.Date))]
    [JsonDerivedType(typeof(DateOrDateTimePeriod2Choice.DateTime),nameof(DateOrDateTimePeriod2Choice.DateTime))]
    [IsoId("_lq6kIbQVEeemgtANb5gbCw")]
    [DisplayName("Date Or Date Time Period 2 Choice")]
    public abstract partial record DateOrDateTimePeriod2Choice_
    {
    }
}
