// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat28Choice.Date))]
    [KnownType(typeof(DateFormat28Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat28Choice.Date),nameof(DateFormat28Choice.Date))]
    [JsonDerivedType(typeof(DateFormat28Choice.DateCode),nameof(DateFormat28Choice.DateCode))]
    [IsoId("_WUMGOX0qEeO-puV1mV96Kg")]
    [DisplayName("Date Format 28 Choice")]
    public abstract partial record DateFormat28Choice_
    {
    }
}
