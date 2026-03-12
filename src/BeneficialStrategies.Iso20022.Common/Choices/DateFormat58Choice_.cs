// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat58Choice.DateOrDateTime))]
    [KnownType(typeof(DateFormat58Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat58Choice.DateOrDateTime),nameof(DateFormat58Choice.DateOrDateTime))]
    [JsonDerivedType(typeof(DateFormat58Choice.DateCode),nameof(DateFormat58Choice.DateCode))]
    [IsoId("_kmLOfa09EemDtrWpq90Ckg")]
    [DisplayName("Date Format 58 Choice")]
    public abstract partial record DateFormat58Choice_
    {
    }
}
