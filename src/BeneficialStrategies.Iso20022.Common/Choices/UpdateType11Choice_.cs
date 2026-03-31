// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType11Choice.Addition))]
    [KnownType(typeof(UpdateType11Choice.Deletion))]
    [KnownType(typeof(UpdateType11Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType11Choice.Addition), nameof(UpdateType11Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType11Choice.Deletion), nameof(UpdateType11Choice.Deletion))]
    [JsonDerivedType(
        typeof(UpdateType11Choice.Modification),
        nameof(UpdateType11Choice.Modification)
    )]
    [IsoId("_5o94kyTwEeOSHvJr_wacAw")]
    [DisplayName("Update Type 11 Choice")]
    public abstract record UpdateType11Choice_ { }
}
