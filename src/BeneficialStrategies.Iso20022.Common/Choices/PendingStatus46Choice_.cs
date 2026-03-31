// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus46Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus46Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus46Choice.NoSpecifiedReason),
        nameof(PendingStatus46Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus46Choice.Reason), nameof(PendingStatus46Choice.Reason))]
    [IsoId("_6BE0fZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Status 46 Choice")]
    public abstract record PendingStatus46Choice_ { }
}
