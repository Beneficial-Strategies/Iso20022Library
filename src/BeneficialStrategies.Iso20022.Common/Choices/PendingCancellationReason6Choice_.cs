// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or a proprietary code to specify the reason why a cancellation request sent for the related instruction is pending.
    /// </summary>
    [KnownType(typeof(PendingCancellationReason6Choice.Code))]
    [KnownType(typeof(PendingCancellationReason6Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PendingCancellationReason6Choice.Code),
        nameof(PendingCancellationReason6Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PendingCancellationReason6Choice.Proprietary),
        nameof(PendingCancellationReason6Choice.Proprietary)
    )]
    [IsoId("_86aTn5wtEeazcsnODTksnQ")]
    [DisplayName("Pending Cancellation Reason 6 Choice")]
    public abstract record PendingCancellationReason6Choice_ { }
}
