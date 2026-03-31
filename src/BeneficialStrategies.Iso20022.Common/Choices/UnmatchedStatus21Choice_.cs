// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus21Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus21Choice.Reason))]
    [JsonDerivedType(
        typeof(UnmatchedStatus21Choice.NoSpecifiedReason),
        nameof(UnmatchedStatus21Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(UnmatchedStatus21Choice.Reason),
        nameof(UnmatchedStatus21Choice.Reason)
    )]
    [IsoId("_6d89dZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched Status 21 Choice")]
    public abstract record UnmatchedStatus21Choice_ { }
}
