// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the generated reason.
    /// </summary>
    [KnownType(typeof(GeneratedReasons6Choice.Code))]
    [KnownType(typeof(GeneratedReasons6Choice.Proprietary))]
    [JsonDerivedType(typeof(GeneratedReasons6Choice.Code), nameof(GeneratedReasons6Choice.Code))]
    [JsonDerivedType(
        typeof(GeneratedReasons6Choice.Proprietary),
        nameof(GeneratedReasons6Choice.Proprietary)
    )]
    [IsoId("_6d7vVZNLEeWGlc8L7oPDIg")]
    [DisplayName("Generated Reasons 6 Choice")]
    public abstract record GeneratedReasons6Choice_ { }
}
