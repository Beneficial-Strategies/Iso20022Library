// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType9Choice.Addition))]
    [KnownType(typeof(UpdateType9Choice.Deletion))]
    [KnownType(typeof(UpdateType9Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType9Choice.Addition), nameof(UpdateType9Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType9Choice.Deletion), nameof(UpdateType9Choice.Deletion))]
    [JsonDerivedType(
        typeof(UpdateType9Choice.Modification),
        nameof(UpdateType9Choice.Modification)
    )]
    [IsoId("_nBXQ4Q0BEeKd14R19frrfQ")]
    [DisplayName("Update Type 9 Choice")]
    public abstract record UpdateType9Choice_ { }
}
