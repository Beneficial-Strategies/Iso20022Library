// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus19Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus19Choice.Reason))]
    [JsonDerivedType(
        typeof(UnmatchedStatus19Choice.NoSpecifiedReason),
        nameof(UnmatchedStatus19Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(UnmatchedStatus19Choice.Reason),
        nameof(UnmatchedStatus19Choice.Reason)
    )]
    [IsoId("_6BH39ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Unmatched Status 19 Choice")]
    public abstract record UnmatchedStatus19Choice_ { }
}
