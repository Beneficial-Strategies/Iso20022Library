// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat60Choice.Date))]
    [KnownType(typeof(DateFormat60Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat60Choice.Date), nameof(DateFormat60Choice.Date))]
    [JsonDerivedType(typeof(DateFormat60Choice.DateCode), nameof(DateFormat60Choice.DateCode))]
    [IsoId("_aBRhWjUIEe2tRf29bleifQ")]
    [DisplayName("Date Format 60 Choice")]
    public abstract record DateFormat60Choice_ { }
}
