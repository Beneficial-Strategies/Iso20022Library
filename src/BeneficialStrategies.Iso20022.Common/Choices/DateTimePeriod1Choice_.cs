// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between various date time patterns.
    /// </summary>
    [KnownType(typeof(DateTimePeriod1Choice.FromDateTime))]
    [KnownType(typeof(DateTimePeriod1Choice.ToDateTime))]
    [KnownType(typeof(DateTimePeriod1Choice.DateTimeRange))]
    [JsonDerivedType(
        typeof(DateTimePeriod1Choice.FromDateTime),
        nameof(DateTimePeriod1Choice.FromDateTime)
    )]
    [JsonDerivedType(
        typeof(DateTimePeriod1Choice.ToDateTime),
        nameof(DateTimePeriod1Choice.ToDateTime)
    )]
    [JsonDerivedType(
        typeof(DateTimePeriod1Choice.DateTimeRange),
        nameof(DateTimePeriod1Choice.DateTimeRange)
    )]
    [IsoId("_xLYeBZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Date Time Period 1 Choice")]
    public abstract record DateTimePeriod1Choice_ { }
}
