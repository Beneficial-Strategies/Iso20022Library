// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Date Format67Choice.
    /// </summary>
    [KnownType(typeof(DateFormat67Choice.Date))]
    [KnownType(typeof(DateFormat67Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat67Choice.Date), nameof(DateFormat67Choice.Date))]
    [JsonDerivedType(typeof(DateFormat67Choice.DateCode), nameof(DateFormat67Choice.DateCode))]
    [IsoId("_XMoEkaAXEe-6zfgb2Rwrlw")]
    [DisplayName("Date Format67Choice")]
    public abstract record DateFormat67Choice_ { }
}
