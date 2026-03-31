// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Date Code35Choice.
    /// </summary>
    [KnownType(typeof(DateCode35Choice.Code))]
    [KnownType(typeof(DateCode35Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode35Choice.Code), nameof(DateCode35Choice.Code))]
    [JsonDerivedType(typeof(DateCode35Choice.Proprietary), nameof(DateCode35Choice.Proprietary))]
    [IsoId("_XTYz8aAXEe-6zfgb2Rwrlw")]
    [DisplayName("Date Code35Choice")]
    public abstract record DateCode35Choice_ { }
}
