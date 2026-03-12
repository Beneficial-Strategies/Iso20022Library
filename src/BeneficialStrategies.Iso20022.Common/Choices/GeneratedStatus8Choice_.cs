// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of generated status.
    /// </summary>
    [KnownType(typeof(GeneratedStatus8Choice.NoSpecifiedReason))]
    [KnownType(typeof(GeneratedStatus8Choice.Reason))]
    [JsonDerivedType(typeof(GeneratedStatus8Choice.NoSpecifiedReason),nameof(GeneratedStatus8Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(GeneratedStatus8Choice.Reason),nameof(GeneratedStatus8Choice.Reason))]
    [IsoId("_8VJvzZNLEeWGlc8L7oPDIg")]
    [DisplayName("Generated Status 8 Choice")]
    public abstract partial record GeneratedStatus8Choice_
    {
    }
}
