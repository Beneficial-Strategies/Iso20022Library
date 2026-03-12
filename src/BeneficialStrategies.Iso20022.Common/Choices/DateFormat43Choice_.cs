// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat43Choice.Date))]
    [KnownType(typeof(DateFormat43Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat43Choice.Date),nameof(DateFormat43Choice.Date))]
    [JsonDerivedType(typeof(DateFormat43Choice.DateCode),nameof(DateFormat43Choice.DateCode))]
    [IsoId("_czlFK7QXEeeKRKrD60ELBQ")]
    [DisplayName("Date Format 43 Choice")]
    public abstract partial record DateFormat43Choice_
    {
    }
}
