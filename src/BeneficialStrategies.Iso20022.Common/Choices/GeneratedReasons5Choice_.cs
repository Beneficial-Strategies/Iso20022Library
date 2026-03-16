// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the generated reason.
    /// </summary>
    [KnownType(typeof(GeneratedReasons5Choice.Code))]
    [KnownType(typeof(GeneratedReasons5Choice.Proprietary))]
    [JsonDerivedType(typeof(GeneratedReasons5Choice.Code), nameof(GeneratedReasons5Choice.Code))]
    [JsonDerivedType(
        typeof(GeneratedReasons5Choice.Proprietary),
        nameof(GeneratedReasons5Choice.Proprietary)
    )]
    [IsoId("_N9GsgTqeEeWyoP0PbocV1Q")]
    [DisplayName("Generated Reasons 5 Choice")]
    public abstract record GeneratedReasons5Choice_ { }
}
