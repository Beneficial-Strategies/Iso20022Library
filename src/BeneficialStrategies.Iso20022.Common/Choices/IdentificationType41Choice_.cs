// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType41Choice.Code))]
    [KnownType(typeof(IdentificationType41Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationType41Choice.Code),
        nameof(IdentificationType41Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IdentificationType41Choice.Proprietary),
        nameof(IdentificationType41Choice.Proprietary)
    )]
    [IsoId("_VizA0NoqEeCWg-hsBVGrDA_-682466528")]
    [DisplayName("Identification Type 41 Choice")]
    public abstract record IdentificationType41Choice_ { }
}
