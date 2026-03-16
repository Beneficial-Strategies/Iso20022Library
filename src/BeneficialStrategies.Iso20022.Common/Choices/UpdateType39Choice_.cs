// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Update Type39Choice.
    /// </summary>
    [KnownType(typeof(UpdateType39Choice.Addition))]
    [KnownType(typeof(UpdateType39Choice.Deletion))]
    [KnownType(typeof(UpdateType39Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType39Choice.Addition),nameof(UpdateType39Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType39Choice.Deletion),nameof(UpdateType39Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType39Choice.Modification),nameof(UpdateType39Choice.Modification))]
    [IsoId("_XJ4J6YS2Ee-Pv9KR9bv9IA")]
    [DisplayName("Update Type39Choice")]
    public abstract partial record UpdateType39Choice_
    {
    }
}
