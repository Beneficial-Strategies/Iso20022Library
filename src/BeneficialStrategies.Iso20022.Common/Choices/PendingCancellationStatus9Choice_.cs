// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus9Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus9Choice.Reason))]
    [JsonDerivedType(typeof(PendingCancellationStatus9Choice.NotSpecifiedReason),nameof(PendingCancellationStatus9Choice.NotSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus9Choice.Reason),nameof(PendingCancellationStatus9Choice.Reason))]
    [IsoId("_3V7U8f0vEeiKOe8GCUL1Lg")]
    [DisplayName("Pending Cancellation Status 9 Choice")]
    public abstract partial record PendingCancellationStatus9Choice_
    {
    }
}
