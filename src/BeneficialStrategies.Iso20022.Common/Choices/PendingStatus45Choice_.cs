// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(PendingStatus45Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus45Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus45Choice.NoSpecifiedReason),
        nameof(PendingStatus45Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus45Choice.Reason), nameof(PendingStatus45Choice.Reason))]
    [IsoId("_5SGOYZNLEeWGlc8L7oPDIg")]
    [DisplayName("Pending Status 45 Choice")]
    public abstract record PendingStatus45Choice_ { }
}
