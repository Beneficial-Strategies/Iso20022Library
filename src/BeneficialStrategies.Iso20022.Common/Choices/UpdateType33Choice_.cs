// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType33Choice.Addition))]
    [KnownType(typeof(UpdateType33Choice.Deletion))]
    [KnownType(typeof(UpdateType33Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType33Choice.Addition),nameof(UpdateType33Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType33Choice.Deletion),nameof(UpdateType33Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType33Choice.Modification),nameof(UpdateType33Choice.Modification))]
    [IsoId("_lg1sUQleEeuQ1MenzX1l-g")]
    [DisplayName("Update Type 33 Choice")]
    public abstract partial record UpdateType33Choice_
    {
    }
}
