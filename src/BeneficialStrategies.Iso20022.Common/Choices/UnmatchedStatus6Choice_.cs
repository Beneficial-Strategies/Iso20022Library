// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus6Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus6Choice.Reason))]
    [JsonDerivedType(typeof(UnmatchedStatus6Choice.NoSpecifiedReason),nameof(UnmatchedStatus6Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(UnmatchedStatus6Choice.Reason),nameof(UnmatchedStatus6Choice.Reason))]
    [IsoId("_EhheBf7ZEeCtrO5qCU90cA")]
    [DisplayName("Unmatched Status 6 Choice")]
    public abstract partial record UnmatchedStatus6Choice_
    {
    }
}
