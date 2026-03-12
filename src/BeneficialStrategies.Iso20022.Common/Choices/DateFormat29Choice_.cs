// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat29Choice.DateOrDateTime))]
    [KnownType(typeof(DateFormat29Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat29Choice.DateOrDateTime),nameof(DateFormat29Choice.DateOrDateTime))]
    [JsonDerivedType(typeof(DateFormat29Choice.DateCode),nameof(DateFormat29Choice.DateCode))]
    [IsoId("_n6yXaVt_EeSmO6RkXg92Lg")]
    [DisplayName("Date Format 29 Choice")]
    public abstract partial record DateFormat29Choice_
    {
    }
}
