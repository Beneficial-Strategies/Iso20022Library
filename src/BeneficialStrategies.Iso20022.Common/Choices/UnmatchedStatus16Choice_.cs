// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus16Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus16Choice.Reason))]
    [JsonDerivedType(
        typeof(UnmatchedStatus16Choice.NoSpecifiedReason),
        nameof(UnmatchedStatus16Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(UnmatchedStatus16Choice.Reason),
        nameof(UnmatchedStatus16Choice.Reason)
    )]
    [IsoId("_Hq3ssTqOEeWyoP0PbocV1Q")]
    [DisplayName("Unmatched Status 16 Choice")]
    public abstract record UnmatchedStatus16Choice_ { }
}
