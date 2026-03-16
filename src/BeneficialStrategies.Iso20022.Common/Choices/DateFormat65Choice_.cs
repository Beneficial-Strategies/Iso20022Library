// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Date Format65Choice.
    /// </summary>
    [KnownType(typeof(DateFormat65Choice.Date))]
    [KnownType(typeof(DateFormat65Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat65Choice.Date),nameof(DateFormat65Choice.Date))]
    [JsonDerivedType(typeof(DateFormat65Choice.DateCode),nameof(DateFormat65Choice.DateCode))]
    [IsoId("_FZ-6YZIWEe-HRNGM304Vlw")]
    [DisplayName("Date Format65Choice")]
    public abstract partial record DateFormat65Choice_
    {
    }
}
