// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat48Choice.Date))]
    [KnownType(typeof(DateFormat48Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat48Choice.Date),nameof(DateFormat48Choice.Date))]
    [JsonDerivedType(typeof(DateFormat48Choice.DateCode),nameof(DateFormat48Choice.DateCode))]
    [IsoId("_lFUvAckbEee7W-rN1yqPMg")]
    [DisplayName("Date Format 48 Choice")]
    public abstract partial record DateFormat48Choice_
    {
    }
}
