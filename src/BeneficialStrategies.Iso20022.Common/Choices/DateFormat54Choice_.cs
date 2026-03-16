// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code or a date code and a time.
    /// </summary>
    [KnownType(typeof(DateFormat54Choice.Date))]
    [KnownType(typeof(DateFormat54Choice.DateCodeAndTime))]
    [KnownType(typeof(DateFormat54Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat54Choice.Date), nameof(DateFormat54Choice.Date))]
    [JsonDerivedType(
        typeof(DateFormat54Choice.DateCodeAndTime),
        nameof(DateFormat54Choice.DateCodeAndTime)
    )]
    [JsonDerivedType(typeof(DateFormat54Choice.DateCode), nameof(DateFormat54Choice.DateCode))]
    [IsoId("_k9m0rc3xEee5nJBZsW8MFQ")]
    [DisplayName("Date Format 54 Choice")]
    public abstract record DateFormat54Choice_ { }
}
