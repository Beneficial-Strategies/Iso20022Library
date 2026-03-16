// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus63Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus63Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus63Choice.NoSpecifiedReason),
        nameof(PendingStatus63Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus63Choice.Reason), nameof(PendingStatus63Choice.Reason))]
    [IsoId("_fvRkkRHpEeuE0Pnt-OcNOA")]
    [DisplayName("Pending Status 63 Choice")]
    public abstract record PendingStatus63Choice_ { }
}
