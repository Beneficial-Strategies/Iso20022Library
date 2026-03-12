// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate or ISODateTime format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat46Choice.Date))]
    [KnownType(typeof(DateFormat46Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat46Choice.Date),nameof(DateFormat46Choice.Date))]
    [JsonDerivedType(typeof(DateFormat46Choice.DateCode),nameof(DateFormat46Choice.DateCode))]
    [IsoId("_5BWFwbQYEeeKRKrD60ELBQ")]
    [DisplayName("Date Format 46 Choice")]
    public abstract partial record DateFormat46Choice_
    {
    }
}
