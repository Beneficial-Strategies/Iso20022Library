// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code or a date code and a time.
    /// </summary>
    [KnownType(typeof(DateFormat20Choice.Date))]
    [KnownType(typeof(DateFormat20Choice.DateCodeAndTime))]
    [KnownType(typeof(DateFormat20Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat20Choice.Date), nameof(DateFormat20Choice.Date))]
    [JsonDerivedType(
        typeof(DateFormat20Choice.DateCodeAndTime),
        nameof(DateFormat20Choice.DateCodeAndTime)
    )]
    [JsonDerivedType(typeof(DateFormat20Choice.DateCode), nameof(DateFormat20Choice.DateCode))]
    [IsoId("_lH2aRfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Date Format 20 Choice")]
    public abstract record DateFormat20Choice_ { }
}
