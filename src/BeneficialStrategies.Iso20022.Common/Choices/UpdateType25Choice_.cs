// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType25Choice.Addition))]
    [KnownType(typeof(UpdateType25Choice.Deletion))]
    [KnownType(typeof(UpdateType25Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType25Choice.Addition),nameof(UpdateType25Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType25Choice.Deletion),nameof(UpdateType25Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType25Choice.Modification),nameof(UpdateType25Choice.Modification))]
    [IsoId("_cbtx0YyeEeaxLOI-Kq-S4w")]
    [DisplayName("Update Type 25 Choice")]
    public abstract partial record UpdateType25Choice_
    {
    }
}
