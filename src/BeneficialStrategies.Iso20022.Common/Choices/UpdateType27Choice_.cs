// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType27Choice.Addition))]
    [KnownType(typeof(UpdateType27Choice.Deletion))]
    [KnownType(typeof(UpdateType27Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType27Choice.Addition),nameof(UpdateType27Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType27Choice.Deletion),nameof(UpdateType27Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType27Choice.Modification),nameof(UpdateType27Choice.Modification))]
    [IsoId("_HyT-4az2EeeBIMhGLpLUsQ")]
    [DisplayName("Update Type 27 Choice")]
    public abstract partial record UpdateType27Choice_
    {
    }
}
