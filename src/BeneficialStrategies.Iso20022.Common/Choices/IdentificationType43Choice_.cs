// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType43Choice.Code))]
    [KnownType(typeof(IdentificationType43Choice.Proprietary))]
    [JsonDerivedType(
        typeof(IdentificationType43Choice.Code),
        nameof(IdentificationType43Choice.Code)
    )]
    [JsonDerivedType(
        typeof(IdentificationType43Choice.Proprietary),
        nameof(IdentificationType43Choice.Proprietary)
    )]
    [IsoId("_gWRMa4MEEeWhGPRU7TIQwQ")]
    [DisplayName("Identification Type 43 Choice")]
    public abstract record IdentificationType43Choice_ { }
}
