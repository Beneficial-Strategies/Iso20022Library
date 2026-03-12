// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of generated status.
    /// </summary>
    [KnownType(typeof(GeneratedStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(GeneratedStatus3Choice.Reason))]
    [JsonDerivedType(typeof(GeneratedStatus3Choice.NoSpecifiedReason),nameof(GeneratedStatus3Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(GeneratedStatus3Choice.Reason),nameof(GeneratedStatus3Choice.Reason))]
    [IsoId("_1ItJsf7sEeCvPoRGOxRobQ")]
    [DisplayName("Generated Status 3 Choice")]
    public abstract partial record GeneratedStatus3Choice_
    {
    }
}
