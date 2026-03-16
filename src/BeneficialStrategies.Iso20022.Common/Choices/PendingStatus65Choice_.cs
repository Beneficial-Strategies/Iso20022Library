// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus65Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus65Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus65Choice.NoSpecifiedReason),
        nameof(PendingStatus65Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus65Choice.Reason), nameof(PendingStatus65Choice.Reason))]
    [IsoId("_9FBM3R9QEeuFz_FaCzCLgQ")]
    [DisplayName("Pending Status 65 Choice")]
    public abstract record PendingStatus65Choice_ { }
}
