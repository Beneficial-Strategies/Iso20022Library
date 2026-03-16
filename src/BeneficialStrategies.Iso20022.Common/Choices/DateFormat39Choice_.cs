// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat39Choice.Date))]
    [KnownType(typeof(DateFormat39Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat39Choice.Date), nameof(DateFormat39Choice.Date))]
    [JsonDerivedType(typeof(DateFormat39Choice.DateCode), nameof(DateFormat39Choice.DateCode))]
    [IsoId("_ctmkJ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Date Format 39 Choice")]
    public abstract record DateFormat39Choice_ { }
}
