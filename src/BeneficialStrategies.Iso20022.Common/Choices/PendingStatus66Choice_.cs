// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing pending status.
    /// </summary>
    [KnownType(typeof(PendingStatus66Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingStatus66Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingStatus66Choice.NoSpecifiedReason),
        nameof(PendingStatus66Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(PendingStatus66Choice.Reason), nameof(PendingStatus66Choice.Reason))]
    [IsoId("_Kpef0RnzEeyroI8qKgB7Mg")]
    [DisplayName("Pending Status 66 Choice")]
    public abstract record PendingStatus66Choice_ { }
}
