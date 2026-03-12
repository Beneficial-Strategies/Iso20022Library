// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between action to request on a security.
    /// </summary>
    [KnownType(typeof(UpdateType35Choice.Add))]
    [KnownType(typeof(UpdateType35Choice.Delete))]
    [KnownType(typeof(UpdateType35Choice.Modify))]
    [JsonDerivedType(typeof(UpdateType35Choice.Add),nameof(UpdateType35Choice.Add))]
    [JsonDerivedType(typeof(UpdateType35Choice.Delete),nameof(UpdateType35Choice.Delete))]
    [JsonDerivedType(typeof(UpdateType35Choice.Modify),nameof(UpdateType35Choice.Modify))]
    [IsoId("_QMJpmZJKEeuAlLVx8pyt3w")]
    [DisplayName("Update Type 35 Choice")]
    public abstract partial record UpdateType35Choice_
    {
    }
}
