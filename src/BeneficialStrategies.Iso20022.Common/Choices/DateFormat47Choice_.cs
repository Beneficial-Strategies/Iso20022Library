// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the value of a date.
    /// </summary>
    [KnownType(typeof(DateFormat47Choice.Date))]
    [KnownType(typeof(DateFormat47Choice.NotSpecifiedDate))]
    [JsonDerivedType(typeof(DateFormat47Choice.Date),nameof(DateFormat47Choice.Date))]
    [JsonDerivedType(typeof(DateFormat47Choice.NotSpecifiedDate),nameof(DateFormat47Choice.NotSpecifiedDate))]
    [IsoId("_HVVRC8kbEee7W-rN1yqPMg")]
    [DisplayName("Date Format 47 Choice")]
    public abstract partial record DateFormat47Choice_
    {
    }
}
