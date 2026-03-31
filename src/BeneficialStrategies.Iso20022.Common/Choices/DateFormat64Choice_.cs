// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the date.
    /// </summary>
    [KnownType(typeof(DateFormat64Choice.Date))]
    [KnownType(typeof(DateFormat64Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat64Choice.Date), nameof(DateFormat64Choice.Date))]
    [JsonDerivedType(typeof(DateFormat64Choice.DateCode), nameof(DateFormat64Choice.DateCode))]
    [IsoId("_TtBUi199Ee262vCSVgjImg")]
    [DisplayName("Date Format 64 Choice")]
    public abstract record DateFormat64Choice_ { }
}
