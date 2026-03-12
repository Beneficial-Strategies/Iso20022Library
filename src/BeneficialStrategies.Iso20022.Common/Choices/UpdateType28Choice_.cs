// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType28Choice.Addition))]
    [KnownType(typeof(UpdateType28Choice.Deletion))]
    [KnownType(typeof(UpdateType28Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType28Choice.Addition),nameof(UpdateType28Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType28Choice.Deletion),nameof(UpdateType28Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType28Choice.Modification),nameof(UpdateType28Choice.Modification))]
    [IsoId("_VLd_6c32Eee5nJBZsW8MFQ")]
    [DisplayName("Update Type 28 Choice")]
    public abstract partial record UpdateType28Choice_
    {
    }
}
