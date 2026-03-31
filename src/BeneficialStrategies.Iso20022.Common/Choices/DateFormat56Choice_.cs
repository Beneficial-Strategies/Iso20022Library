// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat56Choice.Date))]
    [KnownType(typeof(DateFormat56Choice.NotSpecifiedDate))]
    [KnownType(typeof(DateFormat56Choice.Proprietary))]
    [JsonDerivedType(typeof(DateFormat56Choice.Date), nameof(DateFormat56Choice.Date))]
    [JsonDerivedType(
        typeof(DateFormat56Choice.NotSpecifiedDate),
        nameof(DateFormat56Choice.NotSpecifiedDate)
    )]
    [JsonDerivedType(
        typeof(DateFormat56Choice.Proprietary),
        nameof(DateFormat56Choice.Proprietary)
    )]
    [IsoId("_7fQ0QeWdEeevU7McUP3D1w")]
    [DisplayName("Date Format 56 Choice")]
    public abstract record DateFormat56Choice_ { }
}
