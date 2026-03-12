// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat34Choice.Date))]
    [KnownType(typeof(DateFormat34Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat34Choice.Date),nameof(DateFormat34Choice.Date))]
    [JsonDerivedType(typeof(DateFormat34Choice.DateCode),nameof(DateFormat34Choice.DateCode))]
    [IsoId("_cdSQYZKQEeWHWpTQn1FFVg")]
    [DisplayName("Date Format 34 Choice")]
    public abstract partial record DateFormat34Choice_
    {
    }
}
