// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus11Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus11Choice.Reason))]
    [JsonDerivedType(
        typeof(PendingCancellationStatus11Choice.NotSpecifiedReason),
        nameof(PendingCancellationStatus11Choice.NotSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationStatus11Choice.Reason),
        nameof(PendingCancellationStatus11Choice.Reason)
    )]
    [IsoId("_0BXX8RUOEeuYppTwWp55gA")]
    [DisplayName("Pending Cancellation Status 11 Choice")]
    public abstract record PendingCancellationStatus11Choice_ { }
}
