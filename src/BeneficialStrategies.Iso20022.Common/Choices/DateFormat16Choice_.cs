// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat16Choice.Date))]
    [KnownType(typeof(DateFormat16Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat16Choice.Date), nameof(DateFormat16Choice.Date))]
    [JsonDerivedType(typeof(DateFormat16Choice.DateCode), nameof(DateFormat16Choice.DateCode))]
    [IsoId("_C4q7ceENEd-qUMZtd_eZuQ")]
    [DisplayName("Date Format 16 Choice")]
    public abstract record DateFormat16Choice_ { }
}
