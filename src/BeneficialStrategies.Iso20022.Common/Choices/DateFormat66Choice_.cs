// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Date Format66Choice.
    /// </summary>
    [KnownType(typeof(DateFormat66Choice.Date))]
    [KnownType(typeof(DateFormat66Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat66Choice.Date),nameof(DateFormat66Choice.Date))]
    [JsonDerivedType(typeof(DateFormat66Choice.DateCode),nameof(DateFormat66Choice.DateCode))]
    [IsoId("_ZxdUYZIXEe-HRNGM304Vlw")]
    [DisplayName("Date Format66Choice")]
    public abstract partial record DateFormat66Choice_
    {
    }
}
