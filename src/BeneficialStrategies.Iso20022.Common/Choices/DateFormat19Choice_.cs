// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat19Choice.Date))]
    [KnownType(typeof(DateFormat19Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat19Choice.Date), nameof(DateFormat19Choice.Date))]
    [JsonDerivedType(typeof(DateFormat19Choice.DateCode), nameof(DateFormat19Choice.DateCode))]
    [IsoId("_jMBmwfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Date Format 19 Choice")]
    public abstract record DateFormat19Choice_ { }
}
