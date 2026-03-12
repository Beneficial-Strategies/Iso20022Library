// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus5Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus5Choice.Reason))]
    [JsonDerivedType(typeof(UnmatchedStatus5Choice.NoSpecifiedReason),nameof(UnmatchedStatus5Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus5Choice.Reason),nameof(UnmatchedStatus5Choice.Reason))]
    [IsoId("_5xWf4f7YEeCtrO5qCU90cA")]
    [DisplayName("Unmatched Status 5 Choice")]
    public abstract partial record UnmatchedStatus5Choice_
    {
    }
}
