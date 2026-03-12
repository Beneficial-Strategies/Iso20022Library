// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus8Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus8Choice.Reason))]
    [JsonDerivedType(typeof(PendingCancellationStatus8Choice.NotSpecifiedReason),nameof(PendingCancellationStatus8Choice.NotSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus8Choice.Reason),nameof(PendingCancellationStatus8Choice.Reason))]
    [IsoId("_86aTcZwtEeazcsnODTksnQ")]
    [DisplayName("Pending Cancellation Status 8 Choice")]
    public abstract partial record PendingCancellationStatus8Choice_
    {
    }
}
