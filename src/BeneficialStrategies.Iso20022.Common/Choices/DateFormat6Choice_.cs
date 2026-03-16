// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat6Choice.Date))]
    [KnownType(typeof(DateFormat6Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat6Choice.Date), nameof(DateFormat6Choice.Date))]
    [JsonDerivedType(typeof(DateFormat6Choice.DateCode), nameof(DateFormat6Choice.DateCode))]
    [IsoId("_Q5GwRNp-Ed-ak6NoX_4Aeg_-427434640")]
    [DisplayName("Date Format 6 Choice")]
    public abstract record DateFormat6Choice_ { }
}
