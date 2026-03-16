// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus7Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus7Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingCancellationStatus7Choice.NotSpecifiedReason),
        nameof(PendingCancellationStatus7Choice.NotSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationStatus7Choice.Reason),
        nameof(PendingCancellationStatus7Choice.Reason)
    )]
    [IsoId("_1m6c64luEeavwKddCbm3hg")]
    [DisplayName("Pending Cancellation Status 7 Choice")]
    public abstract record PendingCancellationStatus7Choice_ { }
}
