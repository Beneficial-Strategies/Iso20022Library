// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of generated status.
    /// </summary>
    [KnownType(typeof(GeneratedStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(GeneratedStatus5Choice.Reason))]
    [JsonDerivedType(typeof(GeneratedStatus5Choice.NoSpecifiedReason),nameof(GeneratedStatus5Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(GeneratedStatus5Choice.Reason),nameof(GeneratedStatus5Choice.Reason))]
    [IsoId("_EsWwGyRhEeO8sskhVI3IDA")]
    [DisplayName("Generated Status 5 Choice")]
    public abstract partial record GeneratedStatus5Choice_
    {
    }
}
