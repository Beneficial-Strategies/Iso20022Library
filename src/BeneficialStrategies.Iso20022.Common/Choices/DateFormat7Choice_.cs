// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code or a date code and a time.
    /// </summary>
    [KnownType(typeof(DateFormat7Choice.Date))]
    [KnownType(typeof(DateFormat7Choice.DateCodeAndTime))]
    [KnownType(typeof(DateFormat7Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat7Choice.Date),nameof(DateFormat7Choice.Date))]
    [JsonDerivedType(typeof(DateFormat7Choice.DateCodeAndTime),nameof(DateFormat7Choice.DateCodeAndTime))]
    [JsonDerivedType(typeof(DateFormat7Choice.DateCode),nameof(DateFormat7Choice.DateCode))]
    [IsoId("_Q237odp-Ed-ak6NoX_4Aeg_-834882523")]
    [DisplayName("Date Format 7 Choice")]
    public abstract partial record DateFormat7Choice_
    {
    }
}
