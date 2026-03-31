// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType29Choice.Addition))]
    [KnownType(typeof(UpdateType29Choice.Deletion))]
    [KnownType(typeof(UpdateType29Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType29Choice.Addition), nameof(UpdateType29Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType29Choice.Deletion), nameof(UpdateType29Choice.Deletion))]
    [JsonDerivedType(
        typeof(UpdateType29Choice.Modification),
        nameof(UpdateType29Choice.Modification)
    )]
    [IsoId("_ubeXIcvGEeihG9bKfarOOA")]
    [DisplayName("Update Type 29 Choice")]
    public abstract record UpdateType29Choice_ { }
}
