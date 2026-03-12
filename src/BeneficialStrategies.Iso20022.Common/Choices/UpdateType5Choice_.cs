// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of update requested. That is addition, deletion or modification.
    /// </summary>
    [KnownType(typeof(UpdateType5Choice.Addition))]
    [KnownType(typeof(UpdateType5Choice.Deletion))]
    [KnownType(typeof(UpdateType5Choice.Modification))]
    [JsonDerivedType(typeof(UpdateType5Choice.Addition),nameof(UpdateType5Choice.Addition))]
    [JsonDerivedType(typeof(UpdateType5Choice.Deletion),nameof(UpdateType5Choice.Deletion))]
    [JsonDerivedType(typeof(UpdateType5Choice.Modification),nameof(UpdateType5Choice.Modification))]
    [IsoId("_0fppkAlIEeGATtfOBToyew_-1449233606")]
    [DisplayName("Update Type 5 Choice")]
    public abstract partial record UpdateType5Choice_
    {
    }
}
