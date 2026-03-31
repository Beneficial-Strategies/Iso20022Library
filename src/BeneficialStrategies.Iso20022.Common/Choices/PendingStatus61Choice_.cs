// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus61Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus61Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus61Choice.NoSpecifiedReason),
        nameof(PendingStatus61Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus61Choice.Reason), nameof(PendingStatus61Choice.Reason))]
    [IsoId("_Eztqoe6KEeqc-LCjwLsUVg")]
    [DisplayName("Pending Status 61 Choice")]
    public abstract record PendingStatus61Choice_ { }
}
