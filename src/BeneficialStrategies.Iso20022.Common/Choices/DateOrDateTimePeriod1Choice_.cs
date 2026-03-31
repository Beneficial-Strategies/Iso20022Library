// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date and time format for a period.
    /// </summary>
    [KnownType(typeof(DateOrDateTimePeriod1Choice.Date))]
    [KnownType(typeof(DateOrDateTimePeriod1Choice.DateTime))]
    [JsonDerivedType(
        typeof(DateOrDateTimePeriod1Choice.Date),
        nameof(DateOrDateTimePeriod1Choice.Date)
    )]
    [JsonDerivedType(
        typeof(DateOrDateTimePeriod1Choice.DateTime),
        nameof(DateOrDateTimePeriod1Choice.DateTime)
    )]
    [IsoId("_Q8Ps0a6AEeexrtTFgmVD3Q")]
    [DisplayName("Date Or Date Time Period 1 Choice")]
    public abstract record DateOrDateTimePeriod1Choice_ { }
}
