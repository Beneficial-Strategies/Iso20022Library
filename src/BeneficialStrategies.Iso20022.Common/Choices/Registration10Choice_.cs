// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration10Choice.Code))]
    [KnownType(typeof(Registration10Choice.Proprietary))]
    [JsonDerivedType(typeof(Registration10Choice.Code), nameof(Registration10Choice.Code))]
    [JsonDerivedType(
        typeof(Registration10Choice.Proprietary),
        nameof(Registration10Choice.Proprietary)
    )]
    [IsoId("_zWwOFTqfEeWyoP0PbocV1Q")]
    [DisplayName("Registration 10 Choice")]
    public abstract record Registration10Choice_ { }
}
