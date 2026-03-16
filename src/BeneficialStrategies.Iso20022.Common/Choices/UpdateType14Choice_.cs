// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType14Choice.Addition))]
    [KnownType(typeof(UpdateType14Choice.Deletion))]
    [KnownType(typeof(UpdateType14Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType14Choice.Addition), nameof(UpdateType14Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType14Choice.Deletion), nameof(UpdateType14Choice.Deletion))]
    [JsonDerivedType(
        typeof(UpdateType14Choice.Modification),
        nameof(UpdateType14Choice.Modification)
    )]
    [IsoId("_LxPSyx5gEeWE3PufGMdJ3w")]
    [DisplayName("Update Type 14 Choice")]
    public abstract record UpdateType14Choice_ { }
}
