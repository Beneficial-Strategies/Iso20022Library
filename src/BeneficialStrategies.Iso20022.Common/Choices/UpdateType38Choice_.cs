// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType38Choice.Addition))]
    [KnownType(typeof(UpdateType38Choice.Deletion))]
    [KnownType(typeof(UpdateType38Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType38Choice.Addition),nameof(UpdateType38Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType38Choice.Deletion),nameof(UpdateType38Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType38Choice.Modification),nameof(UpdateType38Choice.Modification))]
    [IsoId("_eZThlTi8Eeydid5dcNPKvg")]
    [DisplayName("Update Type 38 Choice")]
    public abstract partial record UpdateType38Choice_
    {
    }
}
