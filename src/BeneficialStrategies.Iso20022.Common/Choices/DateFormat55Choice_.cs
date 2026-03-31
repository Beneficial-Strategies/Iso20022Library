// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat55Choice.Date))]
    [KnownType(typeof(DateFormat55Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat55Choice.Date), nameof(DateFormat55Choice.Date))]
    [JsonDerivedType(typeof(DateFormat55Choice.DateCode), nameof(DateFormat55Choice.DateCode))]
    [IsoId("_k9v9083xEee5nJBZsW8MFQ")]
    [DisplayName("Date Format 55 Choice")]
    public abstract record DateFormat55Choice_ { }
}
