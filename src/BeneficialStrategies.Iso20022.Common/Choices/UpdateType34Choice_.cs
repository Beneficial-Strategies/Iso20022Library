// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType34Choice.Addition))]
    [KnownType(typeof(UpdateType34Choice.Deletion))]
    [KnownType(typeof(UpdateType34Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType34Choice.Addition),nameof(UpdateType34Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType34Choice.Deletion),nameof(UpdateType34Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType34Choice.Modification),nameof(UpdateType34Choice.Modification))]
    [IsoId("_a76DhyAdEeuyDZ-ukt4YRg")]
    [DisplayName("Update Type 34 Choice")]
    public abstract partial record UpdateType34Choice_
    {
    }
}
