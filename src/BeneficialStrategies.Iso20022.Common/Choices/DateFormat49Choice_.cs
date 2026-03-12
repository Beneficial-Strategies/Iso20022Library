// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat49Choice.Date))]
    [KnownType(typeof(DateFormat49Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat49Choice.Date),nameof(DateFormat49Choice.Date))]
    [JsonDerivedType(typeof(DateFormat49Choice.DateCode),nameof(DateFormat49Choice.DateCode))]
    [IsoId("_nTZeMckdEee7W-rN1yqPMg")]
    [DisplayName("Date Format 49 Choice")]
    public abstract partial record DateFormat49Choice_
    {
    }
}
