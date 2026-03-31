// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus6Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus6Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingCancellationStatus6Choice.NotSpecifiedReason),
        nameof(PendingCancellationStatus6Choice.NotSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationStatus6Choice.Reason),
        nameof(PendingCancellationStatus6Choice.Reason)
    )]
    [IsoId("_ce_glZKQEeWHWpTQn1FFVg")]
    [DisplayName("Pending Cancellation Status 6 Choice")]
    public abstract record PendingCancellationStatus6Choice_ { }
}
