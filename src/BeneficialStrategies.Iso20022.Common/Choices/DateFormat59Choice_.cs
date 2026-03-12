// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat59Choice.Date))]
    [KnownType(typeof(DateFormat59Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat59Choice.Date),nameof(DateFormat59Choice.Date))]
    [JsonDerivedType(typeof(DateFormat59Choice.DateCode),nameof(DateFormat59Choice.DateCode))]
    [IsoId("_8YeEGu3CEeqc-LCjwLsUVg")]
    [DisplayName("Date Format 59 Choice")]
    public abstract partial record DateFormat59Choice_
    {
    }
}
