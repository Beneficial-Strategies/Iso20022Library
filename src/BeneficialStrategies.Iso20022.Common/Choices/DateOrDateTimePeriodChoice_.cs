// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date and time format for a period.
    /// </summary>
    [KnownType(typeof(DateOrDateTimePeriodChoice.Date))]
    [KnownType(typeof(DateOrDateTimePeriodChoice.DateTime))]
    [JsonDerivedType(
        typeof(DateOrDateTimePeriodChoice.Date),
        nameof(DateOrDateTimePeriodChoice.Date)
    )]
    [JsonDerivedType(
        typeof(DateOrDateTimePeriodChoice.DateTime),
        nameof(DateOrDateTimePeriodChoice.DateTime)
    )]
    [IsoId("_T6Em7Np-Ed-ak6NoX_4Aeg_1481614183")]
    [DisplayName("Date Or Date Time Period Choice")]
    public abstract record DateOrDateTimePeriodChoice_ { }
}
