// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code or a date code and a time.
    /// </summary>
    [KnownType(typeof(DateFormat44Choice.Date))]
    [KnownType(typeof(DateFormat44Choice.DateCodeAndTime))]
    [KnownType(typeof(DateFormat44Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat44Choice.Date), nameof(DateFormat44Choice.Date))]
    [JsonDerivedType(
        typeof(DateFormat44Choice.DateCodeAndTime),
        nameof(DateFormat44Choice.DateCodeAndTime)
    )]
    [JsonDerivedType(typeof(DateFormat44Choice.DateCode), nameof(DateFormat44Choice.DateCode))]
    [IsoId("_QCI9UbQYEeeKRKrD60ELBQ")]
    [DisplayName("Date Format 44 Choice")]
    public abstract record DateFormat44Choice_ { }
}
