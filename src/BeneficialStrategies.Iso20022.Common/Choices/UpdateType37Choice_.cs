// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType37Choice.Addition))]
    [KnownType(typeof(UpdateType37Choice.Deletion))]
    [KnownType(typeof(UpdateType37Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType37Choice.Addition),nameof(UpdateType37Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType37Choice.Deletion),nameof(UpdateType37Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType37Choice.Modification),nameof(UpdateType37Choice.Modification))]
    [IsoId("_h2gZMSglEey2k_sfZmJz4g")]
    [DisplayName("Update Type 37 Choice")]
    public abstract partial record UpdateType37Choice_
    {
    }
}
