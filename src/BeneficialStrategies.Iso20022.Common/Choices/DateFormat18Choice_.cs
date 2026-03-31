// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat18Choice.Date))]
    [KnownType(typeof(DateFormat18Choice.NotSpecifiedDate))]
    [JsonDerivedType(typeof(DateFormat18Choice.Date), nameof(DateFormat18Choice.Date))]
    [JsonDerivedType(
        typeof(DateFormat18Choice.NotSpecifiedDate),
        nameof(DateFormat18Choice.NotSpecifiedDate)
    )]
    [IsoId("_QhuyIeENEd-qUMZtd_eZuQ")]
    [DisplayName("Date Format 18 Choice")]
    public abstract record DateFormat18Choice_ { }
}
