// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus47Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus47Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus47Choice.NoSpecifiedReason),
        nameof(PendingStatus47Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus47Choice.Reason), nameof(PendingStatus47Choice.Reason))]
    [IsoId("_6BJtWZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Status 47 Choice")]
    public abstract record PendingStatus47Choice_ { }
}
