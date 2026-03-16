// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to specify the type of natural person identification.
    /// </summary>
    [KnownType(typeof(IdentificationType45Choice.Code))]
    [KnownType(typeof(IdentificationType45Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationType45Choice.Code),
        nameof(IdentificationType45Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IdentificationType45Choice.Proprietary),
        nameof(IdentificationType45Choice.Proprietary)
    )]
    [IsoId("_ql4v0Id6EemJ1cSJJmVYRQ")]
    [DisplayName("Identification Type 45 Choice")]
    public abstract record IdentificationType45Choice_ { }
}
