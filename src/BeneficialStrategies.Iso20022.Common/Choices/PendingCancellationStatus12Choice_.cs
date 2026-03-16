// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Pending Cancellation Status12Choice.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus12Choice.NoSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus12Choice.Reason))]
    [JsonDerivedType(typeof(PendingCancellationStatus12Choice.NoSpecifiedReason),nameof(PendingCancellationStatus12Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus12Choice.Reason),nameof(PendingCancellationStatus12Choice.Reason))]
    [IsoId("_p1C94YYQEe-9jM3-w7OB3g")]
    [DisplayName("Pending Cancellation Status12Choice")]
    public abstract partial record PendingCancellationStatus12Choice_
    {
    }
}
