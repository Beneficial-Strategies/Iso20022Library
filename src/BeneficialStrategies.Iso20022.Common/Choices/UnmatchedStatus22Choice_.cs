// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction has not been matched.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus22Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus22Choice.Reason))]
    [JsonDerivedType(
        typeof(UnmatchedStatus22Choice.NoSpecifiedReason),
        nameof(UnmatchedStatus22Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(UnmatchedStatus22Choice.Reason),
        nameof(UnmatchedStatus22Choice.Reason)
    )]
    [IsoId("_TgpI4OCBEei2UYJ62ws-Fw")]
    [DisplayName("Unmatched Status 22 Choice")]
    public abstract record UnmatchedStatus22Choice_ { }
}
