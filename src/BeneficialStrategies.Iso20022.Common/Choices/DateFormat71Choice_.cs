// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Date Format71Choice.
    /// </summary>
    [KnownType(typeof(DateFormat71Choice.Date))]
    [KnownType(typeof(DateFormat71Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat71Choice.Date), nameof(DateFormat71Choice.Date))]
    [JsonDerivedType(typeof(DateFormat71Choice.DateCode), nameof(DateFormat71Choice.DateCode))]
    [IsoId("_y8eoEaAdEe-6zfgb2Rwrlw")]
    [DisplayName("Date Format71Choice")]
    public abstract record DateFormat71Choice_ { }
}
