// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType22Choice.Addition))]
    [KnownType(typeof(UpdateType22Choice.Deletion))]
    [KnownType(typeof(UpdateType22Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType22Choice.Addition),nameof(UpdateType22Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType22Choice.Deletion),nameof(UpdateType22Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType22Choice.Modification),nameof(UpdateType22Choice.Modification))]
    [IsoId("_61RRNZNLEeWGlc8L7oPDIg")]
    [DisplayName("Update Type 22 Choice")]
    public abstract partial record UpdateType22Choice_
    {
    }
}
