// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType26Choice.Addition))]
    [KnownType(typeof(UpdateType26Choice.Deletion))]
    [KnownType(typeof(UpdateType26Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType26Choice.Addition),nameof(UpdateType26Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType26Choice.Deletion),nameof(UpdateType26Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType26Choice.Modification),nameof(UpdateType26Choice.Modification))]
    [IsoId("_JfG62Zw3EeazcsnODTksnQ")]
    [DisplayName("Update Type 26 Choice")]
    public abstract partial record UpdateType26Choice_
    {
    }
}
