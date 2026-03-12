// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction cancellation pending cancellation status.
    /// </summary>
    [KnownType(typeof(PendingCancellationStatus3Choice.NotSpecifiedReason))]
    [KnownType(typeof(PendingCancellationStatus3Choice.Reason))]
    [JsonDerivedType(typeof(PendingCancellationStatus3Choice.NotSpecifiedReason),nameof(PendingCancellationStatus3Choice.NotSpecifiedReason))]
    [JsonDerivedType(typeof(PendingCancellationStatus3Choice.Reason),nameof(PendingCancellationStatus3Choice.Reason))]
    [IsoId("_lFW2jQFnEeG2HcWTGfYeDQ")]
    [DisplayName("Pending Cancellation Status 3 Choice")]
    public abstract partial record PendingCancellationStatus3Choice_
    {
    }
}
