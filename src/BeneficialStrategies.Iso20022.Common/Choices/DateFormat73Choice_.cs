// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat73Choice.Date))]
    [KnownType(typeof(DateFormat73Choice.NotSpecifiedDate))]
    [JsonDerivedType(typeof(DateFormat73Choice.Date), nameof(DateFormat73Choice.Date))]
    [JsonDerivedType(typeof(DateFormat73Choice.NotSpecifiedDate), nameof(DateFormat73Choice.NotSpecifiedDate))]
    [IsoId("_GM0KcatmEfCqjuqNaaNXgw")]
    [DisplayName("Date Format 73 Choice")]
    public abstract record DateFormat73Choice_ { }
}
