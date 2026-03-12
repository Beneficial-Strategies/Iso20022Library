// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType30Choice.Addition))]
    [KnownType(typeof(UpdateType30Choice.Deletion))]
    [KnownType(typeof(UpdateType30Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType30Choice.Addition),nameof(UpdateType30Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType30Choice.Deletion),nameof(UpdateType30Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType30Choice.Modification),nameof(UpdateType30Choice.Modification))]
    [IsoId("_fpPMoffYEeiNZp_PtLohLw")]
    [DisplayName("Update Type 30 Choice")]
    public abstract partial record UpdateType30Choice_
    {
    }
}
