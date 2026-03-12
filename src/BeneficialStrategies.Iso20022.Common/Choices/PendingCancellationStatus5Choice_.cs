// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus5Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus5Choice.Reason))]
    [JsonDerivedType(typeof(PendingCancellationStatus5Choice.NotSpecifiedReason),nameof(PendingCancellationStatus5Choice.NotSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus5Choice.Reason),nameof(PendingCancellationStatus5Choice.Reason))]
    [IsoId("_MHPxAUGXEeWqy4niLuXETA")]
    [DisplayName("Pending Cancellation Status 5 Choice")]
    public abstract partial record PendingCancellationStatus5Choice_
    {
    }
}
