// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of generated status.
    /// </summary>
    [KnownType(typeof(GeneratedStatus7Choice.NoSpecifiedReason))]
    [KnownType(typeof(GeneratedStatus7Choice.Reason))]
    [JsonDerivedType(typeof(GeneratedStatus7Choice.NoSpecifiedReason),nameof(GeneratedStatus7Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(GeneratedStatus7Choice.Reason),nameof(GeneratedStatus7Choice.Reason))]
    [IsoId("_O8oP2TqeEeWyoP0PbocV1Q")]
    [DisplayName("Generated Status 7 Choice")]
    public abstract partial record GeneratedStatus7Choice_
    {
    }
}
