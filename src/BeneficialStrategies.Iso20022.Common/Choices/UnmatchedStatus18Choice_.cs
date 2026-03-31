// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(UnmatchedStatus18Choice.NoSpecifiedReason))]
    [KnownType(typeof(UnmatchedStatus18Choice.Reason))]
    [JsonDerivedType(
        typeof(UnmatchedStatus18Choice.NoSpecifiedReason),
        nameof(UnmatchedStatus18Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(UnmatchedStatus18Choice.Reason),
        nameof(UnmatchedStatus18Choice.Reason)
    )]
    [IsoId("_CDyTATw8EeW3QqUkIQtIUA")]
    [DisplayName("Unmatched Status 18 Choice")]
    public abstract record UnmatchedStatus18Choice_ { }
}
