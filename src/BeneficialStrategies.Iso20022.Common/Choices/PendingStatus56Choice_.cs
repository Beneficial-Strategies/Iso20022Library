// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingStatus56Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus56Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus56Choice.NoSpecifiedReason),
        nameof(PendingStatus56Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus56Choice.Reason), nameof(PendingStatus56Choice.Reason))]
    [IsoId("_P3Vi4OBgEeiVRbNQx5-Vhg")]
    [DisplayName("Pending Status 56 Choice")]
    public abstract record PendingStatus56Choice_ { }
}
