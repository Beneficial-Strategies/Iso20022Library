// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code or a date code and a time.
    /// </summary>
    [KnownType(typeof(DateFormat38Choice.Date))]
    [KnownType(typeof(DateFormat38Choice.DateCodeAndTime))]
    [KnownType(typeof(DateFormat38Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat38Choice.Date), nameof(DateFormat38Choice.Date))]
    [JsonDerivedType(
        typeof(DateFormat38Choice.DateCodeAndTime),
        nameof(DateFormat38Choice.DateCodeAndTime)
    )]
    [JsonDerivedType(typeof(DateFormat38Choice.DateCode), nameof(DateFormat38Choice.DateCode))]
    [IsoId("_ctcMzZKQEeWHWpTQn1FFVg")]
    [DisplayName("Date Format 38 Choice")]
    public abstract record DateFormat38Choice_ { }
}
