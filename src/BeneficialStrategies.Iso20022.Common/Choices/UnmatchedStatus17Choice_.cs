// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus17Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus17Choice.Reason))]
    [JsonDerivedType(
        typeof(UnmatchedStatus17Choice.NoSpecifiedReason),
        nameof(UnmatchedStatus17Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(UnmatchedStatus17Choice.Reason),
        nameof(UnmatchedStatus17Choice.Reason)
    )]
    [IsoId("_wqRNITq0EeWyoP0PbocV1Q")]
    [DisplayName("Unmatched Status 17 Choice")]
    public abstract record UnmatchedStatus17Choice_ { }
}
